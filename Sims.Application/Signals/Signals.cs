using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using FSA.SIMSManagerDb.Contracts;
using Sims.Application.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sims.Application
{
    class Signals : ISIMSSignals
    {
        private readonly ISimsDbHost dbHost;
        private readonly ISIMSAttachmentHost attachments;

        internal Signals(ISimsDbHost dbHost, ISIMSAttachmentHost attachments)
        {
            this.dbHost = dbHost;
            this.attachments = attachments;
        }

        public ISIMSLinks Links => new SignalLinks(dbHost);

        public ISIMSNotes Notes => new SignalNotes(dbHost);

        public ISIMSProducts Products => new SignalProducts(dbHost);

        public ISIMSAttachments Attachments => new SignalAttachments(dbHost, attachments.Signals);

        public ISIMSStakeholders Stakeholders => new SignalStakeholders(dbHost);

        public Task<SimsSignal> Add(SimsSignal signal)
        {
            if (signal.Id !=0) throw new SimsItemExists("Signal already exists!");
            return dbHost.Signals.Add(signal);
        }

        public async Task<IEnumerable<SignalDashboardItem>> DashboardLinks(int signalId)
        {
            return await dbHost.Signals.DashboardLinks(signalId);

        }

        public Task<IPaging<SignalDashboardItem>> DashboardSearch(string search = null, int pageSize = 500, int startPage = 1)
        {
            return dbHost.Signals.DashboardSearch(search, pageSize, startPage);

        }

        public Task<SimsSignal> Get(int signalId)
        {

            if (signalId == 0) throw new SIMSException("Unknown signal Id.");
            return dbHost.Signals.Get(signalId);
        }

        public Task<int> PromoteToIncident(int signalId)
        {
            throw new System.NotImplementedException();
        }

        public Task<SimsSignal> Update(SimsSignal signal)
        {
            return dbHost.Signals.Update(signal);
        }

        public Task UpdateLeadOfficer(IEnumerable<int> ids, string user)
        {
            return dbHost.Signals.UpdateLeadOfficer(ids, user);
        }

        public Task UpdateStatus(int signalId, string status)
        {
            return dbHost.Signals.UpdateStatus(signalId, status);
        }
    }

}
