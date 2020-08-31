using FSA.IncidentsManagement.Root.DTOS;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Contracts
{
    public interface IDbLinkedRecordsRepository
    {
        Task<IEnumerable<SimsLinkedRecord>> Add(int from, IEnumerable<int> tos, string reason);
        Task<SimsLinkedRecord> Remove(int from, int to);
    }
}