using AutoMapper.Configuration;
using SIMS.TestProjects.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void CauseRuckus()
        {
            Assert.True(true);
        }
    }
}
