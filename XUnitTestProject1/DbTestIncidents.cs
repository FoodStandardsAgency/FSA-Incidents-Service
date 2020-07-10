﻿using _UnitTests;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb;
using FSA.IncidentsManagementDb.Entities;
using FSA.IncidentsManagementDb.Entities.Helpers;
using FSA.IncidentsManagementDb.Repositories;
using FSA.UnitTests.Misc;
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
    public class DbTestIncidents : IClassFixture<DbContextFixture>
    {
        private string userId = "2f65582c-5970-4848-9020-d65b6df2dc04";
        private string anotherId = "9a8dda39-78ec-496d-8625-f8b24d83aa57";
        private string userId3 = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"; // FSA.Test
        private string miller = "8cc321a9-fea4-4689-a127-c5e141e2810c";

        internal DbContextFixture Fixture { get; }


        public DbTestIncidents(DbContextFixture fixture) => Fixture = fixture;



        [Fact]
        public async Task AddIncidentNoLeadOfficer()
        {
            var incident = new BaseIncident(
                   incidentTitle: "New Incident",
                   incidentDescription: "New incidentDescription",
                   incidentTypeId: 1,
                   contactMethodId: 2,
                   statusId: (int)IncidentStatus.Unassigned,
                   priorityId: 2,
                   classificationId: 1,
                   dataSourceId: 1,
                   signalUrl:"",
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

        [Fact]
        public async Task AddIncidentLeadOfficer()
        {
            var incident = new BaseIncident(
                   incidentTitle: "Peanuts",
                   incidentDescription: "Stolen peanutes",
                   incidentTypeId: 1,
                   contactMethodId: 4,
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
                Assert.True(String.IsNullOrEmpty(updateIncident.LeadOfficer) && updateIncident.StatusId == (int)IncidentStatus.Closed);
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
                
                var updated  = data.WithIncidentStatus((int)IncidentStatus.Closed);

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

                await Assert.ThrowsAsync<ArgumentOutOfRangeException>(async ()=> await incidents.Incidents.Update(updated));
            }
        }
        
        [Fact]
        public async Task LinkToClosed()
        {
            // record Id 82should be closed
            //  crash the test otherwise
            var incidentId = 82;
            using (var ctx = this.Fixture.CreateContext())
            {
                ISIMSManager sims= new SIMSDataManager(ctx, userId);
                var data = await sims.Incidents.Get(incidentId);
               var itm =  await sims.Incidents.Update(data.WithIncidentStatus(2));

                if(itm.StatusId!=(int)IncidentStatus.Closed)
                {
                    throw new ArgumentException("This record is not closed!");
                }

                await sims.Incidents.AddLinks(45, new int[] { 19, 100, incidentId, 55 }, "No reason to take the bait");

                var displayBox = await sims.Incidents.DashboardIncidentLinks(incidentId);
                var matchedItem = displayBox.FirstOrDefault(o => o.CommonId == 19);
                Assert.True(matchedItem!=null); 
            }
        }
    }
}
