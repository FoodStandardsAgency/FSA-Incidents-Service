using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Shared;
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

        Task CloseNoIncident(int onlineFormId, string reason);
        Task<IPaging<SimsOnlineFormDashboardItem>> DashboardSearch(string search = null, int pageSize = 500, int startPage = 1);
        Task<int> CloseCreateIncident(int onlineFormId, string reason);
    }
}
