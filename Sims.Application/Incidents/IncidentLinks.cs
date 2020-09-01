using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.SIMSManagerDb.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class IncidentLinks : ISIMSLinks
    {
        private ISimsDbHost dbHost;

        public IncidentLinks(ISimsDbHost dbHost)
        {
            this.dbHost = dbHost;
        }

        public Task<IEnumerable<SimsLinkedRecord>> Add(int from, IEnumerable<int> to, string reason)
        {
            return dbHost.Incidents.Links.Add(from, to, reason);
        }

        public Task<SimsLinkedRecord> Remove(int from, int to)
        {
            return dbHost.Incidents.Links.Remove(from, to);
        }
    }
}