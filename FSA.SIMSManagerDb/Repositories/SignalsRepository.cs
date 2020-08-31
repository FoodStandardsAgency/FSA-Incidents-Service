using AutoMapper;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    internal class SignalsRepository : IDbSignalsRepository
    {
        private readonly SimsDbContext ctx;
        private readonly IMapper mapper;

        public IDbNotesRepository Notes => new GeneralNotesRepository<SignalNoteDb>(ctx, mapper);

        public IDbLinkedRecordsRepository Links => new SignalsLinkedRecords(ctx, mapper);

        public IDbProductRepository Products => new GeneralProductRepository<SignalProductDb, SignalProductFboDb, SignalProductPackSizeDb, SignalProductDateDb>(ctx, mapper);

        public IDbAttachmentsRepository Attachments => new GeneralAttachmentsRepository<SignalAttachmentDb>(ctx, mapper);

        public IDbStakeholdersRepository Stakeholders => new GeneralStakeholdersRepository<SignalStakeholderDb>(ctx, mapper);

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
            var dbItem = this.ctx.Signals.Find(signalId);
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
    }
}
