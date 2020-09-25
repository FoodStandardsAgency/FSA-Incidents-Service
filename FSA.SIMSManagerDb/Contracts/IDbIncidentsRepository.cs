using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Contracts
{
    public interface IDbIncidentsRepository
    {
        Task<BaseIncident> Add(BaseIncident incident);
        Task Add(IEnumerable<BaseIncident> incidents);
        Task UpdateLeadOfficer(IEnumerable<int> ids, string user);
        Task BulkClose(IEnumerable<int> incidentIds);
        Task<IEnumerable<IncidentDashboardItem>> DashboardLinks(int incidentId);
        Task<IPaging<IncidentDashboardItem>> DashboardSearch(string search = null, int PageSize = 500, int StartPage = 1);
        Task<bool> Exists(int incidentId);
        Task<BaseIncident> Get(Guid guid);
        Task<BaseIncident> Get(int Id);
        Task<IEnumerable<BaseIncident>> GetAll();
        Task<IncidentsDisplayModel> GetDisplayItem(int id);
        Task<bool> IsClosed(int incidentId);
        Task<BaseIncident> Update(BaseIncident incident);
        Task<BaseIncident> UpdateClassification(int id, int ClassificationId);
        Task<BaseIncident> UpdateStatus(int id, int statusId);

        IDbNotesRepository Notes { get; }
        IDbLinkedRecordsRepository Links { get; }
        IDbProductRepository Products { get; }
        IDbAttachmentsRepository Attachments { get; }
        IDbStakeholdersRepository Stakeholders { get; }
    }
}