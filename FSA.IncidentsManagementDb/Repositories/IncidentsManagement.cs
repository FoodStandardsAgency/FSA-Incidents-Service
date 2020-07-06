using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using IncidentStatus = FSA.IncidentsManagementDb.Entities.Helpers.IncidentStatus;

namespace FSA.IncidentsManagementDb.Repositories
{
    public class IncidentsManagement : IIncidentsManagement
    {
        private FSADbContext ctx;

        public IncidentsManagement(FSADbContext ctx, string editor)
        {
            //this.orgLookups = lkups.Organisations as OrganisationLookupManager;
            this.ctx = ctx;
        }

        public async Task<BaseIncident> Add(BaseIncident incident)
        {

            if (incident.CommonId != 0) throw new ArgumentOutOfRangeException("This item has already been added.");

            var dbItem = incident.ToDb();
            dbItem.IncidentCreated = dbItem.Created;
            dbItem.IncidentClosed = null; // Ensure lack of shenanigans
            var dbPonder = this.ctx.Incidents.Add(dbItem);
            await this.ctx.SaveChangesAsync();
            return dbPonder.Entity.ToClient();
        }
        /// <summary>
        /// This is not really for day to day use
        /// Mainly for testinf and seeing
        /// </summary>
        /// <param name="incidents"></param>
        /// <returns></returns>
        public async Task Add(IEnumerable<BaseIncident> incidents)
        {

            foreach (var incident in incidents)
            {
                if (incident.CommonId != 0) throw new ArgumentOutOfRangeException("This item has already been added.");

                var dbItem = incident.ToDb();
                dbItem.IncidentCreated = dbItem.Created;
                dbItem.IncidentClosed = null; // Ensure lack of shenanigans
                var dbPonder = this.ctx.Incidents.Add(dbItem);
            }

            await this.ctx.SaveChangesAsync();

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
                //UpdateAuditInfo(incidentDb);
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

        /// <summary>
        /// Returns incident from its Most unique id [guid]
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>Incident</returns>
        /// <exception cref="NullReferenceException" />
        public async Task<BaseIncident> Get(Guid guid)
        {
            var itm = await this.ctx.Incidents.AsNoTracking().FirstAsync(f => f.MostUniqueId == guid);
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
        public async Task AddLinks(int from, IEnumerable<int> tos, string reason)
        {
            try
            {
                var allTo = new HashSet<int>(tos);
                // remove our from numb if present
                allTo.Remove(from);

                // helper
                var isReasonPresent = string.IsNullOrEmpty(reason);
                var updatesOccured = false;
                // not my favourite option
                foreach (var to in allTo)
                {
                    var fromTo = ctx.IncidentLinks.AsNoTracking().FirstOrDefault(a => a.FromIncidentId == from && a.ToIncidentId == to);
                    var toFrom = ctx.IncidentLinks.AsNoTracking().FirstOrDefault(a => a.FromIncidentId == to && a.ToIncidentId == from);
                    
                    if (fromTo == null && toFrom == null)
                    {
                        
                        var newLink = new Entities.IncidentLinkDb { FromIncidentId = from, ToIncidentId = to };
                        //SetAuditInfo(newLink);
                        if (!isReasonPresent)
                        {
                            var newFromComment = new IncidentCommentDb { Comment = reason, IncidentId = from };
                            var newToComment = new IncidentCommentDb { Comment = reason, IncidentId = to };
                            //SetAuditInfo(newFromComment);
                            //SetAuditInfo(newToComment);
                            ctx.IncidentComments.Add(newFromComment);
                            ctx.IncidentComments.Add(newToComment);
                        }
                        var toIncident = ctx.Incidents.Find(to);
                        
                        // Update the destination incident, if the incident has not been closed.
                        // This is not a sensible option.
                        if(toIncident.IncidentStatusId != (int)IncidentStatus.Closed)
                        {
                            ctx.Incidents.Update(toIncident);
                        }

                        updatesOccured = true;
                        ctx.IncidentLinks.Add(newLink);
                    }
                }
                // We musht have updated something
                if (allTo.Count > 0 && updatesOccured)
                {
                    var fromIncident = ctx.Incidents.Find(from);
                    //UpdateAuditInfo(fromIncident);
                    this.ctx.Incidents.Update(fromIncident);
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
            //UpdateAuditInfo(dbItem);
            await ctx.SaveChangesAsync();
            return dbItem.ToClient();
        }
        /// <summary>
        /// This is the basic update of direct incident fields
        /// Collections are handled in their own objectsd
        /// </summary>
        /// <param name="incident"></param>
        /// <returns></returns>
        public async Task<BaseIncident> Update(BaseIncident incident)
        {
            var dbItem = this.ctx.Incidents.Find(incident.CommonId);
            
            if (dbItem == null) throw new ArgumentNullException("No incident was found");
            if (dbItem.IncidentClosed != null) throw new ArgumentOutOfRangeException("Cannot update a closed incident!");
            
            // Logical changes.
            // Mark some differences since last update
            // We are using simpleFlags
            // Have we changed to unassigned, if so ensure we remove the lead officer.
            var unassignLeadOfficer = false;
            if (dbItem.IncidentStatusId == (int)IncidentStatus.Open && incident.StatusId == (int)IncidentStatus.Unassigned)
                unassignLeadOfficer = true;
            
            //Transfer our updates into the existing incident
            incident.ToUpdateDb(dbItem);
            if (unassignLeadOfficer) dbItem.LeadOfficer = "";

            // Are we closed?
            // Then ensure we update the closed date.
            if (dbItem.IncidentStatusId == (int)IncidentStatus.Closed)
                dbItem.IncidentClosed = DateTime.UtcNow;


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
            var dbItem = await ctx.Incidents.FindAsync(id);
            if (dbItem.IncidentClosed != null) throw new ArgumentOutOfRangeException("Cannot update a closed incident!");

            dbItem.IncidentStatusId = statusId;
            if (statusId == (int)IncidentStatus.Unassigned)
                dbItem.LeadOfficer = "";
            //UpdateAuditInfo(itm);
            //ctx.Incidents.Update(incident);

            await ctx.SaveChangesAsync();
            return dbItem.ToClient();
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
            var closeStatus = (int)IncidentStatus.Closed;

            foreach (var incident in items)
            {
                incident.IncidentStatusId = closeStatus;
                //UpdateAuditInfo(incident);
                ctx.Incidents.Update(incident);
            }

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
                        .Include(i=>i.AdminLead)
                        .Include(i=>i.Notifier).ThenInclude(o=>o.Organisation)
                        .Include(i=>i.LeadLocalAuthority).ThenInclude(o=>o.Organisation)
                        .Include(i => i.PrincipalFBO).ThenInclude(o => o.Organisation)
                        .Include(i => i.ContactMethod)
                        .Include(i => i.IncidentStatus).First(p => p.Id == id);
            //// now get the fbo organisations data
            //var fboOrg = await this.ctx.Organisations.FindAsync(dbIncident.PrincipalFBOId);

            //// Ensure we only add the same id once.
            //var allOrgIds = new HashSet<int> { dbIncident.NotifierId ?? 0, dbIncident.LeadLocalAuthorityId ?? 0 };
            //// remove empty elements
            //allOrgIds.RemoveWhere(o => o == 0); ;

            // Now fetch all the organisations that match this query.
            //var allOrgs = await this.orgLookups.FindAllLookups(allOrgIds);

            // Finally we can now build our tower of wonder
            return dbIncident.ToClientDisplay();

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
            ctx.IncidentComments.Add(newComment);

            var incident = ctx.Incidents.FirstOrDefault(p=>p.Id == incidentId);
            if(incident.IncidentClosed==null)
                ctx.Incidents.Update(incident);

            await ctx.SaveChangesAsync();
            return newComment.ToClient();
        }


        /// <summary>
        /// return 1 PageSize of data from the incidents table for the dashboard.
        /// returns an empty setother wise.
        /// Search contains simple terms that are split on spcaes. Ppl ids as Person:<<guid>> and may be more.
        /// </summary>
        /// <param name="search"> Null/Empty returns all records for the pages</param>
        /// <param name="PageSize"></param>
        /// <param name="startPage" default="1" ></param>
        /// <returns></returns>
        public async Task<IPaging<IncidentDashboardView>> DashboardSearch(string search = null, int PageSize = 500, int startPage = 1)
        {

            var personClause = "person:";

            if (startPage < 1 || PageSize < 1) return new PagedResult<IncidentDashboardView>(Enumerable.Empty<IncidentDashboardView>(), 0);

            var qry = this.ctx.Incidents.AsNoTracking()
                       .Include(i => i.Priority)
                       .Include(i => i.IncidentStatus)
                       .Include(i => i.Notifier).ThenInclude(o => o.Organisation)
                       .Include(i => i.ToLinks)
                       .Include(i => i.FromLinks).AsQueryable();

            if (!String.IsNullOrEmpty(search))
            {
                // Split out all the terms

                (var searchTerms, var person, var incidentIds) = this.ParseSearchTerms(search);
                // This is what we actually pass to the qry.
                // There are several paths to execution
                // 1. Search + Person
                // 2. Search
                // 3. Person
                Expression<Func<IncidentDb, bool>> searchExpression = null;
                searchExpression = this.DashboardGeneralSearch(searchTerms, incidentIds);

                Expression<Func<IncidentDb, bool>> idExpressions = null;
                //idExpressions = this.DashboardIdSearch(incidentIds);
                if (searchExpression != null)
                    qry = qry.Where(searchExpression);
                if (!string.IsNullOrEmpty(person))
                    qry = qry.Where(o => o.LeadOfficer == person);
                //if (idExpressions != null)
                //    qry = qry.Where(idExpressions);


            }

            // build a where clause
            var totalRecords = await qry.CountAsync();
            // Find the start record
            var startRecord = (startPage - 1) * PageSize;
            var results = await qry.OrderByDescending(i => i.IncidentStatus.SortOrder).ThenBy(i => i.IncidentCreated)
                                   .Skip(startRecord)
                                   .Take(PageSize)
                                   .Select(i => i.ToDashboard()).ToListAsync();
            return new PagedResult<IncidentDashboardView>(results, totalRecords);
        }

        private (List<string> search, string person, List<int> ids) ParseSearchTerms(string search)
        {
            var personClause = "person:";
            // 1. I-000-000
            // 2. i-000-000
            // 3. 000-000   
            // 4. 0002000
            // 5. 000-00000 etc
            //number
            // 
           var reg = new Regex("(^|-)(?<number>[0-9]+)");// [I-i]?(?<number>[0-9]{1,})");
            
            // We build the final search terms from this
            var allTerms = new List<string>();
            // any and all matching ids
            var idTerms = new List<int>();
            var totalTerms = search.ToLowerInvariant().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            // Get the person out of the way first, as it can trip up the idmatches 
            var person = totalTerms.Where(o => o.ToLowerInvariant().StartsWith(personClause)).FirstOrDefault();
            if(!string.IsNullOrEmpty(person)) totalTerms.Remove(person);
            // Any matches for the reg ex are added to the idterms
            // Non matches are added to the total terms
            foreach(var term in totalTerms)
            {
                var matches = reg.Matches(term);
                if (matches.Count == 0)
                    allTerms.Add(term);
                else
                {
                    int id = 0;
                    if (int.TryParse(String.Join("", matches.Select(o => o.Groups["number"].Value)), out id))
                        idTerms.Add(id);
                }
            }

            return (allTerms.Where(o => o.ToLowerInvariant().StartsWith(personClause) == false).ToList(), person != null ? person.Substring(personClause.Length) : person, idTerms);
        }

        private Expression<Func<IncidentDb, bool>> DashboardGeneralSearch(IEnumerable<string> allWords, IEnumerable<int> allIds)
        {
            List<Expression<Func<IncidentDb, bool>>> allClauses = new List<Expression<Func<IncidentDb, bool>>>();
            // The Full list of searches per word
            foreach (var itm in allWords)
            {
                var wrd = $"%{itm}%";
                allClauses.Add(i => EF.Functions.Like(i.IncidentTitle, wrd));
                allClauses.Add(i => EF.Functions.Like(i.Priority.Title, wrd));
                allClauses.Add(i => EF.Functions.Like(i.Notifier.Organisation.Title, wrd));
                allClauses.Add(i => EF.Functions.Like(i.IncidentStatus.Title, wrd));
            }
            // full list of serches on id
            foreach(var id in allIds)
            {
                var capturedId = id;
                allClauses.Add(i => i.Id == capturedId);
            }

            var wordStack = new Stack<Expression<Func<IncidentDb, bool>>>(allClauses);
            // we are going to OR all the clauses together.
            Expression<Func<IncidentDb, bool>> completeSearch = null;
            while (wordStack.Count > 0)
            {
                if (completeSearch == null)
                    completeSearch = wordStack.Pop();
                else
                    completeSearch = completeSearch.Or(wordStack.Pop());
            }
            return completeSearch;
        }

        private Expression<Func<IncidentDb, bool>> DashboardIdSearch(IEnumerable<int> ids)
        {
            List<Expression<Func<IncidentDb, bool>>> idClause = new List<Expression<Func<IncidentDb, bool>>>();

            foreach (var id in ids)
            {
                idClause.Add(i => i.Id == id);
            }

            var idStack = new Stack<Expression<Func<IncidentDb, bool>>>(idClause);
            Expression<Func<IncidentDb, bool>> completeSearch = null;
            // we are going to OR all the clauses together.

            while (idStack.Count > 0)
            {
                if (completeSearch == null)
                    completeSearch = idStack.Pop();
                else
                    completeSearch = completeSearch.Or(idStack.Pop());
            }
            return completeSearch;
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
