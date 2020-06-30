using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using IncidentStatus = FSA.IncidentsManagementDb.Entities.IncidentStatus;

namespace FSA.IncidentsManagementDb.Repositories
{
    public class IncidentsManagement : CoreRepositoryActions, IIncidentsManagement
    {
        private OrganisationLookupManager orgLookups;
        private ILookupDataHost lkups;


        public IncidentsManagement(FSADbContext ctx, string editor, ILookupDataHost lkups) : base(ctx, editor)
        {
            this.orgLookups = lkups.Organisations as OrganisationLookupManager;
            this.lkups = lkups;
        }

        public async Task<BaseIncident> Add(BaseIncident incident)
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
        public async Task AssignLeadOfficer(IEnumerable<int> ids, string user)
        {

            // We are updating the lead officer.
            // If so we can change the incidentStatus to open
            var openStatus = (int)IncidentStatus.Open;
            var closeStatus = (int)IncidentStatus.Closed;

            foreach (var id in ids)
            {
                // Fiind the incident only if its not closed.
                var incidentDb = await this.ctx.Incidents.Include(i => i.IncidentStatus).FirstOrDefaultAsync(o => o.Id == id && o.IncidentStatusId != closeStatus);

                // Don't touch closed entries.
                if (incidentDb.IncidentStatusId != openStatus && incidentDb.IncidentStatusId != closeStatus && user != null)
                    incidentDb.IncidentStatusId = openStatus;
                incidentDb.LeadOfficer = user;
                UpdateAuditInfo(incidentDb);
            }

            await this.ctx.SaveChangesAsync();

        }

        /// <summary>
        /// Returns incident from its numercal id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Incident</returns>
        /// <exception cref="NullReferenceException" />
        public async Task<BaseIncident> Get(int Id)
        {
            var itm = await this.ctx.Incidents.AsNoTracking().FirstAsync(f => f.Id == Id);
            return itm.ToClient();
        }

        public async Task<IEnumerable<BaseIncident>> GetAll()
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
        public async Task AddLink(int from, IEnumerable<int> tos, string reason)
        {
            try
            {
                var allTo = new HashSet<int>(tos);
                // remove our from numb if present
                allTo.Remove(from);

                // helper
                var hasReason = string.IsNullOrEmpty(reason);
                // not my favourite option
                foreach (var to in allTo)
                {
                    var fromTo = ctx.IncidentLinks.AsNoTracking().FirstOrDefault(a => a.FromIncidentId == from && a.ToIncidentId == to);
                    var toFrom = ctx.IncidentLinks.AsNoTracking().FirstOrDefault(a => a.FromIncidentId == to && a.ToIncidentId == from);

                    if (fromTo == null && toFrom == null)
                    {
                        var now = DateTime.UtcNow;
                        var newLink = new Entities.IncidentLinkDb { FromIncidentId = from, ToIncidentId = to };
                        if (!hasReason)
                        {
                            var newFromComment = new IncidentCommentDb { Comment = reason, IncidentId = from };
                            var newToComment = new IncidentCommentDb { Comment = reason, IncidentId = to };
                            SetAuditData(newFromComment, now);
                            SetAuditData(newLink, now);
                            SetAuditData(newToComment, now);
                            ctx.IncidentComments.Add(newFromComment);
                            ctx.IncidentComments.Add(newToComment);
                        }
                        ctx.IncidentLinks.Add(newLink);
                    }
                }
                await ctx.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
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
        public async Task<BaseIncident> UpdateClassification(int id, int ClassificationId)
        {
            var dbItem = await ctx.Incidents.FindAsync(id);
            dbItem.ClassificationId = ClassificationId;
            UpdateAuditInfo(dbItem);
            await ctx.SaveChangesAsync();
            return dbItem.ToClient();
        }

        public async Task<BaseIncident> UpdateIncident(BaseIncident incident)
        {
            var dbItem = this.ctx.Incidents.Find(incident.CommonId);
            if (dbItem == null) throw new ArgumentNullException("No incident was found");
            incident.ToUpdateDb(dbItem);
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
        public async Task<BaseIncident> UpdateStatus(int id, int statusId)
        {
            var itm = await ctx.Incidents.FindAsync(id);
            itm.IncidentStatusId = statusId;
            if (statusId == (int)IncidentStatus.Unassigned)
                itm.LeadOfficer = "";
            
            UpdateAuditInfo(itm);
            await ctx.SaveChangesAsync();
            return itm.ToClient();
        }

        /// <summary>
        /// Close all the listed incidents
        /// No checks are done to see if this is actually valid
        /// </summary>
        /// <param name="incidentIds"></param>
        /// <returns></returns>
        public async Task BulkClose(IEnumerable<int> incidentIds)
        {
            var WhereClause = String.Join(" OR ", incidentIds.Select(o => $"Id={0}"));
            var items = ctx.Incidents.FromSqlRaw($"SELECT * from Incidents where {WhereClause}");
            var closeStatus = await this.lkups.Status.Find("Closed");

            foreach (var item in items)
                item.IncidentStatusId = closeStatus.Id;

            await this.ctx.SaveChangesAsync();
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
                        .Include(i => i.PrincipalFBO).ThenInclude(o => o.Organisation)
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
            var newComment = new IncidentCommentDb { Comment = note, IncidentId = incidentId };
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
                       .Include(i => i.Notifier).ThenInclude(o => o.Organisation)
                       .Include(i => i.ToLinks)
                       .Include(i => i.FromLinks).AsQueryable();

            // split out the words
            var allWords = search.Split(" ");

            for (var x = 0; x < allWords.Length; ++x)
            {
                Expression<Func<IncidentDb, bool>> m = i => EF.Functions.Like(i.IncidentTitle, $"%{allWords[x]}%");
            }

            if (!String.IsNullOrEmpty(search))
                qry = qry.Where(i => EF.Functions.Like(i.IncidentTitle, $"%{search}%")
                                  || EF.Functions.Like(i.IncidentDescription, $"%{search}%")
                                  || EF.Functions.Like(i.Priority.Title, $"%{search}%")
                                  || EF.Functions.Like(i.Notifier.Organisation.Title, $"%{search}%")
                                  || EF.Functions.Like(i.IncidentStatus.Title, $"%{search}%"));// || EF.Functions.Like

            // build a where clause
            var totalRecords = await qry.CountAsync();
            // Find the start record
            var startRecord = (startPage - 1) * PageSize;
            var results = await qry.Skip(startRecord)
                                   .Take(PageSize)
                                   .OrderByDescending(i => i.IncidentStatusId).ThenBy(i => i.IncidentCreated)
                                   .Select(i => i.ToDashboard()).ToListAsync();
            return new PagedResult<IncidentDashboardView>(results, totalRecords);
        }

        /// <summary>
        /// Returns dashbord view for linked incidents.
        /// Excludes the parent Incident.
        /// </summary>
        /// <param name="incidentId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<IncidentDashboardView>> DashboardIncidentLinks(int incidentId)
        {
            var incident = await this.ctx.Incidents
                                    .Include(o => o.FromLinks)
                                    .Include(o => o.ToLinks).AsNoTracking().FirstAsync(f => f.Id == incidentId);

            var incidentsQry = this.ctx.Incidents
                                  .Include(i => i.Priority)
                                   .Include(i => i.IncidentStatus)
                                   .Include(i => i.Notifier).AsQueryable();
            // Where incident was assigned too. from->to
            var fromIds = this.ctx
                                .IncidentLinks.AsNoTracking().Where(o => o.ToIncidentId == incidentId);

            // the From incidents [This contains the ToLinks]
            var fromIncidents = (from iq in incidentsQry
                                 join fIds in fromIds
                                  on iq.Id equals fIds.FromIncidentId
                                 select iq);
            var tLinks = fromIncidents.Select(i => i.FromLinks).SelectMany(o => o);
            // The children of the from incidents
            var fromIncidentList = (from iq in incidentsQry
                                    where tLinks.Any(p => p.ToIncidentId == iq.Id)
                                    select iq);


            // ALl from incidents where incidentId is in `from` Column( the original linker)
            var toQ = (from iq in incidentsQry
                       join toLink in ctx.IncidentLinks
                           on iq.Id equals toLink.ToIncidentId
                       where toLink.FromIncidentId == incidentId
                       select iq);



            // ALl `from` incidents where parent is in then to Column
            //var fromQ = (from iq in incidentsQry
            //             join fromLink in ctx.IncidentLinks
            //                 on iq.Id equals fromLink.FromIncidentId
            //             where fromLink.ToIncidentId == incidentId
            //             select iq);
            // Now get *all* the entries for a from.




            var allItems = toQ.Concat(fromIncidentList)
                              .Concat(fromIncidents).Where(o => o.Id != incidentId);

            return await allItems.Select(i => i.ToDashboard()).ToListAsync();
        }

        /// <summary>
        /// Gets all the notes for a given incident.
        /// </summary>
        /// <param name="incidentId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<IncidentNote>> GetNotes(int incidentId)
        {
            var allNotes = await ctx.IncidentComments.Where(o => o.IncidentId == incidentId).Select(s => s.ToClient()).ToListAsync();
            return allNotes;
        }
    }
}
