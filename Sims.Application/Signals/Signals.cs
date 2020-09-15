using FSA.IncidentsManagement.Root;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using FSA.SIMSManagerDb.Contracts;
using Sims.Application.Exceptions;
using System;
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
            if (signal.CommonId != 0) throw new SimsItemExists("Signal already exists!");
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

        public Task<SimsSignal> Update(SimsSignal signal)
        {
            try
            {
                return dbHost.Signals.Update(signal);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw new SIMSException(ex.Message);
            }
        }

        public Task UpdateLeadOfficer(IEnumerable<int> ids, string user)
        {
            return dbHost.Signals.UpdateLeadOfficer(ids, user);
        }

        public Task UpdateStatus(int signalId, int status)
        {
            return dbHost.Signals.UpdateStatus(signalId, status);
        }

        public Task CloseLinkIncident(SimsSignalCloseLinkIncident close)
        {
            return dbHost.Signals.CloseLinkIncident(close.SignalId, close.IncidentId);
        }

        public async Task<int> CloseCreateIncident(SimsSignalCloseCreateIncident close)
        {
            var incidentId = await dbHost.Signals.CloseCreateIncident(close.ReasonNote, close.SignalId);
            if (incidentId != -1)
            {
                // fetch all the signal documents info
                //var allDocs = await this.attachments.Signals.FetchAllAttchmentsLinks(GeneralExtensions.GenerateIncidentId(close.SignalId));
                var libInfo = await this.attachments.Incidents.EnsureLibrary(GeneralExtensions.GenerateIncidentId(incidentId));
                await this.attachments.Incidents.MigrateToIncident(incidentId, close.SignalId);
                return incidentId;
            }
            else
            {
                throw new SIMSException("Signal already closed.");
            }
        }

        public Task CloseNoIncident(SimsSignalCloseNoIncident close)
        {
            return dbHost.Signals.CloseNoIncident(close);
        }
    }

}
