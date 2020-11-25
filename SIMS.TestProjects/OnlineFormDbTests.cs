using AutoMapper;
using AutoMapper.Configuration;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.SIMSManagerDb.MapperProfile;
using FSA.SIMSManagerDb.Repositories;
using Microsoft.Graph;
using SIMS.TestProjects.Setup;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace SIMS.Database
{
    public class OnlineFormDbTests
    {
        private IMapper mapper;
        private string userId;
        private string anotherId;
        private string userId3;
        private string miller;
        private string conn;

        public OnlineFormDbTests()
        {
            var cfg = new MapperConfigurationExpression();
            cfg.AddProfile<SimsDbMappingProfile>();
            var mapperConfig = new MapperConfiguration(cfg);
            this.mapper = new Mapper(mapperConfig);

            var seedInfo = new SeedingConfigData();

            this.userId = seedInfo.userIds[0];
            this.anotherId = seedInfo.userIds[1];
            this.userId3 = seedInfo.userIds[2];
            this.miller = seedInfo.userIds[3];
            var config = seedInfo.GetConfigData();
            this.conn = ((JsonElement)config["ConnectionStrings:FSADbConn"]).ToString();
        }

        [Fact(DisplayName = "Basic Add")]
        public async Task AddOnlineForm()
        {

            var factCheck = "This is a title";
            var newOnlineForm = new SimsOnlineForm
            {
                Title = factCheck,
                NotifierType = "Notifiier type",
                Description = "Nature of the problem",
                Action = "Action to be placed, or has placed",
                DeathIllness = "Death illness",
                DistributionDetails = "Where did this get done didded",
                AdditionalInformation = "Anything else I added",
                IsClosed = false,
                IncidentTypeId = 70,
                LADetails = "HA AHAHAHAHAHAH!"
            };


            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var savedForm = await simsHost.OnlineForms.Add(newOnlineForm);
                Assert.True(savedForm.Title == factCheck);
            }
        }

        [Fact(DisplayName = "Bulk add")]
        public async Task BulkAdd()
        {
            var listOForms = new List<SimsOnlineForm>();
            var topVal = 10;
            for (var x = 0; x < topVal; ++x)
            {
                var factCheck = $"Bulk ADd: This is {x + 1} or {topVal}";
                var newOnlineForm = new SimsOnlineForm
                {
                    Title = factCheck,
                    NotifierType = "Notifiier type",
                    Description = "Nature of the problem",
                    Action = "Action to be placed, or has placed",
                    DeathIllness = "Death illness",
                    DistributionDetails = "Where did this get done didded",
                    AdditionalInformation = "Anything else I added",
                    IsClosed = false,
                    IncidentTypeId = 70,
                    LADetails = "MORE LA!"
                };
                listOForms.Add(newOnlineForm);
            }


            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                await simsHost.OnlineForms.AddBatch(listOForms);
                Assert.True(true);
            }
        }

        [Fact(DisplayName = "Add Update")]
        public async Task AddUpdateOnlineForm()
        {
            var factCheck = "Record to be updated";
            var updatedIncidentType = 71;
            var newOnlineForm = new SimsOnlineForm
            {
                Title = factCheck,
                NotifierType = "Notifiier type",
                Description = "Nature of the problem",
                Action = "Action to be placed, or has been placed",
                DeathIllness = "Death illness",
                DistributionDetails = "Where did this get done didded",
                AdditionalInformation = "Anything else I added",
                IsClosed = false,
                IncidentTypeId = 70,
                LADetails = "Update able record.!"
            };

            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var savedForm = await simsHost.OnlineForms.Add(newOnlineForm);
                savedForm.IncidentTypeId = updatedIncidentType;
                var updatedForm = await simsHost.OnlineForms.Update(savedForm);
                Assert.True(updatedForm.Title == factCheck && updatedForm.IncidentTypeId == updatedIncidentType);
            }
        }

        [Fact(DisplayName = "Close No incident - Update")]
        public async Task CloseOnlineForm()
        {

            var factCheck = "Close form (No Incident) Update";
            var newOnlineForm = new SimsOnlineForm
            {
                Title = factCheck,
                NotifierType = "Notifiier type",
                Description = "Nature of the problem",
                Action = "Action to be placed, or has been placed",
                DeathIllness = "Death illness",
                DistributionDetails = "Where did this get done didded",
                AdditionalInformation = "Anything else I added",
                IsClosed = false,
                IncidentTypeId = 70,
                LADetails = "Update able record.!"
            };

            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var savedForm = await simsHost.OnlineForms.Add(newOnlineForm);
                savedForm.IsClosed = true;
                await Assert.ThrowsAsync<DataMisalignedException>(async () => await simsHost.OnlineForms.Update(savedForm));
                //var isclosed = await simsHost.OnlineForms.IsClosed(updatedForm.CommonId);
                //Assert.True(isclosed);
            }
        }

        [Fact(DisplayName = "Close No incident - Method")]
        public async Task CloseMethodOnlineForm()
        {
            var factCheck = "Close form (No Incident) CloseMethod";
            var newOnlineForm = new SimsOnlineForm
            {
                Title = factCheck,
                NotifierType = "Notifiier type",
                Description = "Nature of the problem",
                Action = "Action to be placed, or has been placed",
                DeathIllness = "Death illness",
                DistributionDetails = "Where did this get done didded",
                AdditionalInformation = "Anything else I added",
                IsClosed = false,
                IncidentTypeId = 69,
                LADetails = "Update able record.!"
            };

            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var savedForm = await simsHost.OnlineForms.Add(newOnlineForm);
                await simsHost.OnlineForms.CloseNoIncident(savedForm.CommonId, "This is the reason I have closed it.");

                var isclosed = await simsHost.OnlineForms.IsClosed(savedForm.CommonId);
                Assert.True(isclosed);
            }
        }

        [Fact(DisplayName = "Exists")]
        public async Task ExistsOnlineForm()
        {

            var factCheck = "Exists online form";
            var newOnlineForm = new SimsOnlineForm
            {
                Title = factCheck,
                NotifierType = "Notifiier type",
                Description = "Nature of the problem",
                Action = "Action to be placed, or has placed",
                DeathIllness = "Death illness",
                DistributionDetails = "Where did this get done didded",
                AdditionalInformation = "Anything else I added",
                IsClosed = false,
                IncidentTypeId = 70,
                LADetails = "Wilbur force pains."
            };


            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var savedForm = await simsHost.OnlineForms.Add(newOnlineForm);
                var isReal = await simsHost.OnlineForms.Exists(savedForm.CommonId);
                Assert.True(isReal);
            }
        }

        [Fact(DisplayName = "Add Stakeholder")]
        public async Task AddStakeholderOnlineForm()
        {
            var factCheck = "New stakeholder";
            var updatedIncidentType = 71;
            var newOnlineForm = new SimsOnlineForm
            {
                Title = factCheck,
                NotifierType = "Notifiier type",
                Description = "Nature of the problem",
                Action = "Action to be placed, or has been placed",
                DeathIllness = "Death illness",
                DistributionDetails = "Where did this get done didded",
                AdditionalInformation = "Anything else I added",
                IsClosed = false,
                IncidentTypeId = 70,
                LADetails = "Update able record.!"
            };

            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var savedForm = await simsHost.OnlineForms.Add(newOnlineForm);
                savedForm.IncidentTypeId = updatedIncidentType;
                var stakeHolders = await simsHost.OnlineForms.Stakeholders.Add(savedForm.CommonId, new SimsStakeholder
                {
                    AddressId = 42,
                    AddressTitle = "This sims stakeholders address",
                    DiscriminatorId = 1,
                    Email = "sims@stakegolder.emil.aomc",
                    GovDept = "Gov Dept",
                    Name = "Sims Stakholeer",
                    Phone = "01234 Phonme"
                });

                Assert.True(stakeHolders.Id > 0);
            }
        }
    }
}
