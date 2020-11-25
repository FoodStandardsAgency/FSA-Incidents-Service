using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSOnlineForms
    {
        Task<SimsOnlineForm> Add(SimsOnlineForm onelineForm);
        Task<SimsOnlineForm> Update(SimsOnlineForm onelineForm);
        Task<SimsOnlineForm> Get(int onelineFormId);
        Task CloseNoIncident(int onlineFormId, string reason);
        Task CloseCreateIncident(int onlineFormId, string reason);
        Task<IPaging<SimsOnlineFormDashboardItem>> DashboardSearch(string search = null, int pageSize = 500, int startPage = 1);
        Task<IEnumerable<SimsOnlineFormDashboardItem>> DashboardLinks(int onelineFormId);

        ISIMSNotes Notes { get; }
        ISIMSProducts Products { get; }
        ISIMSStakeholders Stakeholders { get; }

    }
}
