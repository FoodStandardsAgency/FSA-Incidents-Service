using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSSignals
    {
        Task<Signal> Add(Signal signal);
        Task<Signal> Update(Signal signal);
        Task<Signal> Get(int signalId);

        Task<IPaging<SignalDashboardView>> DashboardSearch(string search = null, int pageSize = 500, int startPage = 1);
        Task<IEnumerable<SignalDashboardView>> DashboardLinks(int signalId);

        Task UpdateLeadOfficer(IEnumerable<int> id, string user);
        Task UpdateStatus(int signalId, int status);

        Task<int> PromoteToIncident(int signalId);

        ISIMSLinks Links { get; }
        ISIMSNotes Notes { get; }
        ISIMSProducts Products { get; }
        ISIMSAttachments Attachments { get; }
        ISIMSStakeholders Stakeholders { get; }
    }
}
