using FSA.IncidentsManagement.Root;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using FSA.SIMSManagerDb.Contracts;
using Sims.Application.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class Signals : ISIMSSignals
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

        public async Task<SimsSignal> Update(SimsSignal signal)
        {
            if (await dbHost.Signals.IsClosed(signal.CommonId))
                throw new SimsSignalClosedException("Signal closed");
            return await dbHost.Signals.Update(signal);
        }

        public Task UpdateLeadOfficer(IEnumerable<int> ids, string user)
        {
            return dbHost.Signals.UpdateLeadOfficer(ids, user);
        }

        public async Task UpdateStatus(int signalId, int status)
        {
            if (await dbHost.Signals.IsClosed(signalId))
                throw new SimsSignalClosedException("Signal closed");
            if (status == 0)
                throw new SimsItemMissing("Invalid status id");

            await dbHost.Signals.UpdateStatus(signalId, status);
        }

        public Task CloseLinkIncident(SimsSignalCloseLinkIncident close)
        {
            if (close.SignalId == 0) throw new SimsSignalMissingException("Signal id missing");
            if (close.IncidentId == 0) throw new SimsSignalMissingException("Incident id missing");
            if (string.IsNullOrEmpty(close.ReasonNote)) throw new SimsSignalMissingException("Incident id missing");
            return dbHost.Signals.CloseLinkIncident(close.ReasonNote, close.SignalId, close.IncidentId);
        }

        public async Task<int> CloseCreateIncident(SimsSignalCloseCreateIncident close)
        {
            if (await dbHost.Signals.IsClosed(close.SignalId))
                throw new SimsSignalClosedException("Signal closed");
            var incidentId = await dbHost.Signals.CloseCreateIncident(close.ReasonNote, close.SignalId);
            if (incidentId != -1)
            {
                // var signInfo = await this.attachments.Incidents.EnsureLibrary(GeneralExtensions.GenerateSignalsId(close.SignalId));
                // Once an incident is created, then we can migrate all the documents.
                // Createing library just breaks down the task
                // Then we need to migrate any tags that have been applied.
                var libInfo = await this.attachments.Incidents.EnsureLibrary(GeneralExtensions.GenerateIncidentId(incidentId));
                var currentDocInfo = (await dbHost.Signals.Attachments.Get(close.SignalId)).ToHashSet();
                var allFileUrls = await this.attachments.Signals.MigrateToLibrary(GeneralExtensions.GenerateIncidentId(incidentId), GeneralExtensions.GenerateSignalsId(close.SignalId));

                var mergedTags = allFileUrls
                                .ToDictionary(a => a.IncidentUrl, b => currentDocInfo.First(f => f.FileName == b.FileName).Tags);

                await this.dbHost.Incidents.Attachments.BulkAdd(incidentId, mergedTags);

                return incidentId;
            }
            else
            {
                throw new SIMSException("Signal already closed.");
            }
        }

        public Task CloseNoIncident(SimsSignalCloseNoIncident close)
        {
            if (close.ReasonId == 0 && close.TeamIds.Length == 0) throw new SIMSException("Reason/Team is invalid");

            if (close.SignalId == 0) throw new SimsSignalMissingException("Signal id missing");
            if (close.StatusCloseId == (int)SimsSignalStatusTypes.Closed_No_Incident
            || close.StatusCloseId == (int)SimsSignalStatusTypes.Closed_Referrel_Offline)
                return dbHost.Signals.CloseNoIncident(close);
            else
                throw new SimsItemMissing("Incorrect close message");
        }

        public async Task<IEnumerable<SimsLinkedCase>> GetLinkedIncidents(int id)
        {
            if (id == 0) throw new SimsIncidentMissingException();

            var items = await this.dbHost.Signals.Links.GetRelatedCases(id);
            return items.Select(a => new SimsLinkedCase
            {
                CommonId = a,
                Id = GeneralExtensions.GenerateIncidentId(a)
            }).ToList();
        }

        public Task UpdateSensitiveInfoStatus(int signalId, bool isSensitive)=> this.dbHost.Signals.UpdateSensitiveInfo(signalId, isSensitive);
    }

}
