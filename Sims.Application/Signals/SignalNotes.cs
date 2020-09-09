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
            return dbHost.Signals.Notes.Add(hostId, note);
        }

        public Task<IEnumerable<SimsNote>> GetAll(int hostId)
        {
            return dbHost.Signals.Notes.GetAll(hostId);
        }
    }
}