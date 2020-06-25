using _UnitTests;
using FSA.IncidentsManagementDb;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FSA.UnitTests.WebApi
{
   public class DbTestIncidents : IDisposable
    {
        private string userId = "2f65582c-5970-4848-9020-d65b6df2dc04";
        private string anotherId = "9a8dda39-78ec-496d-8625-f8b24d83aa57";
        private string userId3 = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"; // FSA.Test
        private string miller = "8cc321a9-fea4-4689-a127-c5e141e2810c";

        private ConfigFile Config { get; }

        private FSADbContext dbContext;

        public DbTestIncidents()
        {
            this.Config = System.Text.Json.JsonSerializer.Deserialize<ConfigFile>(File.OpenText("./config.json").ReadToEnd());

            dbContext = new FSADbContext(new DbContextOptionsBuilder().UseSqlServer(Config.dbConn).Options);
        }

        [Fact]
        public async Task AddIncidentNoLeadOfficer()
        {

        }

        [Fact]
        public async Task AddIncidentLeadOfficer()
        {

        }

        [Fact]
        public async Task AddIncidents()
        {

        }


        public void Dispose()
        {
            if(dbContext!=null)
                dbContext.Dispose();
        }
    }
}
