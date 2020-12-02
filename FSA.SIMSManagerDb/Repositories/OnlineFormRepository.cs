using AutoMapper;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Shared;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities;
using FSA.SIMSManagerDbEntities.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    internal class OnlineFormRepository : IDbOnlineFormRepository
    {
        private readonly SimsDbContext ctx;
        private readonly IMapper mapper;

        public OnlineFormRepository(SimsDbContext ctx, IMapper mapper)
        {
            this.ctx = ctx;
            this.mapper = mapper;
        }

        public IDbProductRepository Products => new ProductRepository<OnlineFormProductDb, OnlineFormProductFboDb, OnlineFormProductPackSizeDb, OnlineFormProductDateDb>(ctx, mapper);

        public IDbNotesRepository Notes => new NotesRepository<OnlineFormNoteDb>(ctx, mapper);

        public IDbStakeholdersRepository Stakeholders => new StakeholdersRepository<OnlineFormStakeholderDb>(ctx, mapper);

        public async Task<IPaging<SimsOnlineFormDashboardItem>> DashboardSearch(string search = null, int pageSize = 500, int startPage = 1)
        {
            if (startPage < 1 || pageSize < 1) return new PagedResult<SimsOnlineFormDashboardItem>(Enumerable.Empty<SimsOnlineFormDashboardItem>(), 0);

            var qry = this.ctx.OnlineForms
                      .AsNoTracking().AsQueryable();

            if(!String.IsNullOrEmpty(search))
            {
                (var generalTerms, var idTokens) = this.ParseSearchTerms(search);
                Expression<Func<OnlineFormDb, bool>> searchExpression = null;
                searchExpression = this.DashboarGenerateSearchExpression(generalTerms, idTokens);

                if (searchExpression != null)
                    qry = qry.Where(searchExpression);

            }
            // build a where clause
            var totalRecords = await qry.CountAsync();
            // Find the start record
            var startRecord = (startPage - 1) * pageSize;
            var results = await qry.OrderBy(i => i.IsClosed== false)
                                    .ThenByDescending(i => i.Created)
                                    .Skip(startRecord)
                                    .Take(pageSize)
                                    .Select(i => mapper.Map<SimsOnlineFormDashboardItem>(i)).ToListAsync();
            return new PagedResult<SimsOnlineFormDashboardItem>(results, totalRecords);

        }
      
        /// <summary>
        /// A very lazy copy paste from Signals.
        /// This (all Dashboard methods) needs, needs needs to be broken out to thieor s own Class.
        /// </summary>
        /// <param name="allWords"></param>
        /// <param name="allIds"></param>
        /// <returns></returns>
        private Expression<Func<OnlineFormDb, bool>> DashboarGenerateSearchExpression(List<string> allWords, List<int> allIds)
        {
            List<Expression<Func<OnlineFormDb, bool>>> allClauses = new List<Expression<Func<OnlineFormDb, bool>>>();
            // The Full list of searches per word
            foreach (var itm in allWords)
            {
                var wrd = $"%{itm}%";
                allClauses.Add(i => EF.Functions.Like(i.Title, wrd));
                allClauses.Add(i => EF.Functions.Like(i.ReferenceNo, wrd));
                //allClauses.Add(i => EF.Functions.Like(i.NotifierType, wrd));
                allClauses.Add(i => EF.Functions.Like(i.LADetails, wrd));

            }
            // full list of serches on id
            foreach (var id in allIds)
            {
                var capturedId = id;
                allClauses.Add(i => i.Id == capturedId);
            }

            var wordStack = new Stack<Expression<Func<OnlineFormDb, bool>>>(allClauses);
            // we are going to OR all the clauses together.
            Expression<Func<OnlineFormDb, bool>> completeSearch = null;
            while (wordStack.Count > 0)
            {
                if (completeSearch == null) //look! A good use of null
                    completeSearch = wordStack.Pop();
                else
                    completeSearch = completeSearch.Or(wordStack.Pop());
            }
            return completeSearch;
        }

        private (List<string> search, List<int> ids) ParseSearchTerms(string search)
        {
            // 1. I-000-000
            // 2. i-000-000
            // 3. 000-000   
            // 4. 0002000
            // 5. 000-00000 etc
            //number
            var reg = new Regex("(^|-)(?<number>[0-9]+)");// [I-i]?(?<number>[0-9]{1,})");

            // We build the final search terms from this
            var AllTerms = new List<string>();
            // any and all matching ids
            var IdTerms = new List<int>();
            var totalTerms = search.ToLowerInvariant().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            // Non matches are added to the AllTerms object
            // Any matches for the reg ex are added to the IdTems
            foreach (var term in totalTerms)
            {
                var matches = reg.Matches(term);
                if (matches.Count == 0)
                    AllTerms.Add(term);
                else
                {
                    int id = 0;
                    if (int.TryParse(String.Join("", matches.Select(o => o.Groups["number"].Value)), out id))
                        IdTerms.Add(id);
                }
            }

            return (AllTerms, IdTerms);
        }

            public async Task<SimsOnlineForm> Add(SimsOnlineForm onlineForm)
        {
            var newEntity = mapper.Map<OnlineFormDb>(onlineForm);
            var ent = await ctx.AddAsync(newEntity);
            await ctx.SaveChangesAsync();
            return mapper.Map<SimsOnlineForm>(ent.Entity);
        }

        public async Task AddBatch(IEnumerable<SimsOnlineForm> onlineForms)
        {
            var newEntities = mapper.Map<List<OnlineFormDb>>(onlineForms);
            newEntities.ForEach(a => ctx.Add(a));
            await ctx.SaveChangesAsync();
        }

        public async Task<int> CloseCreateIncident(int onlineFormId, string reason)
        {
            var dbEnt = this.ctx.OnlineForms
                                     .Include(a => a.Notes)
                                     .Include(a => a.Stakeholders)
                                     .First(a => a.Id == onlineFormId);
            if (!dbEnt.IsClosed)
            {
                ctx.OnlineFormNotes.Add(new OnlineFormNoteDb
                {
                    HostId = onlineFormId,
                    Note = reason
                });
                // tracked item automatically update on save
                dbEnt.IsClosed = true;

                // Now create an incident
                var onlineProds = this.ctx.OnlineFormProducts.AsNoTracking()
                                            .Include(a => a.ProductDates)
                                            .Include(a => a.RelatedFBOs)
                                            .Include(a => a.ProductType)
                                            .Include(a => a.PackSizes)
                                            .Where(o => o.HostId == onlineFormId).ToList();


                var prods = mapper.Map<List<IncidentProductDb>>(onlineProds);
                var stakeholders = this.mapper.Map<List<IncidentStakeholderDb>>(dbEnt.Stakeholders);

                var notes = this.mapper.Map<List<IncidentNoteDb>>(dbEnt.Notes);
                var productType = this.ctx.ProductTypes.First(a => a.Title == "Undefined");
                var incidentSource = this.ctx.IncidentSources.First(a => a.Title == "Unknown");
                var newIncident = new IncidentDb
                {
                    IncidentTitle = dbEnt.Title,
                    PriorityId = (int)PrioritiesStatus.TBC,
                    ProductTypeId = productType.Id,
                    IncidentStatusId = (int)IncidentStatusTypes.Unassigned,
                    DataSourceId = 46, // Other
                    IncidentTypeId = 36,
                    NotifierId = dbEnt.NotifierTypeId,
                    SignalUrl = "",
                    LeadOfficer = "",
                    OIMTGroups = "",
                    ClassificationId = 1, //Routine
                    ContactMethodId = 4, //No Preference
                    IncidentSourceId = incidentSource.Id,
                    IncidentCreated = DateTime.Now,
                    ReceivedOn = DateTime.Now,
                    Stakeholders = stakeholders,
                    Products = prods,
                    OnlineFormReference = dbEnt.ReferenceNo,
                    Notes = new List<IncidentNoteDb> { new IncidentNoteDb { Note = reason } }.Concat(notes.Reverse<IncidentNoteDb>()).ToList(),
                };
                var savedIncident = ctx.Incidents.Add(newIncident);

                await ctx.SaveChangesAsync();
                return savedIncident.Entity.Id;
            }
            return -1;
        }

        public async Task CloseNoIncident(int onlineFormId, string reason)
        {
            var dbEnt = ctx.OnlineForms.First(a => a.Id == onlineFormId);
            ctx.OnlineFormNotes.Add(new OnlineFormNoteDb
            {
                HostId = onlineFormId,
                Note = reason
            });
            dbEnt.IsClosed = true;

            await ctx.SaveChangesAsync();

        }

        public async Task<bool> Exists(int onlineFormId)
        {
            return (await ctx.OnlineForms.AsNoTracking().FirstOrDefaultAsync(a => a.Id == onlineFormId)) != null;
        }

        public async Task<SimsOnlineForm> Get(int formId)
        {
            var ent = await ctx.OnlineForms.AsNoTracking().FirstAsync(a => a.Id == formId);
            return mapper.Map<SimsOnlineForm>(ent);
        }

        public async Task<bool> IsClosed(int onlineFormId)
        {
            var dbEnt = await ctx.OnlineForms.AsNoTracking().FirstAsync(a => a.Id == onlineFormId);
            return dbEnt.IsClosed;
        }

        public async Task<SimsOnlineForm> Update(SimsOnlineForm onlineForm)
        {
            
            var dbEnt = this.ctx.OnlineForms.Find(onlineForm.CommonId);
            if(dbEnt==null) throw new NullReferenceException("Cannot find Online form");
            if (dbEnt.IsClosed) throw new AccessViolationException("Online form closed.");
            if (!dbEnt.IsClosed && onlineForm.IsClosed == true) throw new DataMisalignedException("Cannot close Online form. Incorrect method.");
            mapper.Map(onlineForm, dbEnt);
            ctx.Update(dbEnt);
            await ctx.SaveChangesAsync();
            return this.mapper.Map<SimsOnlineForm>(dbEnt);

        }

        public async Task<bool> ReferenceNoExists(string refNo)=> (await this.ctx.OnlineForms.FirstOrDefaultAsync(a => a.ReferenceNo == refNo))!=null;

        public async Task AddFromExternalSource(JsonDocument formDocument)
        {
            //Break this out into it's constituent chunks.
            // ReferenceNo : string
            // Incidents : object
            // IncidentStakeholders : object (Addresse
            // Addresses : object ACtually 1 address for stakeholder to become notes
            // IncidentProducts : object Graph, Sames as incident proces except for datw
        }
    }
}
