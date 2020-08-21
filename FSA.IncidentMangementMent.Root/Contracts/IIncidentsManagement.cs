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

        Task AssignLeadOfficer(IEnumerable<int> id, string user);
        
        Task AddLinks(int from, IEnumerable<int> to, string reason);
        Task RemoveLink(int fromIncidentId, int toIncidentId);
        
        Task<IncidentNote> AddNote(int incidentId, string note);
        Task<IEnumerable<IncidentNote>>GetNotes(int incidentId);

        Task<IPaging<IncidentDashboardView>> DashboardSearch(string search = null, int pageSize = 500, int startPage = 1);
        Task<IEnumerable<IncidentDashboardView>> DashboardIncidentLinks(int incidentId);

        Task<IEnumerable<Stakeholder>> GetStakeholders(int incidentId);
        Task<Stakeholder> AddStakeholder(Stakeholder stakeholder);
        Task RemoveStakeholder(int stakeholderId);
        Task<Stakeholder> UpdateStakeholder(Stakeholder stakeholder);

        Task BulkClose(IEnumerable<int> incidentIds);

        Task UpdateAttachmentTags(int id, string docUrl, DocumentTagTypes tags);

        Task<bool> IsClosed(int incidentId);
        /// <summary>
        /// Has the incident been created already.
        /// </summary>
        /// <param name="incidentId"></param>
        /// <returns></returns>
        Task<bool> Exists(int incidentId);

        Task<IEnumerable<(string fileUrl, DocumentTagTypes tags)>> GetAttachmentTags(int incidentId);
    }
}
