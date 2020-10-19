using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSIncidents
    {
        Task<BaseIncident> Get(int Id);

        [Obsolete]
        Task<BaseIncident> Get(Guid guid);
        Task<IEnumerable<BaseIncident>> GetAll();
        Task<BaseIncident> Add(BaseIncident incident);
        Task<BaseIncident> Update(BaseIncident incident);

        /// <summary>
        /// Display model used on the item screen
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IncidentsDisplayModel> GetDisplayItem(int id);

        Task<BaseIncident> UpdateStatus(int Id, int statusId);
        Task<BaseIncident> UpdateClassification(int id, int ClassificationId);
        Task UpdateLeadOfficer(IEnumerable<int> id, string user);

        Task<IPaging<IncidentDashboardItem>> DashboardSearch(string search = null, int pageSize = 500, int startPage = 1);
        Task<IEnumerable<IncidentDashboardItem>> DashboardLinks(int incidentId);
        Task BulkClose(IEnumerable<int> incidentIds);

        /// <summary>
        /// Is the incident closed.
        /// throws if the incident does not exist.
        /// </summary>
        /// <param name="incidentId"></param>
        /// <returns></returns>
        Task<bool> IsClosed(int incidentId);
        /// <summary>
        /// Has the incident been created already.
        /// </summary>
        /// <param name="incidentId"></param>
        /// <returns></returns>
        Task<bool> Exists(int incidentId);

        ISIMSLinks Links { get; }
        ISIMSNotes Notes { get; }
        ISIMSProducts Products { get; }
        ISIMSAttachments Attachments { get; }
        ISIMSStakeholders Stakeholders { get; }

        Task<IEnumerable<SimsLinkedCase>> GetLinkedSignals(int id);
    }

}
