using AutoMapper;
using AutoMapper.Configuration;
using FSA.SIMSManagerDb.MapperProfile;
using FSA.SIMSManagerDb.Repositories;
using SIMS.TestProjects.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace SIMS.Database
{

    public class AuditLogTesting
    {
        private IMapper mapper;
        private string userId;
        private string conn;

        public AuditLogTesting()
        {
            var cfg = new MapperConfigurationExpression();
            cfg.AddProfile<SimsDbMappingProfile>();
            var mapperConfig = new MapperConfiguration(cfg);
            this.mapper = new Mapper(mapperConfig);
            var seedInfo = new SeedingConfigData();
            this.userId = seedInfo.userIds[0];

            var config = seedInfo.GetConfigData();
            this.conn = ((JsonElement)config["ConnectionStrings:FSADbConn"]).ToString();
        }

        [Fact]
        public async Task AddIncidentUser()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
               await simsHost.Audit.LogEntry("Incident", "TestPageAlpha", 44);
            }
        }

        [Fact]
        public async Task AddSignalUser()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                await simsHost.Audit.LogEntry("Signal", "TestPageOverview", 500);
            }
        }

    }
}
