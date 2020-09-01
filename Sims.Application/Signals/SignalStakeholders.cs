using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using Sims.Application.Exceptions;
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

        public Task<SimsStakeholder> Add(int hostId, SimsStakeholder SimsStakeholder)
        {
            return this.dbHost.Signals.Stakeholders.Add(hostId, SimsStakeholder);

        }

        public async Task<IEnumerable<SimsStakeholder>> GetAll(int incidentId)
        {
            if (incidentId == 0) throw new SimsItemMissing("incident id missing");
            return await this.dbHost.Signals.Stakeholders.GetAll(incidentId);
        }

        public Task Remove(int stakeholderId)
        {
            if (stakeholderId == 0) throw new SimsItemMissing("Stakeholder id missing");
            return this.dbHost.Signals.Stakeholders.Remove(stakeholderId);
        }

        public async Task<SimsStakeholder> Update(SimsStakeholder SimsStakeholder)
        {
            if (SimsStakeholder.Id == 0) throw new SimsItemMissing("Stakeholder id missing");
            if (SimsStakeholder.HostId == 0) throw new SimsSignalMissingException("Signal id missing");
            return await this.dbHost.Signals.Stakeholders.Update(SimsStakeholder);
        }
    }
}