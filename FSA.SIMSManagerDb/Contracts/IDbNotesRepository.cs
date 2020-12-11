using FSA.IncidentsManagement.Root.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Contracts
{
    public interface IDbNotesRepository
    {
        Task<SimsNote> Add(int hostId, string note);
        Task<IEnumerable<SimsNote>> GetAll(int hostId);
        Task BulkAdd(int commonId, IEnumerable<string> contactNotes);
    }
}