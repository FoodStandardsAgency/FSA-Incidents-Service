using _UnitTests;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb;
using FSA.IncidentsManagementDb.Repositories;
using FSA.UnitTests.Misc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace FSA.UnitTests.Db
{
    public class DbAddress
    {
        private string userId = "";
        private string anotherId = "";
        private string userId3 = "";
        private string miller = "";

        private ConfigFile Config { get; }

        private FSADbContext ctx;
        private SIMSDataManager simsData;
        public DbAddress()
        {
            var seedIn = new SeedIncidents();

            userId = seedIn.userIds[0];
            anotherId = seedIn.userIds[1];
            userId3 = seedIn.userIds[2];
            miller = seedIn.userIds[3];

            this.Config = System.Text.Json.JsonSerializer.Deserialize<ConfigFile>(System.IO.File.OpenText("./config.json").ReadToEnd());
            ctx = new FSADbContext(new DbContextOptionsBuilder().UseSqlServer(Config.dbConn).Options);
            simsData = new SIMSDataManager(ctx, userId);
        }

        [Fact]
        public async Task AddAddress()
        {
            var org = new Address
            {
                Title = "Test - New orgnaisations",
                //MainContact = "New-Org Smity",
                AddressLine1 = "Address line 1",
                AddressLine2 = "Address line 2",
                PostCode = "Test post",
                TownCity = "Test Town City",
                CountryId = 201,
                County = "Country",
                TelephoneNumber = "01234567890",
                Contacts = new List<AddressContact> { new AddressContact { EmailAddress = "email@address", TelephoneNumber ="01234567890", Name="New-Org Smity", IsMain=true }  }
            };
            await simsData.Addresses.Add(org);
        }


        [Fact]
        public async Task FindAddress()
        {
            var results = await simsData.Addresses.FindAddress("black");
            Assert.True(results.ToList().Count > 0);
        }
 
    }
}
