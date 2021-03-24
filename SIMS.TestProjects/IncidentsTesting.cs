using AutoMapper;
using AutoMapper.Configuration;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
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
    public class IncidentsTesting
    {
        private readonly IMapper mapper;
        private string userId;
        private string anotherId;
        private string userId3;
        private string miller;
        private string conn;

        public IncidentsTesting()
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


        [Fact]
        public async Task AddNewIncidentNoLeadOfficer()
        {
            var incident = new SIMSIncident
            {
                IncidentTitle = "New Incident (no Lead officer)",
                Categories=new List<int>() { 36,21 },
                ContactMethodId = 2,
                IncidentSourceId = 14,
                StatusId = (int)SimsIncidentStatusTypes.Unassigned,
                PriorityId = 2,
                ClassificationId = 1,
                DataSourceId = 9,
                SignalUrl = "",
                ProductTypeId = 3,
                LeadOfficer = "",
                AdminLeadId = 1,
                LeadOffice = "",
                OIMTGroups = "",
                FieldOfficer = "",
                LAAdvised = false,
                DeathIllnessId = 3,
                OnlineFormId = null,
                ReceivedOn = null,
                IncidentCreated = DateTime.Now,
                LastChangedBy = this.userId,
                LastChangedDate = DateTime.Now,
                SignalStatusId = null,
                SensitiveInfo = true,
                NotifierId = null,
                PrincipalFBOId = null,
                LeadLocalAuthorityId = null,
                IncidentClosed = null
            }; ;
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var savedIncident = await simsHost.Incidents.Add(incident);
                Assert.True(savedIncident.StatusId == (int)SimsIncidentStatusTypes.Unassigned);
            }
        }


        [Fact(DisplayName = "Add incident with no death illness")]
        public async Task AddIncidentNoDeathIllness()
        {
            var incident = new SIMSIncident
            {
                IncidentTitle = "New Incident (no death illness)",
                Categories = new List<int>() { 4,5,6},
                ContactMethodId = 2,
                IncidentSourceId = 1,
                StatusId = (int)SimsIncidentStatusTypes.Open,
                PriorityId = 2,
                ClassificationId = 1,
                DataSourceId = 9,
                SignalUrl = "",
                ProductTypeId = 3,
                LeadOfficer = this.userId3,
                AdminLeadId = 1,
                LeadOffice = "",
                OIMTGroups = "OimtGroups, OimitGroups 2",
                FieldOfficer = "",
                LAAdvised = false,
                DeathIllnessId = null,
                ReceivedOn = null,
                OnlineFormId = null,
                SensitiveInfo = true,
                IncidentCreated = DateTime.Now,
                LastChangedBy = this.miller,
                LastChangedDate = DateTime.Now,
                SignalStatusId = null,
                NotifierId = null,
                PrincipalFBOId = null,
                LeadLocalAuthorityId = null,
                IncidentClosed = null
            };
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var savedIncident = await simsHost.Incidents.Add(incident);
                Assert.True(true);
            }

        }



        [Fact(DisplayName = "Add incident with lead officer")]
        public async Task AddIncidentLeadOfficer()
        {
            var incident = new SIMSIncident
            {
                IncidentTitle = "New Incident (Lead officer)",
                Categories = new List<int>() { 18},
                IncidentSourceId = 4,
                ContactMethodId = 2,
                StatusId = (int)SimsIncidentStatusTypes.Unassigned,
                PriorityId = 2,
                ClassificationId = 1,
                DataSourceId = 9,
                OIMTGroups = "OimtGroups, OimitGroups 2",
                SignalUrl = "",
                ProductTypeId = 3,
                LeadOfficer = this.userId3,
                AdminLeadId = 1,
                LeadOffice = "Rred",
                FieldOfficer = "",
                LAAdvised = false,
                OnlineFormId = null,
                DeathIllnessId = 3,
                ReceivedOn = null,
                IncidentCreated = DateTime.Now,
                LastChangedBy = this.miller,
                LastChangedDate = DateTime.Now,
                SignalStatusId = null,
                NotifierId = null,
                SensitiveInfo = false,

                PrincipalFBOId = null,
                LeadLocalAuthorityId = null,
                IncidentClosed = null
            };
            using var ctx = SeedingConfigData.GetDbContext(this.conn);
            var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
            var savedIncident = await simsHost.Incidents.Add(incident);
            Assert.True(savedIncident.LeadOfficer != "Rred");

        }

        [Fact(DisplayName = "Update product Type")]
        public async Task UpdateProductType()
        {

            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {

                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var incidents = simsHost.Incidents;
                var incident = await incidents.Get(19);
                incident.ProductTypeId = (23);
                var updated = incident;

                var updateDb = await incidents.Update(updated);

                Assert.True(updateDb.ProductTypeId == 23);

                //await Assert.ThrowsAsync<InvalidOperationException>(async () => );
                //savedIncident.MostUniqueId == fakeId && savedIncident.PriorityId == (int)PrioritiesStatus.Medium);

            }
        }

        [Fact(DisplayName = "Update incident, set FBO from existing address")]
        public async Task UpdateIncidentSetFbo()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                SIMSIncident incident = await simsHost.Incidents.Get(22);
                incident.PrincipalFBOId = 16;
                var changedIncident = incident;

                var updateIncident = await simsHost.Incidents.Update(changedIncident);
                Assert.True(updateIncident.PrincipalFBOId == 16);
            }
        }

        [Fact]
        public async Task RetrieveUpdateSaveLeadOfficer()
        {
            using var ctx = SeedingConfigData.GetDbContext(this.conn);
            var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);

            var incident = await simsHost.Incidents.Get(1);



            var fakeUser = Guid.NewGuid().ToString();
            incident.StatusId = (int)SimsIncidentStatusTypes.Open;
            incident.LeadOfficer = fakeUser;
            // Ensure we have a lead officer and we are open
            var changedIncident = incident;


            var updateIncident = await simsHost.Incidents.Update(changedIncident);
            Assert.True(updateIncident.LeadOfficer == fakeUser && updateIncident.StatusId == (int)SimsIncidentStatusTypes.Open);
        }

        [Fact]
        public async Task RetrieveUpdateBlankNotifier()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {

                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);

                var incident = await simsHost.Incidents.Get(3);
                incident.NotifierId = null;
                // Ensure we have a lead officer and we are open
                var changedIncident = incident;

                var updateIncident = await simsHost.Incidents.Update(changedIncident);
                Assert.False(updateIncident.NotifierId.HasValue);
            }
        }

        [Fact]
        public async Task RetrieveUpdateCloseStatus()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {

                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var incident = await simsHost.Incidents.Get(2);
                incident.StatusId = (int)SimsIncidentStatusTypes.Closed;
                // Closing shall replace the leadOfficer
                var changedIncident = incident;

                //.WithLeadOfficer(this.userId3);

                var updateIncident = await simsHost.Incidents.Update(changedIncident);
                Assert.True(updateIncident.StatusId == (int)SimsIncidentStatusTypes.Closed);
            }
        }

        [Fact]
        public async Task AssignLeadOfficer()
        {
            // assign a user to a collection of incidents.
            // one of them (82) is known to be closed. It should NOT be assigned, and should be closed.
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var fakeUser = Guid.NewGuid().ToString();
                await simsHost.Incidents.BulkClose(new int[] { 82 });
                await simsHost.Incidents.UpdateLeadOfficer(new int[] { 39, 82, 102, 55 }, fakeUser);
                var Officer39 = (await simsHost.Incidents.Get(39)).LeadOfficer;
                var Officer102 = (await simsHost.Incidents.Get(102)).LeadOfficer;
                var Officer55 = (await simsHost.Incidents.Get(55)).LeadOfficer;
                var i82 = (await simsHost.Incidents.Get(82));
                var Officer82 = i82.LeadOfficer;
                Assert.True(Officer39 == fakeUser && Officer102 == fakeUser && Officer55 == fakeUser && Officer82 != fakeUser);
                Assert.True(i82.StatusId == (int)SimsIncidentStatusTypes.Closed);
            }
        }


        [Fact]
        public async Task DashboardSearchPeanut()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var results = await simsHost.Incidents.DashboardSearch("peanuts");
                Assert.True(results.TotalResults > 0);
            }
        }

        [Fact]
        public async Task DashboardSearchLastPage()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var data = (await simsHost.Incidents.DashboardSearch(PageSize: 10, StartPage: 519));
                var mod = data.TotalResults % 10;
                var allPages = (data.TotalResults / 10) + ((mod != 0) ? 1 : 0);

                var finalPage = (await simsHost.Incidents.DashboardSearch(PageSize: 10, StartPage: allPages)).ToList();
                var finalPageM1 = (await simsHost.Incidents.DashboardSearch(PageSize: 10, StartPage: allPages - 1)).ToList();
                var pages = (await simsHost.Incidents.DashboardSearch(PageSize: 10, StartPage: allPages - 2)).ToList();
                var mpage1 = (await simsHost.Incidents.DashboardSearch(PageSize: 10, StartPage: allPages - 3)).ToList();
                var finalPageP1 = (await simsHost.Incidents.DashboardSearch(PageSize: 10, StartPage: allPages + ((mod != 0) ? 2 : 1))).ToList();
                Assert.True(finalPage.Count() > 0 && finalPageM1.Count() == 10 && finalPageP1.Count() == 0);
            }
        }

        [Fact]
        public async Task NullToValueLeadLocalAuthroity()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var data = await simsHost.Incidents.Get(32);
                data.LeadLocalAuthorityId = 5;
                var updated = data;

                var item = await simsHost.Incidents.Update(updated);
                Assert.True(item.LeadLocalAuthorityId == 5);
            }

        }

        [Fact]
        public async Task NullToNullLeadLocalAuthroity()
        {
            using var ctx = SeedingConfigData.GetDbContext(this.conn);
            var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
            var data = await simsHost.Incidents.Get(3);
            data.LeadLocalAuthorityId = null;
            var updated = data;

            var item = await simsHost.Incidents.Update(updated);

            Assert.True(item.LeadLocalAuthorityId == null);

        }

        [Fact]
        public async Task CloseIncident()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var data = await simsHost.Incidents.Get(59);
                data.StatusId = (int)SimsIncidentStatusTypes.Closed;
                var updated = data;
                var item = await simsHost.Incidents.Update(updated);
                Assert.True(item.IncidentClosed != null && item.StatusId == (int)SimsIncidentStatusTypes.Closed);
            }
        }

        [Fact(DisplayName = "Not quite there yet")]
        public async Task UpdateClosedIncident()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var data = await simsHost.Incidents.Get(59);
                data.IncidentTitle = "New Title after closing";
                var updated = data;
            }
        }


    }
}
