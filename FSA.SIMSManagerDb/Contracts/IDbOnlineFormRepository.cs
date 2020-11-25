using FSA.IncidentsManagement.Root.DTOS;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Contracts
{
    public interface IDbOnlineFormRepository
    {
        Task<SimsOnlineForm> Add(SimsOnlineForm onlineForm);
        Task AddBatch(IEnumerable<SimsOnlineForm> onlineForm);
        Task<SimsOnlineForm> Get(int formId);
        Task<SimsOnlineForm> Update(SimsOnlineForm onlineForm);
        Task<bool> IsClosed(int onlineFormId);
        Task<bool> Exists(int onlineFormId);

        IDbProductRepository Products { get; }
        IDbNotesRepository Notes { get; }
        IDbStakeholdersRepository Stakeholders { get; }

        Task CloseCreateIncident(int onlineFormId, string reason);
        Task CloseNoIncident(int onlineFormId, string reason);
    }
}
