using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSNotes
    {
        Task<SimsNote> Add(int hostId, string note, SimsNoteTagTypes tags);
        /// <summary>
        /// All notes for an incident/Signal
        /// </summary>
        /// <param name="incidentId"></param>
        /// <returns></returns>
        Task<IEnumerable<SimsNote>> GetAll(int hostId);
        Task Update(int noteId, SimsNoteTagTypes tags);
    }
}
