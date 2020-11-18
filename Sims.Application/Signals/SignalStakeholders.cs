using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using Sims.Application.Exceptions;
using Sims.Application.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class SignalStakeholders : ISIMSStakeholders
    {
        private ISimsDbHost dbHost;

        public SignalStakeholders(ISimsDbHost dbHost)
        {
            this.dbHost = dbHost;
        }

        public async Task<SimsStakeholder> Add(int hostId, SimsStakeholder SimsStakeholder)
        {
            if (await dbHost.Signals.IsClosed(hostId)) throw new SimsSignalClosedException("Signal closed.");
            if (SimsStakeholder.DiscriminatorId == (int)SimsStakeholderAddressTypes.FSA && SimsStakeholder.AddressId > 0)
                throw new SIMSException("FSA Member cannot have an address assigned");
            if (SimsStakeholder.AddressId == 0) SimsStakeholder.AddressId = null;
            return await this.dbHost.Signals.Stakeholders.Add(hostId, SimsStakeholder);
        }

        public async Task<IEnumerable<SimsStakeholder>> GetAll(int signalId)
        {
            if (signalId == 0) throw new SimsItemMissing("signal id missing");
            return await this.dbHost.Signals.Stakeholders.GetAll(signalId);
        }

        public Task Remove(int stakeholderId)
        {
            if (stakeholderId == 0) throw new SimsItemMissing("Stakeholder id missing");
            return this.dbHost.Signals.Stakeholders.Remove(stakeholderId);
        }

        public async Task<SimsStakeholder> Update(SimsStakeholder stakeHolder)
        {
            if (stakeHolder.AddressId == 0) stakeHolder.AddressId = null;
            if (stakeHolder.HostId == 0) throw new SimsSignalMissingException("Signal id missing");
            if (await dbHost.Signals.IsClosed(stakeHolder.HostId)) throw new SimsSignalClosedException("Signal closed.");
            if (stakeHolder.Id == 0) throw new SimsItemMissing("Stakeholder id missing");
            return await this.dbHost.Signals.Stakeholders.Update(stakeHolder);
        }
    }
}