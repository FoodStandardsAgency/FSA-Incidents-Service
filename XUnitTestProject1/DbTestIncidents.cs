using _UnitTests;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb;
using FSA.IncidentsManagementDb.Entities;
using FSA.IncidentsManagementDb.Repositories;
using Microsoft.EntityFrameworkCore;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FSA.UnitTests.Db
{
    public class DbTestIncidents : IDisposable
    {
        private string userId = "2f65582c-5970-4848-9020-d65b6df2dc04";
        private string anotherId = "9a8dda39-78ec-496d-8625-f8b24d83aa57";
        private string userId3 = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"; // FSA.Test
        private string miller = "8cc321a9-fea4-4689-a127-c5e141e2810c";

        private ConfigFile Config { get; }

        private FSADbContext ctx;

        public DbTestIncidents()
        {
            this.Config = System.Text.Json.JsonSerializer.Deserialize<ConfigFile>(File.OpenText("./config.json").ReadToEnd());

            ctx = new FSADbContext(new DbContextOptionsBuilder().UseSqlServer(Config.dbConn).Options);
        }

        [Fact]
        public async Task AddIncidentNoLeadOfficer()
        {
            var incident = new BaseIncident(
                   incidentTitle: "New Incident",
                   incidentDescription: "New incidentDescription",
                   incidentTypeId: 1,
                   contactMethodId: 3,
                   statusId: (int)IncidentStatus.Unassigned,
                   priorityId: 2,
                   classificationId: 1,
                   dataSourceId: 1,
                   productTypeId: 3,
                   leadOfficer: "",
                   adminLeadId: 1,
                   leadOffice: "",
                   fieldOfficer: "",
                   lAAdvised: false,
                   deathIllnessId: 3,
                   receivedOn: null,
                   incidentCreated: DateTime.Now,
                   lastChangedBy: "Paul",
                   lastChangedDate: DateTime.Now,
                   signalStatusId: null,
                   notifierId: null,
                   principalFBOId: null,
                   leadLocalAuthorityId: null,
                   incidentClosed: null
                   ); ;

            IFSAIncidentsData incidents = new FSAIncidentsManagement(ctx, userId);
            var savedIncident = await incidents.Incidents.Add(incident);

            Assert.True(savedIncident.MostUniqueId != Guid.Empty && savedIncident.StatusId == (int)IncidentStatus.Unassigned);
        }

        [Fact]
        public async Task AddIncidentLeadOfficer()
        {
            var incident = new BaseIncident(
                   incidentTitle: "Peanuts",
                   incidentDescription: "Stolen peanutes",
                   incidentTypeId: 1,
                   contactMethodId: 3,
                   statusId: (int)IncidentStatus.Unassigned,
                   priorityId: 2,
                   classificationId: 1,
                   dataSourceId: 1,
                   productTypeId: 3,
                   leadOfficer: userId,
                   adminLeadId: 1,
                   leadOffice: "",
                   fieldOfficer: "",
                   lAAdvised: false,
                   deathIllnessId: 3,
                   receivedOn: null,
                   incidentCreated: DateTime.Now,
                   lastChangedBy: "Paul",
                   lastChangedDate: DateTime.Now,
                   signalStatusId: null,
                   notifierId: null,
                   principalFBOId: null,
                   leadLocalAuthorityId: null,
                   incidentClosed: null
       ); ;

            IFSAIncidentsData incidents = new FSAIncidentsManagement(ctx, userId);
            var savedIncident = await incidents.Incidents.Add(incident);

            Assert.True(savedIncident.MostUniqueId != Guid.Empty);
        }

        [Fact]
        public async Task UpdateIncidents()
        {
            var fakeId = Guid.Parse("00000000-0000-0000-0000-000000000001");
            var incident = new BaseIncident(
           id: 5,
           mostUniqueId: fakeId,
           incidentTitle: "Peanuts",
           incidentDescription: "Stolen peanutes",
           incidentTypeId: 1,
           contactMethodId: 3,
           statusId: (int)IncidentStatus.Unassigned,
           priorityId: 1,
           classificationId: 1,
           dataSourceId: 1,
           productTypeId: 3,
           leadOfficer: userId,
           adminLeadId: 1,
           leadOffice: "",
           fieldOfficer: "",
           lAAdvised: false,
           deathIllnessId: 3,
           receivedOn: null,
           incidentCreated: DateTime.Now,
           lastChangedBy: "Paul",
           lastChangedDate: DateTime.Now,
           signalStatusId: null,
           notifierId: null,
           principalFBOId: null,
           leadLocalAuthorityId: null,
           incidentClosed: null
            );

            IFSAIncidentsData incidents = new FSAIncidentsManagement(ctx, userId);
            var savedIncident = await incidents.Incidents.UpdateIncident(incident);

            Assert.True(incident.MostUniqueId == fakeId);
        }

        [Fact]
        public async Task DashboardSearchPeanut()
        {
            IFSAIncidentsData incidents = new FSAIncidentsManagement(ctx, userId);
            var results  = await incidents.Incidents.DashboardSearch("peanuts");
            Assert.True(results.Count() > 0);
        }


        [Fact]
        public async Task DashboardSearchLastPage()
        {
            IFSAIncidentsData incidents = new FSAIncidentsManagement(ctx, userId);
            var finalPage = (await incidents.Incidents.DashboardSearch(pageSize:10, startPage:520)).ToList();
            var finalPageM1 = (await incidents.Incidents.DashboardSearch(pageSize:10, startPage:518)).ToList();
            var pages = (await incidents.Incidents.DashboardSearch(pageSize:10, startPage:516)).ToList();
            var mpage1 = (await incidents.Incidents.DashboardSearch(pageSize:10, startPage:514)).ToList();
            var finalPageP1 = (await incidents.Incidents.DashboardSearch(pageSize:10, startPage:521)).ToList();
            Assert.True(finalPage.Count() > 0 && finalPageM1.Count()==10 && finalPageP1.Count()==0);
        }



        public void Dispose()
        {
            if (ctx != null)
                ctx.Dispose();
        }
    }
}
