using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Contracts
{
    public interface IIncidentsManagement
    {
        Task<BaseIncident> Get(int Id);
        Task<BaseIncident> Get(Guid guid);
        Task<IEnumerable<BaseIncident>> GetAll();

        Task<IncidentsDisplayModel> GetDisplayItem(int id);

        Task<BaseIncident> UpdateStatus(int Id, int statusId);

        Task AssignLeadOfficer(IEnumerable<int> id, string user);

        Task<BaseIncident> UpdateClassification(int id, int ClassificationId);

        Task AddLink(int from, IEnumerable<int> to, string reason);

        Task<IncidentNote> AddNote(int incidentId, string note);

        Task<IEnumerable<IncidentNote>>GetNotes(int incidentId);

        Task<IPaging<IncidentDashboardView>> DashboardSearch(string search = null, int pageSize = 500, int startPage = 1);

        Task<BaseIncident> Add(BaseIncident incident);

        Task<BaseIncident> Update(BaseIncident incident);
        Task<IEnumerable<IncidentDashboardView>> DashboardIncidentLinks(int incidentId);
        Task BulkClose(IEnumerable<int> incidentIds);
    }
}
