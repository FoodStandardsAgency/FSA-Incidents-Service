using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSSignals
    {
        Task<SimsSignal> Add(SimsSignal signal);
        Task<SimsSignal> Update(SimsSignal signal);
        Task<SimsSignal> Get(int signalId);

        Task<IPaging<SignalDashboardView>> DashboardSearch(string search = null, int pageSize = 500, int startPage = 1);
        Task<IEnumerable<SignalDashboardView>> DashboardLinks(int signalId);

        Task UpdateLeadOfficer(IEnumerable<int> id, string user);
        Task UpdateStatus(int signalId, string status);

        Task<int> PromoteToIncident(int signalId);

        ISIMSLinks Links { get; }
        ISIMSNotes Notes { get; }
        ISIMSProducts Products { get; }
        ISIMSAttachments Attachments { get; }
        ISIMSStakeholders Stakeholders { get; }
    }
}
