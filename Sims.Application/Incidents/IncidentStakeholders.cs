using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
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

        public Task<Stakeholder> Add(int hostId, Stakeholder stakeholder)
        {
            throw new System.NotImplementedException();
        }

        public Task<Stakeholder> GetAll(int hostId, int Stakeholder)
        {
            throw new System.NotImplementedException();
        }

        public Task<Stakeholder> Remove(Stakeholder stakeholder)
        {
            throw new System.NotImplementedException();
        }

        public Task<Stakeholder> Update(Stakeholder stakeholder)
        {
            throw new System.NotImplementedException();
        }
    }
}