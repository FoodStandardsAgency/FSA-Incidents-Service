using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using Sims.Application.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sims.Application.OnlineForm
{
    internal class OnlineNotes : ISIMSNotes
    {
        private ISimsDbHost dbHost;

        public OnlineNotes(ISimsDbHost dbHost)
        {
            this.dbHost = dbHost;
        }

        public Task<SimsNote> Add(int hostId, string note, SimsNoteTagTypes tags)
        {

            if (hostId == 0) throw new SimsItemMissing("No host id present.");
            return dbHost.OnlineForms.Notes.Add(hostId, note, (int) tags);
        }

        public Task<IEnumerable<SimsNote>> GetAll(int hostId)
        {
            if (hostId == 0) throw new SimsItemMissing("No host id present.");
            return dbHost.OnlineForms.Notes.GetAll(hostId);
        }

        public Task Update(int noteId, SimsNoteTagTypes tags)
        {
            return dbHost.OnlineForms.Notes.Update(noteId, (int)tags);
        }

    }
}
