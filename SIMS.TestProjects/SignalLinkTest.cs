﻿using AutoMapper;
using AutoMapper.Configuration;
using FSA.SIMSManagerDb.MapperProfile;
using FSA.SIMSManagerDb.Repositories;
using SIMS.TestProjects.Setup;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace SIMS.Database
{
    public class SignalLinkTest
    {
        private IMapper mapper;
        private string userId;
        private string anotherId;
        private string userId3;
        private string miller;
        private string conn;

        public SignalLinkTest()
        {
            var cfg = new MapperConfigurationExpression();
            cfg.AddProfile<SIMSMappingProfile>();
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
        public async Task AddLink()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var allLinks = (await simsHost.Signals.Links.Add(1, new int[] { 40, 34, 85 }, "Terry can")).ToList();
                Assert.True(allLinks.Count == 4);
            }
        }

        [Fact]
        public async Task RemoveLink()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var removedLink = await simsHost.Signals.Links.Remove(1, 40);
                Assert.True(removedLink.From == 1 && removedLink.To == 40);
            }
        }
    }
}
