using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Contracts
{
    public interface IDbIncidentsRepository
    {
        Task<SIMSIncident> Add(SIMSIncident incident);
        Task Add(IEnumerable<SIMSIncident> incidents);
        Task UpdateLeadOfficer(IEnumerable<int> ids, string user);
        Task BulkClose(IEnumerable<int> incidentIds);
        Task<IEnumerable<IncidentDashboardItem>> DashboardLinks(int incidentId);
        Task<IPaging<IncidentDashboardItem>> DashboardSearch(string search = null, int PageSize = 500, int StartPage = 1);
        Task<bool> Exists(int incidentId);
        Task<SIMSIncident> Get(Guid guid);
        Task<SIMSIncident> Get(int Id);
        Task<IEnumerable<SIMSIncident>> GetAll();
        Task<SIMSIncidentDisplay> GetDisplayItem(int id);
        Task<bool> IsClosed(int incidentId);
        Task<SIMSIncident> Update(SIMSIncident incident);
        Task<SIMSIncident> UpdateClassification(int id, int ClassificationId);
        Task<SIMSIncident> UpdateStatus(int id, int statusId);

        IDbNotesRepository Notes { get; }
        IDbLinkedRecordsRepository Links { get; }
        IDbProductRepository Products { get; }
        IDbAttachmentsRepository Attachments { get; }
        IDbStakeholdersRepository Stakeholders { get; }

        Task UpdateSensitiveInfo(int incidentId, bool isSensitive);
        Task RemoveOutcome(int id);
    }
}