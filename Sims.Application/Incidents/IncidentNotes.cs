using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using Sims.Application.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class IncidentNotes : ISIMSNotes
    {
        private ISimsDbHost dbHost;

        public IncidentNotes(ISimsDbHost dbHost)
        {
            this.dbHost = dbHost;
        }

        public Task<SimsNote> Add(int incidentId, string note, SimsNoteTagTypes tags)
        {
            if (incidentId == 0) throw new SimsItemMissing("No host id present.");
            return dbHost.Incidents.Notes.Add(incidentId, note, (int)tags);
        }

        public Task<IEnumerable<SimsNote>> GetAll(int incidentId)
        {
            if (incidentId == 0) throw new SimsItemMissing("No host id present.");
            return dbHost.Incidents.Notes.GetAll(incidentId);

        }


        public Task Update(int noteId, SimsNoteTagTypes tags)
        {
            return dbHost.Incidents.Notes.Update(noteId, (int)tags);
        }
    }
}