using FSA.IncidentsManagement.Root.DTOS;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    public interface IDbSignalsRepository
    {
        Task<SimsSignal> Add(SimsSignal signal);
        Task AddBatch(IEnumerable<SimsSignal> signals);
        Task<SimsSignal> Get(int signalId);
        Task<SimsSignal> Update(SimsSignal signal);
        Task<bool> IsClosed(int signalId);
        Task<bool> Exists(int signalId);
    }
}