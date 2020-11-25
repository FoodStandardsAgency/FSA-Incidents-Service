using AutoMapper;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public async Task CloseCreateIncident(int onlineFormId, string reason)
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
    }
}
