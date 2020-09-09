using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.SIMSManagerDb.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class SignalLinks : ISIMSLinks
    {
        private ISimsDbHost dbHost;

        public SignalLinks(ISimsDbHost dbHost)
        {
            this.dbHost = dbHost;
        }

        public Task<IEnumerable<SimsLinkedRecord>> Add(int from, IEnumerable<int> to, string reason)
        {
            return this.dbHost.Signals.Links.Add(from, to, reason);
        }

        public Task<SimsLinkedRecord> Remove(int from, int to)
        {
            return this.dbHost.Signals.Links.Remove(from, to);

        }
    }
}