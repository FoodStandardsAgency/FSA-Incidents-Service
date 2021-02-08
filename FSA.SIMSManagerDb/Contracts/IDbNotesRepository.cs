using FSA.IncidentsManagement.Root.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Contracts
{
    public interface IDbNotesRepository
    {
        Task<SimsNote> Add(int hostId, string note, int tags);
        Task<IEnumerable<SimsNote>> GetAll(int hostId);
        Task BulkAdd(int commonId, IEnumerable<(string text, int tags)> notes);
        Task<SimsNote> Update(int noteId, int tags);
    }
}