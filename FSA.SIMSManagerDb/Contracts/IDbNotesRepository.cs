using FSA.IncidentsManagement.Root.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Contracts
{
    public interface IDbNotesRepository
    {
        Task<SimsNote> AddNote(int hostId, string note);
        Task<IEnumerable<SimsNote>> GetNotes(int hostId);
    }
}