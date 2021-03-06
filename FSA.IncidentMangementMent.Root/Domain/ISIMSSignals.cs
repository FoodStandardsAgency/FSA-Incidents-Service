﻿using FSA.IncidentsManagement.Root.DTOS;
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

        Task<IPaging<SignalDashboardItem>> DashboardSearch(string search = null, int pageSize = 500, int startPage = 1);
        Task<IEnumerable<SignalDashboardItem>> DashboardLinks(int signalId);

        Task UpdateLeadOfficer(IEnumerable<int> ids, string user);
        Task UpdatePriorityStatus(IEnumerable<int> ids, string priority);
        Task UpdateStatus(int signalId, int status);

        
        Task CloseNoIncident(SimsSignalCloseNoIncident closeIncident);
        Task<int> CloseCreateIncident(SimsCloseCreateIncident createIncident);
        Task CloseLinkIncident(SimsSignalCloseLinkIncident closeLink);

        ISIMSLinks Links { get; }
        ISIMSNotes Notes { get; }
        ISIMSProducts Products { get; }
        ISIMSAttachments Attachments { get; }
        ISIMSStakeholders Stakeholders { get; }

        Task<IEnumerable<SimsLinkedCase>> GetLinkedIncidents(int id);
        Task UpdateSensitiveInfoStatus(int hostId, bool isSensitive);
    }
}
