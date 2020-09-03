using AutoMapper;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities;
using FSA.SIMSManagerDbEntities.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    public class IncidentsRepository : IDbIncidentsRepository
    {
        private SimsDbContext ctx;
        private readonly IMapper mapper;

        public IDbNotesRepository Notes => new GeneralNotesRepository<IncidentNoteDb>(ctx, mapper);

        public IDbLinkedRecordsRepository Links => new IncidentLinkedRecords(ctx, mapper);

        public IDbProductRepository Products => new GeneralProductRepository<IncidentProductDb, IncidentProductFboDb, IncidentProductPackSizeDb, IncidentProductDateDb>(ctx, mapper);

        public IDbAttachmentsRepository Attachments => new GeneralAttachmentsRepository<IncidentAttachmentDb>(ctx, mapper);

        public IDbStakeholdersRepository Stakeholders => new GeneralStakeholdersRepository<IncidentStakeholderDb>(ctx, mapper);

        public IncidentsRepository(SimsDbContext ctx, IMapper mapper)
        {
            this.ctx = ctx;
            this.mapper = mapper;
        }

        public async Task<BaseIncident> Add(BaseIncident incident)
        {
            //if (incident.CommonId != 0) throw new IncidentExistsException("This item has already been added.");
            var dbItem = mapper.Map<BaseIncident, IncidentDb>(incident);
            dbItem.IncidentCreated = dbItem.Created;
            dbItem.IncidentClosed = null; // Ensure lack of shenanigans
            var dbPonder = this.ctx.Incidents.Add(dbItem);
            await this.ctx.SaveChangesAsync();
            return mapper.Map<IncidentDb, BaseIncident>(dbPonder.Entity);
        }

        /// <summary>
        /// This is not really for day to day use
        /// Mainly for testinf and seeing
        /// </summary>
        /// <param name="incidents"></param>
        /// <returns></returns>
        public async Task Add(IEnumerable<BaseIncident> incidents)
        {

            foreach (var dbincident in mapper.Map<IEnumerable<BaseIncident>, IEnumerable<IncidentDb>>(incidents))
            {
                //if (incident.CommonId != 0) throw new IncidentExistsException("This item has already been added.");

                dbincident.IncidentCreated = dbincident.Created;
                dbincident.IncidentClosed = null; // Ensure lack of shenanigans
                var dbPonder = this.ctx.Incidents.Add(dbincident);
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
            // I dislike plus 4!
            var openStatus = (int)IncidentStatusTypes.Open;
            var closeStatus = (int)IncidentStatusTypes.Closed;

            var WhereClause = String.Join(" OR ", ids.Select(o => $"Id={o}"));
            // Grab the incidents, as long as they are not closed.
            var incidents = ctx.Incidents.FromSqlRaw($"SELECT * from Incidents where ({WhereClause}) AND IncidentStatusId <> {closeStatus}");
            // update the officer, and Ensure they are also operned too.
            foreach (var incident in incidents)
            {
                incident.IncidentStatusId = openStatus;
                incident.LeadOfficer = user;
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
            return mapper.Map<IncidentDb, BaseIncident>(itm);
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
            return mapper.Map<IncidentDb, BaseIncident>(itm);
        }

        public async Task<IEnumerable<BaseIncident>> GetAll()
        {
            var allItems = await this.ctx.Incidents.AsNoTracking().ToListAsync();
            return mapper.Map<IEnumerable<IncidentDb>, IEnumerable<BaseIncident>>(allItems).ToList();
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
            if (await this.IsClosed(id)) throw new ArgumentOutOfRangeException("Cannot update a closed incident.");

            var dbItem = await ctx.Incidents.FindAsync(id);
            dbItem.ClassificationId = ClassificationId;
            await ctx.SaveChangesAsync();
            return mapper.Map<IncidentDb, BaseIncident>(dbItem);
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

            if (dbItem == null) throw new NullReferenceException("No incident was found");
            if (dbItem.IncidentStatusId == (int)IncidentStatusTypes.Closed) throw new ArgumentOutOfRangeException("Cannot update a closed incident!");

            // Logical changes.
            // Mark some differences since last update
            // We are using simpleFlags
            // Have we changed to unassigned, if so ensure we remove the lead officer.
            var unassignLeadOfficer = false;
            if (dbItem.IncidentStatusId == (int)IncidentStatusTypes.Open && incident.StatusId == (int)IncidentStatusTypes.Unassigned)
                unassignLeadOfficer = true;

            //Transfer our updates into the existing incident
            //incident.ToUpdateDb(dbItem);
            mapper.Map(incident, dbItem);
            if (unassignLeadOfficer) dbItem.LeadOfficer = "";

            // Are we closed?
            // Then ensure we update the closed date.
            if (dbItem.IncidentStatusId == (int)IncidentStatusTypes.Closed)
                dbItem.IncidentClosed = DateTime.UtcNow;

            var updatedDbItem = this.ctx.Incidents.Update(dbItem);
            await this.ctx.SaveChangesAsync();
            return mapper.Map<IncidentDb, BaseIncident>(updatedDbItem.Entity);
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
            //if (dbItem.IncidentClosed != null) throw new IncidentClosedException("Cannot update a closed incident!");

            dbItem.IncidentStatusId = statusId;
            if (statusId == (int)IncidentStatusTypes.Unassigned)
                dbItem.LeadOfficer = "";

            await ctx.SaveChangesAsync();
            return mapper.Map<IncidentDb, BaseIncident>(dbItem);
        }

        /// <summary>
        /// Close all the listed incidents
        /// No checks are done to see if this is actually valid
        /// </summary>
        /// <param name="incidentIds"></param>
        /// <returns></returns>
        public async Task BulkClose(IEnumerable<int> incidentIds)
        {
            var WhereClause = String.Join(" OR ", incidentIds.Select(o => $"Id={o}"));
            var items = ctx.Incidents.FromSqlRaw($"SELECT * from Incidents where {WhereClause}");
            var closeStatus = (int)IncidentStatusTypes.Closed;

            foreach (var incident in items)
            {
                incident.IncidentStatusId = closeStatus;
                incident.IncidentClosed = DateTime.UtcNow;
            }

            await this.ctx.SaveChangesAsync();
        }

        public async Task<IncidentsDisplayModel> GetDisplayItem(int id)
        {
            // get the db version.
            // with most lookups (excluding organisations)
            var dbIncident = await this.ctx.Incidents.AsNoTracking()
                        .Include(p => p.Priority)
                        .Include(i => i.Classification)
                        .Include(i => i.DataSource)
                        .Include(i => i.DeathIllness)
                        .Include(i => i.IncidentType)
                        .Include(i => i.ProductType)
                        .Include(i => i.AdminLead)
                        .Include(i => i.Notifier) //.ThenInclude(o => o.Organisation)
                        .Include(i => i.LeadLocalAuthority) //.ThenInclude(o => o.Organisation)
                        .Include(i => i.PrincipalFBO)
                        .Include(i => i.ContactMethod)
                        .Include(i => i.IncidentStatus)
                        .SingleAsync(p => p.Id == id);

            // Finally we can now build our tower of wonder
            return mapper.Map<IncidentDb, IncidentsDisplayModel>(dbIncident);

        }


        public async Task<bool> Exists(int incidentId)
        {
            var isReal = await this.ctx.Incidents.AsNoTracking().FirstOrDefaultAsync(f => f.Id == incidentId) == null;
            return !isReal;
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
        public async Task<IPaging<IncidentDashboardItem>> DashboardSearch(string search = null, int PageSize = 500, int StartPage = 1)
        {

            if (StartPage < 1 || PageSize < 1) return new PagedResult<IncidentDashboardItem>(Enumerable.Empty<IncidentDashboardItem>(), 0);

            var qry = this.ctx.Incidents.AsNoTracking()
                       .Include(i => i.Priority)
                       .Include(i => i.IncidentStatus)
                       .Include(i => i.Notifier) // .ThenInclude(o => o.Organisation)
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

                //Expression<Func<IncidentDb, bool>> idExpressions = null;
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
            var startRecord = (StartPage - 1) * PageSize;
            var results = await qry.OrderByDescending(i => i.IncidentStatus.SortOrder)
                                    .ThenBy(i => i.IncidentCreated)
                                    .Skip(startRecord)
                                    .Take(PageSize)
                                    .Select(i => mapper.Map<IncidentDb, IncidentDashboardItem>(i)).ToListAsync();
            return new PagedResult<IncidentDashboardItem>(results, totalRecords);
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
            var reg = new Regex("(^|-)(?<number>[0-9]+)");// [I-i]?(?<number>[0-9]{1,})");

            // We build the final search terms from this
            var allTerms = new List<string>();
            // any and all matching ids
            var idTerms = new List<int>();
            var totalTerms = search.ToLowerInvariant().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            // Get the person out of the way first, as it can trip up the idmatches 
            var person = totalTerms.Where(o => o.ToLowerInvariant().StartsWith(personClause)).FirstOrDefault();
            if (!string.IsNullOrEmpty(person)) totalTerms.Remove(person);
            // Any matches for the reg ex are added to the idterms
            // Non matches are added to the total terms
            foreach (var term in totalTerms)
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
                allClauses.Add(i => EF.Functions.Like(i.Notifier.Title, wrd));
                allClauses.Add(i => EF.Functions.Like(i.IncidentStatus.Title, wrd));
            }
            // full list of serches on id
            foreach (var id in allIds)
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
        public async Task<IEnumerable<IncidentDashboardItem>> DashboardIncidentLinks(int incidentId)
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
                                .IncidentLinks.AsNoTracking().Where(o => o.ToId == incidentId);

            // the From incidents [This contains the ToLinks]
            var fromIncidents = (from iq in incidentsQry
                                 join fIds in fromIds
                                  on iq.Id equals fIds.FromId
                                 select iq);
            var tLinks = fromIncidents.Select(i => i.FromLinks).SelectMany(o => o);
            // The children of the from incidents
            var fromIncidentList = (from iq in incidentsQry
                                    where tLinks.Any(p => p.ToId == iq.Id)
                                    select iq);

            // ALl from incidents where incidentId is in `from` Column( the original linker)
            var toQ = (from iq in incidentsQry
                       join toLink in ctx.IncidentLinks
                           on iq.Id equals toLink.FromId
                       where toLink.FromId == incidentId
                       select iq);


            var allItems = toQ.Concat(fromIncidentList)
                              .Concat(fromIncidents).Where(o => o.Id != incidentId);

            return await allItems.Select(i => mapper.Map<IncidentDb, IncidentDashboardItem>(i)).ToListAsync();
        }


        /// <summary>
        /// Checkts to see if a particulr incident is closed
        /// Does not check if it exists
        /// </summary>
        /// <param name="incidentId"></param>
        /// <returns>false if not closed</returns>
        public async Task<bool> IsClosed(int incidentId)
        {
            return (await ctx.Incidents.AsNoTracking().SingleAsync(i => i.Id == incidentId))
                           .IncidentStatusId == (int)IncidentStatusTypes.Closed;
        }
    }
}
