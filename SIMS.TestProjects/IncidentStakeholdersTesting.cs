using AutoMapper;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.SIMSManagerDb;
using FSA.SIMSManagerDb.Repositories;
using SIMS.TestProjects.Setup;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace SIMS.Database
{
    public class IncidentStakeholdersTesting
    {
        private IMapper mapper;
        private string userId;
        private string anotherId;
        private string userId3;
        private string miller;
        private string conn;
        public IncidentStakeholdersTesting()
        {

            var seedInfo = new SeedingConfigData();
            this.mapper = seedInfo.GetDbAutoMapper();
            this.userId = seedInfo.userIds[0];
            this.anotherId = seedInfo.userIds[1];
            this.userId3 = seedInfo.userIds[2];
            this.miller = seedInfo.userIds[3];
            var config = seedInfo.GetConfigData();
            this.conn = ((JsonElement)config["ConnectionStrings:FSADbConn"]).ToString();
        }

        [Fact]
        public async Task AddStakeholder()
        {
            var newStakeHolder = new SimsStakeholder
            {
                DiscriminatorId = 3,
                HostId = 17,
                Name = "Pickle pie",
                GovDept = "Crusty",
                Phone = "012345 789",
                Role = "Dancing instructor"
            };
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsApp = SimsDbHost.CreateHost(ctx, mapper, this.userId);
                var createdStakeHolder = await simsApp.Incidents.Stakeholders.Add(newStakeHolder.HostId, newStakeHolder);
                Assert.True(createdStakeHolder.Name == newStakeHolder.Name && createdStakeHolder.HostId == 17);
            }
        }
        [Fact]
        public async Task AddStakeholderNoIncident()
        {
            var newStakeHolder = new SimsStakeholder
            {
                DiscriminatorId = 3,
                Name = "Pickle pie",
                GovDept = "Crusty",
                Phone = "012345 789",
                Role = "Dancing instructor"
            };

            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsApp = SimsDbHost.CreateHost(ctx, mapper, this.userId);
                await Assert.ThrowsAnyAsync<Exception>(async () => await simsApp.Incidents.Stakeholders.Add(0, newStakeHolder));
            }
        }

        [Fact]
        public async Task RemoveStakeholder()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsApp = SimsDbHost.CreateHost(ctx, mapper, this.userId);
                var allStakeholders = await simsApp.Incidents.Stakeholders.GetAll(1);
                var totalStakeholders = allStakeholders.Count;
                await simsApp.Incidents.Stakeholders.Remove(2);
                var lessStakeHolders = await simsApp.Incidents.Stakeholders.GetAll(1);
                var s = (totalStakeholders - 1);
                var x = (lessStakeHolders.Count == s);
                Assert.True(x);
                //await Assert.ThrowsAnyAsync<Exception>(async () => await simsApp.IncidentStakeholders.Add(0, newStakeHolder));
            }
        }
    }
}
