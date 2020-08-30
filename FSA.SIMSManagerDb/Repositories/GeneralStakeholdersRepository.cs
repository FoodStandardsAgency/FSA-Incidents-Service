using AutoMapper;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Entities.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    internal class GeneralStakeholdersRepository<T> : IDbStakeholdersRepository where T : BaseStakeholderDb
    {
        private readonly SimsDbContext ctx;
        private DbSet<T> DbSet;
        private readonly IMapper mapper;

        public GeneralStakeholdersRepository(SimsDbContext ctx, IMapper mapper)
        {
            this.ctx = ctx;
            this.DbSet = ctx.Set<T>();
            this.mapper = mapper;
        }

        public Task<List<SimsStakeholder>> GetAll(int hostId)
        {
            if (hostId == 0) throw new ArgumentOutOfRangeException ("Host Id missing");
            return this.DbSet
                            .Include(o=>o.Address)
                            .Where(o => o.HostId == hostId)
                            .Select(a => this.mapper.Map<T, SimsStakeholder>(a)).ToListAsync();
        }

        public async Task<SimsStakeholder> Add(int hostId, SimsStakeholder stakeholder)
        {
            if (hostId == 0) throw new ArgumentOutOfRangeException("Host Id missing.");

            //if (stakeholder.HostId == 0) throw new IncidentMissingException("Incident Id Missing");

            //var isClosed = await this.IsClosed(stakeholder.HostId);
            //if (isClosed) throw new IncidentClosedException("Incident is closed");
            if (stakeholder.Id > 0) throw new ArgumentException("Stakeholder already exists.");
            // Cannot add an FSA member with an address, this is an application error.
            //if (stakeholder.AddressId.HasValue && stakeholder.DiscriminatorId == (int)StakeholderTypes.FSA)
            //throw new SIMSException("FSA Stakeholder must not have an address");
            
            var toDb = mapper.Map<SimsStakeholder, T>(stakeholder);
            var dbItem = this.DbSet.Add(toDb);

            await ctx.SaveChangesAsync();
            return this.mapper.Map<T, SimsStakeholder>(dbItem.Entity);
        }

        public async Task Remove(int stakeholderId)
        {
            if (stakeholderId == 0) throw new ArgumentOutOfRangeException("stakeholderId mising");

            var dbItem = this.DbSet.SingleOrDefault(s => s.Id == stakeholderId);
            //            if (dbItem == null) throw new SIMSException("Stakeholder must exist.");

            //if (stakeholder.IncidentId == 0) throw new IncidentMissingException("Incident Id Missing");
            //var isClosed = (dbItem.Incident.IncidentStatusId == (int)IncidentStatusTypes.Closed);
            //if (isClosed) throw new IncidentClosedException("Incident is closed. cannot remove stakeholder");
            ctx.Remove(dbItem);
            await ctx.SaveChangesAsync();
        }

        public async Task<SimsStakeholder> Update(SimsStakeholder stakeholder)
        {
            if (stakeholder.Id == 0) throw new ArgumentOutOfRangeException ("stakeholder missing");

            //if (stakeholder.HostId == 0) throw new IncidentMissingException("Incident Id Missing");
            //var isClosed = await this.IsClosed(stakeholder.HostId);
            //if (isClosed) throw new IncidentClosedException("Incident is closed");
            //if (stakeholder.Id == 0) throw new SIMSException("Stakeholder must exist.");

            //if (stakeholder.AddressId.HasValue && stakeholder.DiscriminatorId == (int)StakeholderTypes.FSA)
            //    throw new SIMSException("FSA Stakeholder must not have an address");

            var dbItem = this.DbSet.Find(stakeholder.Id);
            //stakeholder.ToUpdateDb(dbItem);
            mapper.Map(stakeholder, dbItem);

            //var dbEnt = ctx.Stakeholders.Update(dbItem);
            await ctx.SaveChangesAsync();
            return mapper.Map<T, SimsStakeholder>(dbItem);
        }
    }
}
