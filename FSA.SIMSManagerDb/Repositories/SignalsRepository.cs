using AutoMapper;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities;
using FSA.SIMSManagerDbEntities.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    internal class SignalsRepository : IDbSignalsRepository
    {
        private readonly SimsDbContext ctx;
        private readonly IMapper mapper;

        public IDbNotesRepository Notes => new NotesRepository<SignalNoteDb>(ctx, mapper);

        public IDbLinkedRecordsRepository Links => new LinkedRecordsRepository<SignalLinkDb, SignalNoteDb>(ctx, mapper);

        public IDbProductRepository Products => new ProductRepository<SignalProductDb, SignalProductFboDb, SignalProductPackSizeDb, SignalProductDateDb>(ctx, mapper);

        public IDbAttachmentsRepository Attachments => new AttachmentsRepository<SignalAttachmentDb>(ctx, mapper);

        public IDbStakeholdersRepository Stakeholders => new StakeholdersRepository<SignalStakeholderDb>(ctx, mapper);

        public SignalsRepository(SimsDbContext ctx, IMapper mapper)
        {
            this.ctx = ctx;
            this.mapper = mapper;
        }

        public async Task AddBatch(IEnumerable<SimsSignal> signals)
        {
            foreach (var signal in signals)
            {
                var dbItem = this.mapper.Map<SimsSignal, SignalDb>(signal);
                this.ctx.Signals.Add(dbItem);
            }
            await ctx.SaveChangesAsync();
        }

        public async Task<SimsSignal> Add(SimsSignal signal)
        {
            var dbItem = this.mapper.Map<SimsSignal, SignalDb>(signal);
            this.ctx.Signals.Add(dbItem);
            await ctx.SaveChangesAsync();
            return this.mapper.Map<SignalDb, SimsSignal>(dbItem);
        }

        public async Task<SimsSignal> Get(int signalId)
        {
            var dbItem = await this.ctx.Signals.FindAsync(signalId);
            if (dbItem != null)
                return this.mapper.Map<SignalDb, SimsSignal>(dbItem);
            else throw new ArgumentNullException();
        }

        public async Task<SimsSignal> Update(SimsSignal signal)
        {
            var dbItem = this.ctx.Signals.Find(signal.Id);
            if (dbItem.SPTId is null && signal.SPTId.HasValue || (dbItem.SPTId != signal.SPTId))
                throw new ArgumentOutOfRangeException("Cannot update SPTid.");

            if (dbItem.PublishedDate != signal.PublishedDate)
                throw new ArgumentOutOfRangeException("Cannot update Published date.");
            if (dbItem.InsertedDate != signal.InsertedDate)
                throw new ArgumentOutOfRangeException("Cannot update Inserted date.");

            mapper.Map(signal, dbItem);
            var updatedEnt = ctx.Signals.Update(dbItem);
            await ctx.SaveChangesAsync();
            return this.mapper.Map<SignalDb, SimsSignal>(updatedEnt.Entity);
        }

        public async Task<bool> IsClosed(int signalId)
        {
            var dbItem = await this.ctx.Signals.AsNoTracking().FirstAsync(o => o.Id == signalId);
            return dbItem.SignalStatusId == (int)SignalStatusTypes.Closed_Incident || dbItem.SignalStatusId == (int)SignalStatusTypes.Closed_No_Incident;
        }

        public async Task<bool> Exists(int signalId)
        {
            var dbItem = await this.ctx.Signals.AsNoTracking().FirstOrDefaultAsync(o => o.Id == signalId);
            return dbItem != null;
        }

        public async Task<IEnumerable<SignalDashboardItem>> DashboardLinks(int signalId)
        {
            var hostIncident = await this.ctx.Signals
                        .Include(o => o.FromLinks)
                        .Include(o => o.ToLinks).AsNoTracking().FirstAsync(f => f.Id == signalId);


            var signalQry = this.ctx.Signals;
            // Where signal was assigned too. SignalId->to
            var fromIds = this.ctx
                                .SignalLinks.AsNoTracking().Where(o => o.ToId == signalId);

            // the From signals [This contains the ToLinks]
            var fromSignals = (from iq in signalQry
                               join fIds in fromIds
                                on iq.Id equals fIds.FromId
                               select iq);
            var tLinks = fromSignals.Select(i => i.FromLinks).SelectMany(o => o);
            // The children of the from signals
            var fromSignalList = (from iq in signalQry
                                  where tLinks.Any(p => p.ToId == iq.Id)
                                  select iq);

            // ALl from signal where incidentId is in `from` Column( the original linker) to<-SignalId
            var toQ = (from iq in signalQry
                       join toLink in ctx.SignalLinks
                           on iq.Id equals toLink.ToId
                       where toLink.FromId == signalId
                       select iq);


            var allItems = toQ.Concat(fromSignalList)
                              .Concat(fromSignals).Where(o => o.Id != signalId);

            return await allItems.Select(i => mapper.Map<SignalDb, SignalDashboardItem>(i)).ToListAsync();
        }

        public async Task<IPaging<SignalDashboardItem>> DashboardSearch(string search = null, int pageSize = 500, int startPage = 1)
        {
            if (startPage < 1 || pageSize < 1) return new PagedResult<SignalDashboardItem>(Enumerable.Empty<SignalDashboardItem>(), 0);

            var qry = this.ctx.Signals
                                .Include(o => o.SignalStatus)
                                .AsNoTracking().AsQueryable();

            if (!String.IsNullOrEmpty(search))
            {
                // Split out all the terms

                (var searchTerms, var person, var incidentIds) = this.ParseSearchTerms(search);
                // This is what we actually pass to the qry.
                // There are several paths to execution
                // 1. Search + Person
                // 2. Search
                // 3. Person
                Expression<Func<SignalDb, bool>> searchExpression = null;
                searchExpression = this.DashboardGeneralSearch(searchTerms, incidentIds);

                if (searchExpression != null)
                    qry = qry.Where(searchExpression);
                if (!string.IsNullOrEmpty(person))
                    qry = qry.Where(o => o.LeadOfficer == person);


            }

            // build a where clause
            var totalRecords = await qry.CountAsync();
            // Find the start record
            var startRecord = (startPage - 1) * pageSize;
            var results = await qry  //.OrderByDescending(i => i.IncidentStatus.SortOrder)
                                    .OrderBy(i => i.Created)
                                    .Skip(startRecord)
                                    .Take(pageSize)
                                    .Select(i => mapper.Map<SignalDb, SignalDashboardItem>(i)).ToListAsync();
            return new PagedResult<SignalDashboardItem>(results, totalRecords);
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


        /// <summary>
        /// A very lazy copy paste from rhe Incidents.
        /// This (all Dashboard methods) needs, needs needs to be broken out to thieor s own Class.
        /// </summary>
        /// <param name="allWords"></param>
        /// <param name="allIds"></param>
        /// <returns></returns>
        private Expression<Func<SignalDb, bool>> DashboardGeneralSearch(IEnumerable<string> allWords, IEnumerable<int> allIds)
        {
            List<Expression<Func<SignalDb, bool>>> allClauses = new List<Expression<Func<SignalDb, bool>>>();
            // The Full list of searches per word
            foreach (var itm in allWords)
            {
                var wrd = $"%{itm}%";
                allClauses.Add(i => EF.Functions.Like(i.Title, wrd));
                allClauses.Add(i => EF.Functions.Like(i.Priority, wrd));
                allClauses.Add(i => EF.Functions.Like(i.BaseProduct, wrd));
                allClauses.Add(i => EF.Functions.Like(i.SignalStatus.Title, wrd));
            }
            // full list of serches on id
            foreach (var id in allIds)
            {
                var capturedId = id;
                allClauses.Add(i => i.Id == capturedId);
            }

            var wordStack = new Stack<Expression<Func<SignalDb, bool>>>(allClauses);
            // we are going to OR all the clauses together.
            Expression<Func<SignalDb, bool>> completeSearch = null;
            while (wordStack.Count > 0)
            {
                if (completeSearch == null)
                    completeSearch = wordStack.Pop();
                else
                    completeSearch = completeSearch.Or(wordStack.Pop());
            }
            return completeSearch;
        }



        public async Task UpdateLeadOfficer(IEnumerable<int> ids, string user)
        {
            var idList = ids.ToList();
            if (idList.Count > 0)
            {
                var WhereClause = String.Join(" OR ", ids.Select(o => $"Id={o}"));

                var signals = ctx.Signals.FromSqlRaw($"SELECT * from signals where ({WhereClause})");
                // update the officer, and Ensure they are also operned too.
                foreach (var signal in signals)
                {
                    signal.SignalStatusId = (int)SignalStatusTypes.Open;
                    signal.LeadOfficer = user;
                }

                await this.ctx.SaveChangesAsync();
            }
        }

        public async Task<SimsSignal> UpdateStatus(int id, int status)
        {
            var dbItem = await ctx.Signals.FindAsync(id);
            dbItem.SignalStatusId = status;
            if (status == (int)SignalStatusTypes.Unassigned)
                dbItem.LeadOfficer = "";
            await ctx.SaveChangesAsync();
            return mapper.Map<SignalDb, SimsSignal>(dbItem);
        }
    }
}
