using AutoMapper;
using AutoMapper.Configuration;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Entities.Helpers;
using FSA.SIMSManagerDb;
using FSA.SIMSManagerDb.MapperProfile;
using FSA.SIMSManagerDb.Repositories;
using SIMS.TestProjects.Setup;
using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace SIMS.Database
{
    public class IncidentsTesting
    {
        private IMapper mapper;
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
            var incident = new BaseIncident(
                incidentTitle: "New Incident (no Lead officer)",
                incidentTypeId: 1,
                contactMethodId: 2,
                statusId: (int)IncidentStatusTypes.Unassigned,
                priorityId: 2,
                classificationId: 1,
                dataSourceId: 1,
                signalUrl: "",
                productTypeId: 3,
                leadOfficer: "",
                adminLeadId: 1,
                leadOffice: "",
                fieldOfficer: "",
                lAAdvised: false,
                deathIllnessId: 3,
                receivedOn: null,
                incidentCreated: DateTime.Now,
                lastChangedBy: this.userId,
                lastChangedDate: DateTime.Now,
                signalStatusId: null,
                notifierId: null,
                principalFBOId: null,
                leadLocalAuthorityId: null,
                incidentClosed: null
                ); ;
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var savedIncident = await simsHost.Incidents.Add(incident);
                Assert.True(savedIncident.MostUniqueId != Guid.Empty && savedIncident.StatusId == (int)IncidentStatusTypes.Unassigned);
            }
        }



        [Fact(DisplayName = "Add incident with lead officer")]
        public async Task AddIncidentLeadOfficer()
        {
            var incident = new BaseIncident(
                   incidentTitle: "New Incident (Lead officer)",
                   incidentTypeId: 1,
                   contactMethodId: 2,
                   statusId: (int)IncidentStatusTypes.Unassigned,
                   priorityId: 2,
                   classificationId: 1,
                   dataSourceId: 1,
                   signalUrl: "",
                   productTypeId: 3,
                   leadOfficer: this.userId3,
                   adminLeadId: 1,
                   leadOffice: "",
                   fieldOfficer: "",
                   lAAdvised: false,
                   deathIllnessId: 3,
                   receivedOn: null,
                   incidentCreated: DateTime.Now,
                   lastChangedBy: this.miller,
                   lastChangedDate: DateTime.Now,
                   signalStatusId: null,
                   notifierId: null,
                   principalFBOId: null,
                   leadLocalAuthorityId: null,
                   incidentClosed: null
       );
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var savedIncident = await simsHost.Incidents.Add(incident);
                Assert.True(savedIncident.MostUniqueId != Guid.Empty);
            }

        }

        [Fact(DisplayName = "Can't change most unique")]
        public async Task UpdateIncidentsFakeGuid()
        {

            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {

                var fakeId = Guid.Parse("00000000-0000-0000-0000-000000000001");
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var incidents = simsHost.Incidents;
                var incident = await incidents.Get(1);
                var updated = incident
                        .WithMostUnique(Guid.Parse("00000000-0000-0000-0000-000000000001"))
                        .WithPriority((int)PrioritiesStatus.Medium);

                await Assert.ThrowsAsync<InvalidOperationException>(async() => await incidents.Update(updated));
                //savedIncident.MostUniqueId == fakeId && savedIncident.PriorityId == (int)PrioritiesStatus.Medium);
            }
        }

        [Fact(DisplayName = "Update incident, set FBO from existing address")]
        public async Task UpdateIncidentSetFbo()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);

                BaseIncident incident = await simsHost.Incidents.Get(22);
                // Ensure we have a lead officer and we are open
                var changedIncident = incident
                                        .WithPrincipalFbo(16);
                var updateIncident = await simsHost.Incidents.Update(changedIncident);
                Assert.True(updateIncident.PrincipalFBOId == 16);
            }
        }

        [Fact]
        public async Task RetrieveUpdateSaveLeadOfficer()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);

                var incidentId = await simsHost.Incidents.Get(1);

                var incident = await simsHost.Incidents.Get(incidentId.MostUniqueId);

                var fakeUser = Guid.NewGuid().ToString();
                // Ensure we have a lead officer and we are open
                var changedIncident = incident
                                        .WithStatus((int)IncidentStatusTypes.Open)
                                        .WithLeadOfficer(fakeUser);

                var updateIncident = await simsHost.Incidents.Update(changedIncident);
                Assert.True(updateIncident.LeadOfficer == fakeUser && updateIncident.StatusId == (int)IncidentStatusTypes.Open);
            }
        }

        [Fact]
        public async Task RetrieveUpdateBlankNotifier()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {

                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var incidentId = await simsHost.Incidents.Get(3);

                var incident = await simsHost.Incidents.Get(incidentId.MostUniqueId);

                // Ensure we have a lead officer and we are open
                var changedIncident = incident
                                        .WithNotifier(null);

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

                // Closing shall replace the leadOfficer
                var changedIncident = incident
                                        .WithStatus((int)IncidentStatusTypes.Closed);
                //.WithLeadOfficer(this.userId3);

                var updateIncident = await simsHost.Incidents.Update(changedIncident);
                Assert.True(updateIncident.StatusId == (int)IncidentStatusTypes.Closed);
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
                await simsHost.Incidents.AssignLeadOfficer(new int[] { 39, 82, 102, 55 }, fakeUser);
                var Officer39 = (await simsHost.Incidents.Get(39)).LeadOfficer;
                var Officer102 = (await simsHost.Incidents.Get(102)).LeadOfficer;
                var Officer55 = (await simsHost.Incidents.Get(55)).LeadOfficer;
                var i82 = (await simsHost.Incidents.Get(82));
                var Officer82 = i82.LeadOfficer;
                Assert.True(Officer39 == fakeUser && Officer102 == fakeUser && Officer55 == fakeUser && Officer82 != fakeUser);
                Assert.True(i82.StatusId == (int)IncidentStatusTypes.Closed);
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
                var updated = data.WithLocalAuthority(5);

                var item = await simsHost.Incidents.Update(updated);
                Assert.True(item.LeadLocalAuthorityId == 5);
            }

        }

        [Fact]
        public async Task NullToNullLeadLocalAuthroity()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var data = await simsHost.Incidents.Get(3);
                var updated = data.WithLocalAuthority(null);

                var item = await simsHost.Incidents.Update(updated);

                Assert.True(item.LeadLocalAuthorityId == null);
            }

        }

        [Fact]
        public async Task CloseIncident()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var data = await simsHost.Incidents.Get(59);
                var updated = data.WithIncidentStatus((int)IncidentStatusTypes.Closed);
                var item = await simsHost.Incidents.Update(updated);
                Assert.True(item.IncidentClosed != null && item.StatusId == (int)IncidentStatusTypes.Closed);
            }
        }

        [Fact(DisplayName ="Not quite there yet")]
        public async Task UpdateClosedIncident()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var data = await simsHost.Incidents.Get(59);
                var updated = data.WithTitle("New Title after closing");
                //await Assert.ThrowsAsync<IncidentClosedException>(async () => await simsHost.Incidents.Update(updated));
            }
        }


    }
}
