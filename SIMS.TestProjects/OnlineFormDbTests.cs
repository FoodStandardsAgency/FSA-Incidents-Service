using AutoMapper;
using AutoMapper.Configuration;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.SIMSManagerDb.MapperProfile;
using FSA.SIMSManagerDb.Repositories;
using SIMS.TestProjects.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
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

        private SimsOnlineForm BasicForm()
        {

            return new SimsOnlineForm
            {
                Title = "Basic Title",
                NotifierTypeId = 1,
                Description = "Nature of the problem",
                Action = "Action to be placed, or has placed",
                DeathIllness = "Death illness",
                DistributionDetails = "Where did this get done didded",
                AdditionalInformation = "Anything else I added",
                IsClosed = false,
                ReferenceNo = "R1234",
                LADetails = "Local Authority"
            };
        }

        [Fact(DisplayName = "Basic Add")]
        public async Task AddOnlineForm()
        {

            var factCheck = "This is a title";
            var newOnlineForm = this.BasicForm();
            newOnlineForm.Title = factCheck;

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
                var newOnlineForm = BasicForm();
                newOnlineForm.Title = factCheck;
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

            var newOnlineForm = BasicForm();
            newOnlineForm.Title = factCheck;
            newOnlineForm.ReferenceNo = "REf No um bah";

            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var savedForm = await simsHost.OnlineForms.Add(newOnlineForm);
                var updatedForm = await simsHost.OnlineForms.Update(savedForm);
                Assert.True(updatedForm.Title == factCheck);
            }
        }

        [Fact(DisplayName = "Add Closed Form")]
        public async Task AddClosedOnlineForm()
        {

            var factCheck = "Already closed";
            var newOnlineForm = this.BasicForm();
            newOnlineForm.Title = factCheck;

            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var savedForm = await simsHost.OnlineForms.Add(newOnlineForm);
                Assert.True(savedForm.IsClosed == false);
            }
        }

        [Fact(DisplayName = "Close No incident - Update")]
        public async Task CloseOnlineForm()
        {

            var factCheck = "Close form (No Incident) Update";
            var newOnlineForm = this.BasicForm();
            newOnlineForm.Title = factCheck;

            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var savedForm = await simsHost.OnlineForms.Add(newOnlineForm);
                savedForm.IsClosed = true;
                await Assert.ThrowsAsync<DataMisalignedException>(async () => await simsHost.OnlineForms.Update(savedForm));
            }
        }

        [Fact(DisplayName = "Close New incident")]
        public async Task CloseNewIncidentOnlineForm()
        {

            var factCheck = "Close form New Incident";
            var newOnlineForm = this.BasicForm();
            newOnlineForm.Title = factCheck;

            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var savedForm = await simsHost.OnlineForms.Add(newOnlineForm);
                var incidentId = await simsHost.OnlineForms.CloseCreateIncident(savedForm.CommonId, "Shutting up shop for the while");
                Assert.True(incidentId > 0);
            }
        }

        [Fact(DisplayName = "Close No incident - Method")]
        public async Task CloseMethodOnlineForm()
        {
            var factCheck = "Close form (No Incident) CloseMethod";
            var newOnlineForm = this.BasicForm();
            newOnlineForm.Title = factCheck;

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
            var newOnlineForm = this.BasicForm();
            newOnlineForm.Title = factCheck;


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
            var newOnlineForm = this.BasicForm();
            newOnlineForm.Title = factCheck;

            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var savedForm = await simsHost.OnlineForms.Add(newOnlineForm);
                
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

        [Fact(DisplayName = "Add Product")]
        public async Task AddProductOnlineForm()
        {

            var factCheck = "Add new Prodcuts";
            var newOnlineForm = this.BasicForm();
            newOnlineForm.Title = factCheck;

            var product = new SimsProduct
            {
                Added = DateTime.Parse("01/01/2000"),
                AdditionalInfo = "Additional product infor",
                BatchCodes = "Big string of data",
                AmountUnitTypeId = 21,
                Amount = "15",
                ProductTypeId = 22,
                Brand = "Product Brand",
                CountryOfOriginId = 90,
                Name = "The faulty product",
                PackSizes = new[] { new SimsProductPackSize { Size = "21", UnitId = 1 } },
                PackDescription = "The is the description of the product.",
                ProductDates = new[] { new SimsProductDate { Date = DateTime.Parse("15/03/27"), DateTypeId = 2 } }
            };

            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var savedForm = await simsHost.OnlineForms.Add(newOnlineForm);
                var newProduct = await simsHost.OnlineForms.Products.Add(savedForm.CommonId, product);
                Assert.True(savedForm.Title == factCheck);
            }
        }

        [Fact(DisplayName = "Add Note")]
        public async Task AddNoteOnlineForm()
        {

            var factCheck = "Add note";
            var newOnlineForm = this.BasicForm();
            newOnlineForm.Title = factCheck;
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var savedForm = await simsHost.OnlineForms.Add(newOnlineForm);
                var noteText = "This is a new note";
                var note = await simsHost.OnlineForms.Notes.Add(savedForm.CommonId, noteText);
                Assert.True(note.HostId == savedForm.CommonId && note.Note == noteText);
            }
        }

        [Fact(DisplayName = "Get dashboard with search")]
        public async Task GetDashboardOnlineForm()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var dashboardSearch = await simsHost.OnlineForms.DashboardSearch("R000-001 bulk title");
                Assert.True(dashboardSearch.Count() > 0);
            }
        }

        [Fact(DisplayName = "Get dashboard No search")]
        public async Task GetDashboardNoSearchOnlineForm()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var dashboardSearch = await simsHost.OnlineForms.DashboardSearch();
                Assert.True(dashboardSearch.Count() > 0);
            }
        }

    }
}
