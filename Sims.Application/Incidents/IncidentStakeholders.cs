using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.SIMSManagerDb.Contracts;
using Sims.Application.Exceptions;
using Sims.Application.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class IncidentStakeholders : ISIMSStakeholders
    {
        private ISimsDbHost dbHost;

        public IncidentStakeholders(ISimsDbHost dbHost)
        {
            this.dbHost = dbHost;
        }

        public Task<SimsStakeholder> Add(int hostId, SimsStakeholder stakeHolder)
        {
            if (stakeHolder.DiscriminatorId == (int)SimsStakeholderAddressTypes.FSA && stakeHolder.AddressId > 0)
                throw new SIMSException("FSA Member cannot have an address assigned");
            if (stakeHolder.AddressId == 0) stakeHolder.AddressId = null;
            return dbHost.Incidents.Stakeholders.Add(hostId, stakeHolder);
        }

        public async Task<IEnumerable<SimsStakeholder>> GetAll(int signalId)
        {
            if (signalId == 0) throw new SimsItemMissing("Stakeholder id missing");
            return await dbHost.Incidents.Stakeholders.GetAll(signalId);
        }

        public Task Remove(int stakeholderId)
        {
            if (stakeholderId == 0) throw new SimsItemMissing("Stakeholder id missing");

            return this.dbHost.Incidents.Stakeholders.Remove(stakeholderId);
        }

        public async Task<SimsStakeholder> Update(SimsStakeholder stakeHolder)
        {
            if (stakeHolder.AddressId == 0) stakeHolder.AddressId = null;
            if (stakeHolder.DiscriminatorId == (int)SimsStakeholderAddressTypes.FSA && stakeHolder.AddressId > 0)
                throw new SIMSException("FSA Member cannot have an address assigned");
            if (stakeHolder.Id == 0) throw new SimsItemMissing("Stakeholder id missing");
            if (stakeHolder.HostId == 0) throw new SimsIncidentMissingException("Signal id missing");
            return await this.dbHost.Incidents.Stakeholders.Update(stakeHolder);
        }
    }
}