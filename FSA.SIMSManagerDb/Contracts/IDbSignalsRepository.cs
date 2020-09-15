using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Contracts
{ 
    public interface IDbSignalsRepository
    {
        Task<SimsSignal> Add(SimsSignal signal);
        Task AddBatch(IEnumerable<SimsSignal> signals);
        Task<SimsSignal> Get(int signalId);
        Task<SimsSignal> Update(SimsSignal signal);
        Task<bool> IsClosed(int signalId);
        Task<bool> Exists(int signalId);

        IDbNotesRepository Notes { get; }
        IDbLinkedRecordsRepository Links { get; }
        IDbProductRepository Products { get; }
        IDbAttachmentsRepository Attachments { get; }
        IDbStakeholdersRepository Stakeholders { get; }

        Task<IEnumerable<SignalDashboardItem>> DashboardLinks(int id);
        Task<IPaging<SignalDashboardItem>> DashboardSearch(string search = null, int pageSize = 500, int startPage = 1);
        Task UpdateLeadOfficer(IEnumerable<int> ids, string user);
        Task<SimsSignal> UpdateStatus(int signalId, int status);
        Task CloseNoIncident(SimsSignalCloseNoIncident closeDetails);
        Task CloseLinkIncident(int signalId, int incidentId);
        Task<int> CloseCreateIncident(string reason, int hostId);
    }
}