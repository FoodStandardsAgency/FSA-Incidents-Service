using AutoMapper;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            mapper.Map(signal, dbItem);
            var updatedEnt = ctx.Signals.Update(dbItem);
            await ctx.SaveChangesAsync();
            return this.mapper.Map<SignalDb, SimsSignal>(updatedEnt.Entity);
        }

        public async Task<bool> IsClosed(int signalId)
        {
            var dbItem = await this.ctx.Signals.AsNoTracking().FirstAsync(o => o.Id == signalId);
            return dbItem.SignalStatus == "Closed";
        }

        public async Task<bool> Exists(int signalId)
        {
            var dbItem = await this.ctx.Signals.AsNoTracking().FirstOrDefaultAsync(o => o.Id == signalId);
            return dbItem != null;
        }

        public Task<IEnumerable<SignalDashboardItem>> DashboardLinks(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IPaging<SignalDashboardItem>> DashboardSearch(string search = null, int pageSize = 500, int startPage = 1)
        {
            throw new NotImplementedException();
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
                    signal.SignalStatus = "Open";
                    signal.LeadOfficer = user;
                }

                await this.ctx.SaveChangesAsync();
            }
        }

        public async Task<SimsSignal> UpdateStatus(int id, string status)
        {
            var dbItem = await ctx.Signals.FindAsync(id);
            dbItem.SignalStatus = status;
            if (status.ToLowerInvariant() == "unassigned")
                dbItem.LeadOfficer = "";
            await ctx.SaveChangesAsync();
            return mapper.Map<SignalDb, SimsSignal>(dbItem);
        }
    }
}
