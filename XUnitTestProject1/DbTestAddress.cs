using _UnitTests;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb;
using FSA.IncidentsManagementDb.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FSA.UnitTests.Db
{
    public class DbTestAddress
    {
        private string userId = "2f65582c-5970-4848-9020-d65b6df2dc04";
        private string anotherId = "9a8dda39-78ec-496d-8625-f8b24d83aa57";
        private string userId3 = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"; // FSA.Test
        private string miller = "8cc321a9-fea4-4689-a127-c5e141e2810c";

        private ConfigFile Config { get; }

        private FSADbContext dbContext;
        private SIMSDataManager incidentsManagment;
        public DbTestAddress()
        {
            this.Config = System.Text.Json.JsonSerializer.Deserialize<ConfigFile>(File.OpenText("./config.json").ReadToEnd());
            dbContext = new FSADbContext(new DbContextOptionsBuilder().UseSqlServer(Config.dbConn).Options);
            incidentsManagment = new SIMSDataManager(dbContext, userId);
        }

        [Fact]
        public async Task AddFBOWithNewAddress()
        {
            var orga = new OrganisationAddress
            {
                EmailAddress = "Terry@amil.com",
                MainContact = "Terry the data",
                AddressLine1 = "Address line 1",
                AddressLine2 = "Address line 2",
                PostCode = "Postoce",
                TownCity = "Town City",
                Title = "Terrys messageing",
                CountryId = 103,
                County = "Counry",
                TelephoneNumber = ""
            };


            FboTypes d = FboTypes.Consignor | FboTypes.E_trader;
            var newaddress = await incidentsManagment.Addresses.AddFbo(d, orga);
            Assert.IsType<int>(newaddress);
        }

        [Fact]
        public async Task GetFBOAddress()
        {
            var itme = await incidentsManagment.Addresses.Get(1);

            Assert.NotNull(itme);
        }
    }
}
