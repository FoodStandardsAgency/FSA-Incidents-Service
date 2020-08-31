using FSA.IncidentsManagement.Root.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSNotes
    {
        Task<SimsNote> AddNote(int hostId, string note);
        /// <summary>
        /// All notes for an incident/Signal
        /// </summary>
        /// <param name="incidentId"></param>
        /// <returns></returns>
        Task<IEnumerable<SimsNote>> GetNotes(int hostId);
    }
}
