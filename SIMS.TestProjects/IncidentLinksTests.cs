using AutoMapper;
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
    public class IncidentLinksTests
    {
        private IMapper mapper;
        private string userId;
        private string conn;

        public IncidentLinksTests()
        {
            var cfg = new MapperConfigurationExpression();
            cfg.AddProfile<SimsDbMappingProfile>();
            var mapperConfig = new MapperConfiguration(cfg);
            this.mapper = new Mapper(mapperConfig);

            var seedInfo = new SeedingConfigData();

            this.userId = seedInfo.userIds[0];
;
            var config = seedInfo.GetConfigData();
            this.conn = ((JsonElement)config["ConnectionStrings:FSADbConn"]).ToString();
        }

        [Fact(DisplayName = "Incidents - Add Link")]
        public async Task AddIncidentLink()
        {
            var hostId = 1;
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                // This returns added links
                var addedLinks = (await simsHost.Incidents.Links.Add(hostId, new int[] { 6, 100, 200 }, "Terry can")).ToList();
                var allLinksSet = await simsHost.Incidents.Links.GetForHost(hostId);
                Assert.True(allLinksSet.Count() == 3);
            }
        }

        [Fact(DisplayName = "Incidents - Remove Link")]
        public async Task RemoveIncidentLink()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var removedLink = await simsHost.Incidents.Links.Remove(1, 6);
                Assert.True(removedLink.From == 1 && removedLink.To == 6);
            }
        }


        [Fact(DisplayName ="Signals - Add Link")]
        public async Task AddSignalLink()
        {
            var hostId = 1;
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                // This returns added links
                var addedLinks = (await simsHost.Signals.Links.Add(hostId, new int[] { 6, 100, 200 }, "Signals A bonus")).ToList();
                var allLinksSet = await simsHost.Signals.Links.GetForHost(hostId);
                Assert.True(allLinksSet.Count() == 3);
            }
        }
    }
}
