using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Shared;
using FSA.SIMSManagerDb.Contracts;
using Microsoft.Extensions.Logging;
using Sims.Application.Exceptions;
using Sims.Application.OnlineForm;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class OnlineForms : ISIMSOnlineForms
    {
        private ISimsDbHost dbHost;
        private readonly OnlineFormImporter formImporter;
        private readonly ILogger<OnlineForms> logger;

        public OnlineForms(ISimsDbHost simsDbHost, OnlineFormImporter formImporter, ILogger<OnlineForms> logger)
        {
            this.dbHost = simsDbHost;
            this.formImporter = formImporter;
            this.logger = logger;
        }

        public ISIMSNotes Notes => new OnlineFormNotes(dbHost);

        public ISIMSProducts Products => new OnlineFormProducts(dbHost);

        public ISIMSStakeholders Stakeholders => new OnlineFormStakeholders(dbHost);

        public async Task<SimsOnlineForm> Add(SimsOnlineForm onlineForm)
        {
            if (onlineForm.CommonId != 0) throw new SimsItemExists("Online form exists");
            return await dbHost.OnlineForms.Add(onlineForm);
        }

        public async Task<int> CloseCreateIncident(int onlineFormId, string reason)
        {
            if (await dbHost.OnlineForms.IsClosed(onlineFormId) == true)
                throw new SimsOnlineFormClosedException("Form is closed");
            return await dbHost.OnlineForms.CloseCreateIncident(onlineFormId, reason);
        }

        public async Task CloseNoIncident(int onlineFormId, string reason)
        {
            if (await dbHost.OnlineForms.IsClosed(onlineFormId) == true)
                throw new SimsOnlineFormClosedException("Form is closed");
            await dbHost.OnlineForms.CloseNoIncident(onlineFormId, reason);
        }


        public Task<IPaging<SimsOnlineFormDashboardItem>> DashboardSearch(string search = null, int pageSize = 500, int startPage = 1)
        {
            return dbHost.OnlineForms.DashboardSearch(search, pageSize, startPage);
        }

        public async Task<SimsOnlineForm> Get(int onlineFormId)
        {
            if (onlineFormId == 0) throw new SimsItemMissing("Incorrect Id");
            return await dbHost.OnlineForms.Get(onlineFormId);
        }

        public async Task ImportNewForm(JsonDocument formDocument)
        {
            // Check the reference number 1. Exists, and has not already been added.
            var refNo = formDocument.RootElement
                            .GetProperty("Incidents")
                                .GetProperty("IncidentTitle").GetRawText();

            if (!await dbHost.OnlineForms.ReferenceNoExists(refNo))
            {
                logger.LogWarning($"{refNo} creating newForm");
                
                await this.formImporter.Process(formDocument);
            }
            else
            {
                logger.LogWarning($"{refNo} already exists");
                throw new SimsOnlineFormAlreadyImportedException($"{refNo} : Already exists");
            }
        }

        public async Task<SimsOnlineForm> Update(SimsOnlineForm onlineForm)
        {
            if (await dbHost.OnlineForms.IsClosed(onlineForm.CommonId) == true)
                throw new SimsOnlineFormClosedException("Form is closed");
            return await dbHost.OnlineForms.Update(onlineForm);
        }
    }
}
