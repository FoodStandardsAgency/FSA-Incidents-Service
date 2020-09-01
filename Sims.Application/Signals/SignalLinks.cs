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
            throw new System.NotImplementedException();
        }

        public Task<SimsLinkedRecord> Remove(int from, int to)
        {
            throw new System.NotImplementedException();
        }
    }
}