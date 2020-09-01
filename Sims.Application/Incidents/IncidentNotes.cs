using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
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

        public Task<SimsNote> Add(int incidentId, string note)
        {
            return dbHost.Incidents.Notes.Add(incidentId, note);
        }

        public Task<IEnumerable<SimsNote>> GetAll(int incidentId)
        {
            return dbHost.Incidents.Notes.GetAll(incidentId);

        }
    }
}