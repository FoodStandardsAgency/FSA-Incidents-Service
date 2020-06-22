using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagementDb.Repositories
{
    public class IncidentsManagement : CoreRepositoryActions, IIncidentsManagement
    {
        private OrganisationLookupManager orgLookups;
        private ILookupDataHost lkups;


        public IncidentsManagement(FSADbContext ctx, string editor, ILookupDataHost lkups) :base(ctx, editor)
        {
            this.orgLookups = lkups.Organisations as  OrganisationLookupManager;       
            this.lkups = lkups;
        }

        public async Task<Incident> Add(Incident incident)
        {
            if (incident.CommonId != 0) throw new ArgumentOutOfRangeException("This item has already been added.");

            var dbItem = incident.ToDb();
            SetAuditData(dbItem);
            dbItem.IncidentCreated = dbItem.Created;
            var dbPonder = this.ctx.Incidents.Add(dbItem);
            await this.ctx.SaveChangesAsync();
            return dbPonder.Entity.ToClient();
        }
        /// <summary>
        /// Assigns a lead officer to a case.
        /// incidentStatus will be updated to open, if not already set, or closed.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<Incident> AssignLeadOfficer(int id, string user)
        {
            var incidentDb = await this.ctx.Incidents.Include(i=>i.IncidentStatus).FirstAsync(o=>o.Id == id);

            // We are updating the lead officer.
            // If so we can change the incidentStatus to open
            var openStatus = await this.lkups.Status.Find("Open");
            var closeStatus = await this.lkups.Status.Find("Close");    
            if (incidentDb.IncidentStatusId != openStatus.Id  && incidentDb.IncidentStatusId!= closeStatus.Id && user != null)
                incidentDb.IncidentStatusId = openStatus.Id;


            incidentDb.LeadOfficer = user;
            UpdateAuditInfo(incidentDb);
            await this.ctx.SaveChangesAsync();
            return incidentDb.ToClient();
        }

        /// <summary>
        /// Returns incident from its numercal id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Incident</returns>
        /// <exception cref="NullReferenceException" />
        public async Task<Incident> Get(int Id)
        {
            var itm = await this.ctx.Incidents.AsNoTracking().FirstAsync(f => f.Id == Id);
            return itm.ToClient();
        }

        public async Task<IEnumerable<Incident>> GetAll()
        {
            return (await this.ctx.Incidents.AsNoTracking().ToListAsync()).ToClient().ToList();
        }

        /// <summary>
        /// Joins two incidents
        /// As long as they have not already been joined.
        /// We check in both directions.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public async Task AddLink(int from, int to, string reason)
        {
            var fromTo = ctx.IncidentLinks.AsNoTracking().FirstOrDefault(a => a.FromIncidentId == from && a.ToIncidentId == to);
            var toFrom = ctx.IncidentLinks.AsNoTracking().FirstOrDefault(a => a.FromIncidentId == to && a.ToIncidentId == from);

            if (fromTo == null && toFrom == null)
            {
                var now = DateTime.UtcNow;
                var newLink = new Entities.IncidentLinkDb { FromIncidentId = from, ToIncidentId = to };
                var newFromComment = new IncidentCommentDb { Comment = reason, IncidentId = from };
                var newToComment = new IncidentCommentDb { Comment = reason, IncidentId = to };
                SetAuditData(newLink, now);
                SetAuditData(newFromComment, now);
                SetAuditData(newToComment, now);
                ctx.IncidentLinks.Add(newLink);
                ctx.IncidentComments.Add(newFromComment);
                ctx.IncidentComments.Add(newToComment);
                await ctx.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Update only a classification in an incident
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ClassificationId"></param>
        /// <returns>
        /// The updated incident
        /// </returns>
        /// <exception cref="NullReferenceException" />
        public async Task<Incident> UpdateClassification(int id, int ClassificationId)
        {
            var dbItem = await ctx.Incidents.FindAsync(id);
            dbItem.ClassificationId = ClassificationId;
            UpdateAuditInfo(dbItem);
            await ctx.SaveChangesAsync();
            return dbItem.ToClient();
        }

        public async Task<Incident> UpdateIncident(Incident incident)
        {
            var dbItem = incident.ToDb();
            UpdateAuditInfo(dbItem);
            var updatedDbItem = this.ctx.Incidents.Update(dbItem);
            await this.ctx.SaveChangesAsync();
            return updatedDbItem.Entity.ToClient();
        }

        /// <summary>
        /// Update only a Stats in an incident
        /// </summary>
        /// <param name="id"></param>
        /// <param name="statusId">Must match</param>
        /// <returns>
        /// The updated incident
        /// </returns>
        /// <exception cref="NullReferenceException" />
        public async Task<Incident> UpdateStatus(int id, int statusId)
        {
            var itm = await ctx.Incidents.FindAsync(id);
            itm.IncidentStatusId = statusId;
            UpdateAuditInfo(itm);
            await ctx.SaveChangesAsync();
            return itm.ToClient();
        }

        public async Task<IncidentsDisplayModel> GetDisplayItem(int id)
        {
            // get the db version.
            // with most lookups (excluding organisations)
            var dbIncident = this.ctx.Incidents.AsNoTracking()
                        .Include(p => p.Priority)
                        .Include(i => i.Classification)
                        .Include(i => i.DataSource)
                        .Include(i => i.DeathIllness)
                        .Include(i => i.IncidentType)
                        .Include(i => i.ProductType)
                        .Include(i => i.PrincipalFBO)
                        .Include(i => i.ContactMethod)
                        .Include(i => i.IncidentStatus).First(p => p.Id == id);
            // now get the fbo organisations data
            var fboOrg = await this.ctx.Organisations.FindAsync(dbIncident.PrincipalFBOId);

            // Ensure we only add the same id once.
            var allOrgIds = new HashSet<int> { dbIncident.NotifierId ?? 0, dbIncident.LeadLocalAuthorityId ?? 0 };
            // remove empty elements
            allOrgIds.RemoveWhere(o => o == 0); ;

            // Now fetch all the organisations that match this query.
            var allOrgs = await this.orgLookups.FindAllLookups(allOrgIds);

            // Finally we can now build our tower of wonder
            return dbIncident.ToClient(allOrgs, fboOrg);

        }
        /// <summary>
        /// Insert comment can be done in various situations
        /// </summary>
        /// <param name="incidentId"></param>
        /// <param name="note"></param>
        /// <returns></returns>
        public async Task<IncidentNote> AddNote(int incidentId, string note)
        {
            var newComment = new IncidentCommentDb { Comment = note, Id = incidentId };
            SetAuditData(newComment, DateTime.UtcNow);
            ctx.IncidentComments.Add(newComment);
            await ctx.SaveChangesAsync();
            return newComment.ToClient();
        }

        /// <summary>
        /// return 1 PageSize of data from the incidents table for the dashboard.
        /// returns an empty setother wise.
        /// </summary>
        /// <param name="search"> Null/Empty returns all records for the pages</param>
        /// <param name="PageSize"></param>
        /// <param name="startPage" default="1" ></param>
        /// <returns></returns>
        public async Task<IPaging<IncidentDashboardView>> DashboardSearch(string search = null, int PageSize = 500, int startPage = 1)
        {
            if (startPage < 1 || PageSize < 1) return new PagedResult<IncidentDashboardView>(Enumerable.Empty<IncidentDashboardView>(), 0);

            var qry = this.ctx.Incidents.AsNoTracking()
                       .Include(i => i.Priority)
                       .Include(i => i.IncidentStatus)
                       .Include(i => i.Notifier)
                       .Include(i => i.ToLinks)
                       .Include(i => i.FromLinks).AsQueryable();

            if (!String.IsNullOrEmpty(search))
                qry = qry.Where(i => EF.Functions.Like(i.IncidentTitle, $"%{search}%") || EF.Functions.Like(i.IncidentDescription, $"%{search}%"));// || EF.Functions.Like(i.IncidentDescription, search));
            // build a where clause
            var totalRecords = await qry.CountAsync();
            // Find the start record
            var startRecord = (startPage - 1) * PageSize;

            // WE also need to query the links table a second time for any appearances in the 'to' column.
            
            var results = await qry.Skip(startRecord).Take(PageSize).Select(i => i.ToDashboard()).ToListAsync();
            return new PagedResult<IncidentDashboardView>(results, totalRecords);
        }
    }
}
