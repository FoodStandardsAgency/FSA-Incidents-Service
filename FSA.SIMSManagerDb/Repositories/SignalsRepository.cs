using AutoMapper;
using FSA.IncidentsManagement.Root;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities;
using FSA.SIMSManagerDbEntities.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
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

        public IDbNotesRepository Notes => new SignalNotesRepository(ctx, mapper);

        public IDbLinkedRecordsRepository Links => new LinkedRecordsRepository<SignalLinkDb, SignalNoteDb>(ctx, mapper);

        public IDbProductRepository Products => new ProductRepository<SignalProductDb, SignalProductFboDb, SignalProductPackSizeDb, SignalProductDateDb>(ctx, mapper);

        public IDbAttachmentsRepository Attachments => new AttachmentsRepository<SignalAttachmentDb>(ctx, mapper);

        public IDbStakeholdersRepository Stakeholders => new StakeholdersRepository<SignalStakeholderDb>(ctx, mapper);

        public SignalsRepository(SimsDbContext ctx, IMapper mapper)
        {
            this.ctx = ctx;
            this.mapper = mapper;
        }

        private SignalDb ToDb(SimsSignal ent) => new SignalDb
        {
            Id = 0,
            SPTId = ent.SPTId,
            SourceLink = ent.SourceLink,
            SourceType = ent.SourceType,
            DataSource = ent.DataSource,
            BaseProduct = ent.BaseProduct,
            Manufacturer = ent.Manufacturer,
            LeadOfficer = ent.LeadOfficer,
            AlertType = ent.AlertType,
            CountryOfOrigin = ent.CountryOfOrigin,
            FoodOrFeed = ent.FoodOrFeed,
            Hazard = ent.Hazard,
            HazardGroup = ent.HazardGroup,
            IsEu = ent.IsEu,
            InsertedDate = ent.InsertedDate,
            PublishedDate = ent.PublishedDate,
            NotifyingCountry = ent.NotifyingCountry,
            Priority = ent.Priority,
            Title = ent.Title,
            SignalStatusId = ent.SignalStatusId,
        };

        public async Task AddBatch(IEnumerable<SimsSignal> signals)
        {
            foreach (var signal in signals)
            {
                var dbItem = this.ToDb(signal);
                this.ctx.Signals.Add(dbItem);
            }
            await ctx.SaveChangesAsync();
        }

        public async Task<SimsSignal> Add(SimsSignal signal)
        {
            var dbItem = this.ToDb(signal);
            this.ctx.Signals.Add(dbItem);
            await ctx.SaveChangesAsync();
            return this.mapper.Map<SignalDb, SimsSignal>(dbItem);
        }

        public async Task<SimsSignal> Get(int signalId)
        {
            var dbItem = await this.ctx.Signals.Include(a => a.SignalIncidentLinks).FirstAsync(a => a.Id == signalId);
            if (dbItem != null)
                return this.mapper.Map<SignalDb, SimsSignal>(dbItem);
            else throw new ArgumentNullException();
        }

        public async Task<SimsSignal> Update(SimsSignal signal)
        {
            var dbItem = this.ctx.Signals.Find(signal.CommonId);

            if (dbItem == null) throw new NullReferenceException("No incident was found");
            if (dbItem.SignalStatusId > 50) throw new ArgumentOutOfRangeException("Cannot update a closed signal!");

            // Status changed to un assigned, ensure the officer is taken out.
            if (dbItem.SignalStatusId == (int)SignalStatusTypes.Open && signal.SignalStatusId == (int)SignalStatusTypes.Unassigned)
                signal.LeadOfficer = "";
            // new officer assigned, assure we are open
            if (String.IsNullOrEmpty(dbItem.LeadOfficer) && !String.IsNullOrEmpty(signal.LeadOfficer))
                signal.SignalStatusId = (int)SignalStatusTypes.Open;


            mapper.Map(signal, dbItem);
            var updatedEnt = ctx.Signals.Update(dbItem);

            await ctx.SaveChangesAsync();
            return this.mapper.Map<SignalDb, SimsSignal>(updatedEnt.Entity);
        }

        public async Task<bool> IsClosed(int signalId)
        {
            var dbItem = await this.ctx.Signals.AsNoTracking().FirstAsync(o => o.Id == signalId);
            return dbItem.SignalStatusId >= 50;
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
                        .Include(o => o.SignalStatus)
                        .Include(o => o.ToLinks).AsNoTracking().FirstAsync(f => f.Id == signalId);


            var signalQry = this.ctx.Signals
                         .Include(o => o.FromLinks)
                        .Include(o => o.SignalStatus)
                        .Include(o => o.ToLinks).AsNoTracking();
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
                                .Include(o => o.FromLinks)
                                .Include(o => o.ToLinks)
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
                searchExpression = this.DashboarGenerateSearchExpression(searchTerms, incidentIds);

                if (searchExpression != null)
                    qry = qry.Where(searchExpression);
                if (!string.IsNullOrEmpty(person))
                    qry = qry.Where(o => o.LeadOfficer == person);


            }

            // build a where clause
            var totalRecords = await qry.CountAsync();
            // Find the start record
            var startRecord = (startPage - 1) * pageSize;
            var results = await qry.OrderBy(i => i.SignalStatus.SortOrder)
                                    .ThenByDescending(i => i.InsertedDate)
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
            var AllTerms = new List<string>();
            // any and all matching ids
            var IdTerms = new List<int>();
            var totalTerms = search.ToLowerInvariant().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            // Get the person out of the way first, as it can trip up the idmatches 
            var person = totalTerms.Where(o => o.ToLowerInvariant().StartsWith(personClause)).FirstOrDefault();
            if (!string.IsNullOrEmpty(person)) totalTerms.Remove(person);

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

            return (AllTerms.Where(o => o.ToLowerInvariant().StartsWith(personClause) == false).ToList(), person != null ? person.Substring(personClause.Length) : person, IdTerms);

        }
        /// <summary>
        /// A very lazy copy paste from rhe Incidents.
        /// This (all Dashboard methods) needs, needs needs to be broken out to thieor s own Class.
        /// </summary>
        /// <param name="allWords"></param>
        /// <param name="allIds"></param>
        /// <returns></returns>
        private Expression<Func<SignalDb, bool>> DashboarGenerateSearchExpression(IEnumerable<string> allWords, IEnumerable<int> allIds)
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
                allClauses.Add(i => i.SPTId == capturedId);
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

        public async Task UpdatePriorities(IEnumerable<int> ids, string priority)
        {
            var idList = ids.ToList();
            if (idList.Count > 0)
            {
                var WhereClause = String.Join(" OR ", ids.Select(o => $"Id={o}"));

                // Closed signal is any signal over 50 
                var signals = ctx.Signals.FromSqlRaw($"SELECT * from signals where ({WhereClause}) AND SignalStatusId < 50");
                // update the officer, and Ensure they are also operned too.
                foreach (var signal in signals)
                {
                    signal.Priority = priority;
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

        /// <summary>
        /// Simple closing of an signal.
        /// Must include details
        /// </summary>
        /// <param name="closeDetails"></param>
        /// <returns></returns>
        public async Task CloseNoIncident(SimsSignalCloseNoIncident closeDetails)
        {
            var signal = this.ctx.Signals.Find(closeDetails.SignalId);
            if (signal.SignalStatusId < 50)
            {
                signal.SignalStatusId = closeDetails.StatusCloseId;
                var dbClosedDetails = this.mapper.Map<CloseSignalNoIncidentDb>(closeDetails);
                // duplicatre reason in the notes field.
                //ctx.SignalNotes.Add(new SignalNoteDb { HostId = closeDetails.SignalId, Note = closeDetails.UserReason });

                var closureReason = "Unknown reason";
                var closeReasonId = (SignalStatusTypes)signal.SignalStatusId;
                if (closeReasonId == SignalStatusTypes.Closed_No_Incident)
                    closureReason = "No further action";

                if (closeReasonId == SignalStatusTypes.Closed_Referrel_Offline)
                    closureReason = "Referral";

                var note = this.ClosureNote(closureReason, null,closeDetails.UserReason);
                note.HostId = closeDetails.SignalId;
                this.ctx.Add(dbClosedDetails);
                this.ctx.SignalNotes.Add(note);
                await this.ctx.SaveChangesAsync();
            }
        }
        /// <summary>
        /// Close the signal and associate to an incident
        /// </summary>
        /// <param name="reason">Added to the notes record for the signal</param>
        /// <param name="signalId">required signal</param>
        /// <param name="incidentId">required incident.</param>
        /// <returns></returns>
        public async Task CloseLinkIncident(string reason, int signalId, int incidentId)
        {
            var signal = this.ctx.Signals.Find(signalId);
            if (signal.SignalStatusId < 50)
            {
                this.ctx.SignalIncidentLinks.Add(new Entities.Signals.SignalIncidentLinkDb
                {
                    SignalId = signalId,
                    IncidentId = incidentId
                });
                signal.SignalStatusId = (int)SignalStatusTypes.Closed_Linked_Incident;

                var note = this.ClosureNote("Link to an existing incident", GeneralExtensions.GenerateIncidentId(incidentId), reason);
                note.HostId = signalId;
                this.ctx.SignalNotes.Add(note);

                await ctx.SaveChangesAsync();
            }
        }
        /// <summary>
        /// Close the signal, and create a new incident by copying the data over.
        /// </summary>
        /// <param name="hostId"></param>
        /// <returns></returns>
        public async Task<int> CloseCreateIncident(string reason, int hostId)
        {
            // Create
            var signal = this.ctx.Signals
                                        .Include(a => a.Notes)
                                        .Include(a => a.Stakeholders)
                                        .First(a => a.Id == hostId);


            var signalProds = this.ctx.SignalProducts.AsNoTracking()
                                        .Include(a => a.ProductDates)
                                        .Include(a => a.RelatedFBOs)
                                        .Include(a => a.ProductType)
                                        .Include(a => a.PackSizes)
                                        .Where(o => o.HostId == hostId).ToList();

            if (signal.SignalStatusId < 50)
            {
                // Signals are text all the way
                // But the info should match with our stored lookups.
                var hazardGroup = signal.HazardGroup ?? "";
                var prods = mapper.Map<List<IncidentProductDb>>(signalProds);
                var stakeholders = this.mapper.Map<List<IncidentStakeholderDb>>(signal.Stakeholders);

                var notes = this.mapper.Map<List<IncidentNoteDb>>(signal.Notes);
                // fetch the relevant lookupIds
                var incidentType = this.ctx.HazardGroups.FirstOrDefault(a => a.Title == hazardGroup);
                incidentType = (incidentType == null) ? this.ctx.HazardGroups.FirstOrDefault(a => a.Id == 36) : incidentType;

                var otherDatasource = this.ctx.DataSources.FirstOrDefault(a => a.Title == "FSA RAM Referral");
                var productType = this.ctx.ProductTypes.First(a => a.Title == "Undefined");
                var incidentSource = this.ctx.IncidentSources.First(a => a.Title == "Unknown");
                var newIncident = new IncidentDb
                {
                    IncidentTitle = signal.Title,
                    PriorityId = (int)PrioritiesStatus.TBC,
                    ProductTypeId = productType.Id,
                    IncidentStatusId = (int)IncidentStatusTypes.Unassigned,
                    DataSourceId = otherDatasource.Id,
                    IncidentTypeId = incidentType.Id,
                    SignalUrl = signal.SourceLink,
                    LeadOfficer = "",
                    OIMTGroups = "",
                    ClassificationId = 1, //Routine
                    ContactMethodId = 4, //No Preference
                    IncidentSourceId = incidentSource.Id,
                    IncidentCreated = DateTime.Now,
                    ReceivedOn = DateTime.Now,
                    Stakeholders = stakeholders,
                    Products = prods,
                    Notes = new List<IncidentNoteDb> { new IncidentNoteDb { Note = reason } }.Concat(notes.Reverse<IncidentNoteDb>()).ToList(),
                };

                var savedIncident = ctx.Incidents.Add(newIncident);
                signal.SignalStatusId = (int)SignalStatusTypes.Closed_Incident;

                // save changes, create incident.
                await ctx.SaveChangesAsync();
                // Update links and create closure note
                this.ctx.SignalIncidentLinks.Add(new Entities.Signals.SignalIncidentLinkDb
                {
                    SignalId = signal.Id,
                    IncidentId = savedIncident.Entity.Id
                });

                var note = this.ClosureNote("Create a new incident", GeneralExtensions.GenerateIncidentId(savedIncident.Entity.Id), reason);
                note.HostId = signal.Id;
                signal.Notes.Add(note);

                await ctx.SaveChangesAsync();


                return savedIncident.Entity.Id;
            }

            return -1;
        }

        private SignalNoteDb ClosureNote(string closureType, string incidentRef, string reason)
        {
            var closure = $"Closure Note\n - {closureType}\n\n";
            var incident = String.IsNullOrEmpty(incidentRef) ? "" : $"Incident Ref\n - {incidentRef}\n\n";
            var reasonBlock = $"Your Reason(s)\n{reason}";

            return new SignalNoteDb
            {
                Note = $"{closure}{incident}{reasonBlock}", 
                TagFlags=1
            };
        }

        public async Task UpdateSensitiveInfo(int signalId, bool isSensitive)
        {
            var item = await this.ctx.Signals.FindAsync(signalId);
            item.SensitiveInfo = isSensitive;
            await ctx.SaveChangesAsync();
        }
    }
}
