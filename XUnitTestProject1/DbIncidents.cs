using _UnitTests;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb;
using FSA.IncidentsManagementDb.Entities;
using FSA.IncidentsManagementDb.Entities.Helpers;
using FSA.IncidentsManagementDb.Exceptions;
using FSA.IncidentsManagementDb.Repositories;
using FSA.UnitTests.Misc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FSA.UnitTests.Db
{
    public class DbIncidents : IClassFixture<DbContextFixture>
    {
        private string userId = "2f65582c-5970-4848-9020-d65b6df2dc04";
        private string anotherId = "9a8dda39-78ec-496d-8625-f8b24d83aa57";
        private string userId3 = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"; // FSA.Test
        private string miller = "8cc321a9-fea4-4689-a127-c5e141e2810c";

        internal DbContextFixture Fixture { get; }


        public DbIncidents(DbContextFixture fixture) => Fixture = fixture;



        [Fact]
        public async Task AddIncidentNoLeadOfficer()
        {
            var incident = new BaseIncident(
                   incidentTitle: "New Incident",
                   incidentTypeId: 1,
                   contactMethodId: 2,
                   statusId: (int)IncidentStatus.Unassigned,
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
            using (var ctx = this.Fixture.CreateContext())
            {
                ISIMSManager incidents = new SIMSDataManager(ctx, userId);
                var savedIncident = await incidents.Incidents.Add(incident);
                Assert.True(savedIncident.MostUniqueId != Guid.Empty && savedIncident.StatusId == (int)IncidentStatus.Unassigned);
            }
        }

        [Fact(DisplayName = "Add incindet with lead officer")]
        public async Task AddIncidentLeadOfficer()
        {
            var incident = new BaseIncident(
                   incidentTitle: "Peanuts",
                   incidentTypeId: 1,
                   contactMethodId: 2,
                   statusId: (int)IncidentStatus.Unassigned,
                   priorityId: 2,
                   classificationId: 1,
                   dataSourceId: 1,
                   signalUrl: "",
                   productTypeId: 3,
                   leadOfficer: userId,
                   adminLeadId: 1,
                   leadOffice: "",
                   fieldOfficer: "",
                   lAAdvised: false,
                   deathIllnessId: 3,
                   receivedOn: null,
                   incidentCreated: DateTime.Now,
                   lastChangedBy: userId3,
                   lastChangedDate: DateTime.Now,
                   signalStatusId: null,
                   notifierId: null,
                   principalFBOId: null,
                   leadLocalAuthorityId: null,
                   incidentClosed: null
       );
            using (var ctx = this.Fixture.CreateContext())
            {
                ISIMSManager incidents = new SIMSDataManager(ctx, userId);
                var savedIncident = await incidents.Incidents.Add(incident);

                Assert.True(savedIncident.MostUniqueId != Guid.Empty);
            }

        }

        [Fact(DisplayName = "Can't change most unique")]
        public async Task UpdateIncidentsFakeGuid()
        {

            using (var ctx = this.Fixture.CreateContext())
            {

                var fakeId = Guid.Parse("00000000-0000-0000-0000-000000000001");
                ISIMSManager incidents = new SIMSDataManager(ctx, userId);

                var incident = await incidents.Incidents.Get(1);
                var updated = incident
                        .WithMostUnique(Guid.Parse("00000000-0000-0000-0000-000000000001"))
                        .WithPriority((int)PrioritiesStatus.Medium);

                var savedIncident = await incidents.Incidents.Update(updated);
                Assert.False(savedIncident.MostUniqueId == fakeId && savedIncident.PriorityId == (int)PrioritiesStatus.Medium);
            }
        }

        [Fact(DisplayName = "Update incident, set FBO from existing address")]
        public async Task UpdateIncidentSetFbo()
        {
            using (var ctx = this.Fixture.CreateContext())
            {
                ISIMSManager incidents = new SIMSDataManager(ctx, userId);
                BaseIncident incident = await incidents.Incidents.Get(22);
                // Ensure we have a lead officer and we are open
                var changedIncident = incident
                                        .WithPrincipalFbo(16);
                var updateIncident = await incidents.Incidents.Update(changedIncident);
                Assert.True(updateIncident.PrincipalFBOId == 16);
            }
        }

        [Fact(DisplayName = "Update incident, Clear FBO from existing address")]
        public async Task UpdateIncidentClearFbo()
        {
            using (var ctx = this.Fixture.CreateContext())
            {
                ISIMSManager incidents = new SIMSDataManager(ctx, userId);
                BaseIncident incident = await incidents.Incidents.Get(22);
                // Ensure we have a lead officer and we are open
                var changedIncident = incident
                                        .WithPrincipalFbo(16);
                var updateIncident = await incidents.Incidents.Update(changedIncident);

                var updatedUpdatedIncident = await incidents.Incidents.Update(updateIncident.WithPrincipalFbo(null));
                Assert.True(updatedUpdatedIncident.PrincipalFBOId == null);
            }
        }

        [Fact]
        public async Task RetrieveUpdateSaveLeadOfficer()
        {
            using (var ctx = this.Fixture.CreateContext())
            {
                ISIMSManager incidents = new SIMSDataManager(ctx, userId);
                var incidentId = await incidents.Incidents.Get(1);

                var incident = await incidents.Incidents.Get(incidentId.MostUniqueId);

                // Ensure we have a lead officer and we are open
                var changedIncident = incident
                                        .WithStatus((int)IncidentStatus.Open)
                                        .WithLeadOfficer(this.userId3);

                var updateIncident = await incidents.Incidents.Update(changedIncident);
                Assert.True(updateIncident.LeadOfficer == userId3 && updateIncident.StatusId == (int)IncidentStatus.Open);
            }
        }

        [Fact]
        public async Task RetrieveUpdateBlankNotifier()
        {
            using (var ctx = this.Fixture.CreateContext())
            {

                ISIMSManager incidents = new SIMSDataManager(ctx, userId);
                var incidentId = await incidents.Incidents.Get(3);

                var incident = await incidents.Incidents.Get(incidentId.MostUniqueId);

                // Ensure we have a lead officer and we are open
                var changedIncident = incident
                                        .WithNotifier(null);

                var updateIncident = await incidents.Incidents.Update(changedIncident);
                Assert.False(updateIncident.NotifierId.HasValue);
            }
        }

        [Fact]
        public async Task RetrieveUpdateCloseStatus()
        {
            using (var ctx = this.Fixture.CreateContext())
            {

                ISIMSManager incidents = new SIMSDataManager(ctx, userId);
                var incident = await incidents.Incidents.Get(2);

                // Closing shall replace the leadOfficer
                var changedIncident = incident
                                        .WithStatus((int)IncidentStatus.Closed);
                //.WithLeadOfficer(this.userId3);

                var updateIncident = await incidents.Incidents.Update(changedIncident);
                Assert.True(updateIncident.StatusId == (int)IncidentStatus.Closed);
            }
        }

        [Fact]
        public async Task DashboardSearchPeanut()
        {
            using (var ctx = this.Fixture.CreateContext())
            {
                ISIMSManager incidents = new SIMSDataManager(ctx, userId);
                var results = await incidents.Incidents.DashboardSearch("peanuts");
                Assert.True(results.Count() > 0);
            }
        }

        [Fact]
        public async Task DashboardSearchLastPage()
        {
            using (var ctx = this.Fixture.CreateContext())
            {
                ISIMSManager incidents = new SIMSDataManager(ctx, userId);
                var data = (await incidents.Incidents.DashboardSearch(pageSize: 10, startPage: 519));
                var mod = data.TotalResults % 10;
                var allPages = (data.TotalResults / 10) + ((mod != 0) ? 1 : 0);

                var finalPage = (await incidents.Incidents.DashboardSearch(pageSize: 10, startPage: allPages)).ToList();
                var finalPageM1 = (await incidents.Incidents.DashboardSearch(pageSize: 10, startPage: allPages - 1)).ToList();
                var pages = (await incidents.Incidents.DashboardSearch(pageSize: 10, startPage: allPages - 2)).ToList();
                var mpage1 = (await incidents.Incidents.DashboardSearch(pageSize: 10, startPage: allPages - 3)).ToList();
                var finalPageP1 = (await incidents.Incidents.DashboardSearch(pageSize: 10, startPage: allPages + ((mod != 0) ? 2 : 1))).ToList();
                Assert.True(finalPage.Count() > 0 && finalPageM1.Count() == 10 && finalPageP1.Count() == 0);
            }
        }

        [Fact]
        public async Task NullToValueLeadLocalAuthroity()
        {
            using (var ctx = this.Fixture.CreateContext())
            {
                ISIMSManager incidents = new SIMSDataManager(ctx, userId);
                var data = await incidents.Incidents.Get(32);
                var updated = data.WithLocalAuthority(5);

                var item = await incidents.Incidents.Update(updated);
                Assert.True(item.LeadLocalAuthorityId == 5);
            }

        }

        [Fact]
        public async Task NullToNullLeadLocalAuthroity()
        {
            using (var ctx = this.Fixture.CreateContext())
            {
                ISIMSManager incidents = new SIMSDataManager(ctx, userId);
                var data = await incidents.Incidents.Get(3);
                var updated = data.WithLocalAuthority(null);

                var item = await incidents.Incidents.Update(updated);

                Assert.True(item.LeadLocalAuthorityId == null);
            }

        }

        [Fact]
        public async Task CloseIncident()
        {
            using (var ctx = this.Fixture.CreateContext())
            {
                ISIMSManager incidents = new SIMSDataManager(ctx, userId);
                var data = await incidents.Incidents.Get(59);
                var updated = data.WithIncidentStatus((int)IncidentStatus.Closed);
                var item = await incidents.Incidents.Update(updated);
                Assert.True(item.IncidentClosed != null && item.StatusId == (int)IncidentStatus.Closed);
            }
        }

        [Fact]
        public async Task UpdateClosedIncident()
        {
            using (var ctx = this.Fixture.CreateContext())
            {
                ISIMSManager incidents = new SIMSDataManager(ctx, userId);
                var data = await incidents.Incidents.Get(59);
                var updated = data.WithTitle("New Title after closing");
                await Assert.ThrowsAsync<IncidentClosedException>(async () => await incidents.Incidents.Update(updated));
            }
        }

        [Fact]
        public async Task LinkToClosed()
        {
          
                //  record Id 82should be closed
                //  crash the test otherwise
                var incidentId = 82;
                using (var ctx = this.Fixture.CreateContext())
                {
                    ISIMSManager sims = new SIMSDataManager(ctx, userId);
                    var data = await sims.Incidents.Get(incidentId);
                    await Assert.ThrowsAsync<IncidentClosedException>(async () => await sims.Incidents.Update(data.WithIncidentStatus(2)));

                }

        }

        [Fact]
        public async Task RemoveAlink()
        {
            //  record Id 82should be closed
            //  crash the test otherwise
            var incidentId = 82;
            using (var ctx = this.Fixture.CreateContext())
            {
                ISIMSManager sims = new SIMSDataManager(ctx, userId);
                await sims.Incidents.RemoveLink(13, 79);
                Assert.True(true);
            }
        }


        [Fact]
        public async Task AssignLeadOfficer()
        {
            // assign a user to a collection of incidents.
            // one of them (82) is known to be closed. It should NOT be assigned, and should be closed.
            using (var ctx = this.Fixture.CreateContext())
            {
                var simsApp = new SIMSDataManager(ctx, userId3);
                await simsApp.Incidents.BulkClose(new int[] { 82 });
                await simsApp.Incidents.AssignLeadOfficer(new int[] { 39, 82, 102, 55 }, userId3);
                var Officer39 = (await simsApp.Incidents.Get(39)).LeadOfficer;
                var Officer102 = (await simsApp.Incidents.Get(102)).LeadOfficer;
                var Officer55 = (await simsApp.Incidents.Get(55)).LeadOfficer;
                var i82 = (await simsApp.Incidents.Get(82));
                var Officer82 = i82.LeadOfficer;
                Assert.True(Officer39 == userId3 && Officer102 == userId3 && Officer55 == userId3 && Officer82 != userId3);
                Assert.True(i82.StatusId == (int)IncidentStatus.Closed);
            }
        }

        [Fact]
        public async Task AddStakeholder()
        {
            var newStakeHolder = new Stakeholder
            {
                DiscriminatorId = 3,
                IncidentId = 5517,
                FirstName = "Pickle pie",
                Surname = "Crusty",
                Phone = "012345 789",
                Role = "Dancing instructor"
            };
            using (var ctx = this.Fixture.CreateContext())
            {
                var simsApp = new SIMSDataManager(ctx, userId3);
                var createdStakeHolder =await simsApp.Incidents.AddStakeholder(newStakeHolder);
                Assert.True(createdStakeHolder.FirstName == newStakeHolder.FirstName && createdStakeHolder.IncidentId ==5517);
            }
        }
        [Fact]
        public async Task AddStakeholderNoIncident()
        {
            try
            {
                var newStakeHolder = new Stakeholder
                {
                    DiscriminatorId = 3,
                    FirstName = "Pickle pie",
                    Surname = "Crusty",
                    Phone = "012345 789",
                    Role = "Dancing instructor"
                };
                using (var ctx = this.Fixture.CreateContext())
                {
                    var simsApp = new SIMSDataManager(ctx, userId3);
                    var createdStakeHolder = await simsApp.Incidents.AddStakeholder(newStakeHolder);
                }
            }catch(Exception ex)
            {
                var s = ex;
            }

        }
    }
}
