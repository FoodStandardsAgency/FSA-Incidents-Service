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
        Task<SIMSIncident> Get(int Id);

        [Obsolete]
        Task<SIMSIncident> Get(Guid guid);

        Task<IEnumerable<SIMSIncident>> GetAll();
        Task<SIMSIncident> Add(SIMSIncident incident);
        Task<SIMSIncident> Update(SIMSIncident incident);

        /// <summary>
        /// Display model used on the item screen
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<SIMSIncidentDisplay> GetDisplayItem(int id);

        Task<SIMSIncident> UpdateStatus(int Id, int statusId);
        Task<SIMSIncident> UpdateClassification(int id, int ClassificationId);
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
        Task UpdateSensitiveInfoStatus(int hostId, bool isSensitive);
        Task RemoveIncidentOutcome(int id);
    }

}
