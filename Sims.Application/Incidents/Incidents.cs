using FSA.IncidentsManagement.Root;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using FSA.SIMSManagerDb.Contracts;
using Sims.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sims.Application
{
    public class Incidents : ISIMSIncidents
    {
        private readonly ISimsDbHost dbHost;
        private readonly ISIMSAttachmentHost attachments;

        internal Incidents(ISimsDbHost dbHost, ISIMSAttachmentHost attachments)
        {
            this.dbHost = dbHost;
            this.attachments = attachments;
        }

        public ISIMSLinks Links => new IncidentLinks(dbHost);

        public ISIMSNotes Notes => new IncidentNotes(dbHost);

        public ISIMSProducts Products => new IncidentProducts(dbHost);

        public ISIMSAttachments Attachments => new IncidentAttachments(dbHost, attachments.Incidents);

        public ISIMSStakeholders Stakeholders => new IncidentStakeholders(dbHost);

        public Task<BaseIncident> Add(BaseIncident incident)
        {
            if (incident.CommonId != 0) throw new SimsIncidentExistsException("This incident has already been added.");

            // IF we have an officer, and status is not open...
            if (!String.IsNullOrEmpty(incident.LeadOfficer) && incident.StatusId != (int)SimsIncidentStatusTypes.Open)
                incident = incident.WithStatus((int)SimsIncidentStatusTypes.Open);
            // if we don't have an officer status must be unsassigned
            if (String.IsNullOrEmpty(incident.LeadOfficer))
                incident = incident.WithStatus((int)SimsIncidentStatusTypes.Unassigned);
            return dbHost.Incidents.Add(incident);
        }

        public Task BulkClose(IEnumerable<int> incidentIds) => dbHost.Incidents.BulkClose(incidentIds);

        public Task<IEnumerable<IncidentDashboardItem>> DashboardLinks(int incidentId) => dbHost.Incidents.DashboardLinks(incidentId);

        public Task<IPaging<IncidentDashboardItem>> DashboardSearch(string search = null, int pageSize = 500, int startPage = 1) => dbHost.Incidents.DashboardSearch(search, pageSize, startPage);

        public Task<bool> Exists(int incidentId)
        {
            if (incidentId == 0) return Task.Run(() => false);
            return dbHost.Incidents.Exists(incidentId);
        }

        public Task<BaseIncident> Get(int Id) => dbHost.Incidents.Get(Id);

        public Task<BaseIncident> Get(Guid guid)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Literally *ALL* incidents
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<BaseIncident>> GetAll() => dbHost.Incidents.GetAll();

        /// <summary>
        /// Stuffed version of the viewmodel with all lookups accountered for
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<IncidentsDisplayModel> GetDisplayItem(int id) => dbHost.Incidents.GetDisplayItem(id);

        public async Task<IEnumerable<SimsLinkedCase>> GetLinkedSignals(int id)
        {
            if (id == 0) throw new SimsIncidentMissingException();

            var items = await this.dbHost.Incidents.Links.GetRelatedCases(id);
            return items.Select(a => new SimsLinkedCase
            {
                CommonId = a,
                Id = GeneralExtensions.GenerateSignalsId(a)
            }).ToList();

        }

        public Task<bool> IsClosed(int incidentId)
        {
            if (incidentId == 0) return Task.Run(() => true);
            return dbHost.Incidents.IsClosed(incidentId);
        }

        public Task RemoveIncidentOutcome(int id)
        {
            // This is really deleting a note from the incident notes table, that has a single tag of IncidentOutcomes
            return dbHost.Incidents.RemoveOutcome(id);
        }

        public async Task<BaseIncident> Update(BaseIncident incident)
        {
            try
            {
                if (incident.CommonId == 0) throw new SimsItemMissing("Incident Id missing");
                return await dbHost.Incidents.Update(incident.SignalStatusId==0 ? incident.WithSignalStatusId(null): incident);
            }
            catch (NullReferenceException)
            {
                throw new SimsIncidentMissingException("Incident missing");
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new SimsIncidentClosedException("Cannot update closed incident");
            }
        }


        public async Task<BaseIncident> UpdateClassification(int id, int ClassificationId)
        {

            try
            {
                if (id == 0) throw new SimsIncidentMissingException("Incident not found");
                return await dbHost.Incidents.UpdateClassification(id, ClassificationId);
            }
            catch (NullReferenceException)
            {
                throw new SimsIncidentMissingException("Incident missing");
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new SimsIncidentClosedException("Cannot update closed incident");
            }
        }

        /// <summary>
        /// testing of closed/open done inside the method
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public Task UpdateLeadOfficer(IEnumerable<int> ids, string user) => dbHost.Incidents.UpdateLeadOfficer(ids, user);

        public Task UpdateSensitiveInfoStatus(int incidentId, bool isSensitive)=> this.dbHost.Incidents.UpdateSensitiveInfo(incidentId, isSensitive);

        public Task<BaseIncident> UpdateStatus(int id, int statusId) => dbHost.Incidents.UpdateStatus(id, statusId);
    }
}
