using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class SignalNotes : ISIMSNotes
    {
        private ISimsDbHost dbHost;

        public SignalNotes(ISimsDbHost dbHost)
        {
            this.dbHost = dbHost;
        }

        public Task<SimsNote> Add(int hostId, string note)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<SimsNote>> GetAll(int hostId)
        {
            throw new System.NotImplementedException();
        }
    }
}