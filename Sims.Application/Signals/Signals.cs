using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using FSA.SIMSManagerDb.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sims.Application
{
    class Signals : ISIMSSignals
    {
        private readonly ISimsDbHost dbHost;

        internal Signals(ISimsDbHost dbHost)
        {
            this.dbHost = dbHost;
        }

        public ISIMSLinks Links => new SignalLinks(dbHost);

        public ISIMSNotes Notes => new SignalNotes(dbHost);

        public ISIMSProducts Products => new SignalProducts(dbHost);

        public ISIMSAttachments Attachments => new SignalAttachments(dbHost);

        public ISIMSStakeholders Stakeholders => new SignalStakeholders(dbHost);

        public Task<Signal> Add(Signal signal)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<SignalDashboardView>> DashboardLinks(int signalId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IPaging<SignalDashboardView>> DashboardSearch(string search = null, int pageSize = 500, int startPage = 1)
        {
            throw new System.NotImplementedException();
        }

        public Task<Signal> Get(int signalId)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> PromoteToIncident(int signalId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Signal> Update(Signal signal)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateLeadOfficer(IEnumerable<int> id, string user)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateStatus(int signalId, int status)
        {
            throw new System.NotImplementedException();
        }
    }

}
