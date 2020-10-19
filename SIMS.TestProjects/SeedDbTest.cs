using SIMS.TestProjects.Setup;
using Xunit;

namespace SIMS.TestProjects
{
    public class SeedDbTest : IClassFixture<DbSimsContextFixture>
    {
        public SeedDbTest(DbSimsContextFixture fixture)
        {
            this.Fixture = fixture;
        }

        public DbSimsContextFixture Fixture { get; }

        [Fact]
        public void LoadData()
        {
            Assert.True(true);
        }
    }
}
