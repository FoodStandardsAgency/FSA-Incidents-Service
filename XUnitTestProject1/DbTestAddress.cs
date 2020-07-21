using _UnitTests;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb;
using FSA.IncidentsManagementDb.Repositories;
using FSA.UnitTests.Misc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace FSA.UnitTests.Db
{
    public class DbTestAddress
    {
        private string userId = "";
        private string anotherId = "";
        private string userId3 = "";
        private string miller = "";

        private ConfigFile Config { get; }

        private FSADbContext ctx;
        private SIMSDataManager simsData;
        public DbTestAddress()
        {
            var seedIn = new SeedIncidents();

            userId = seedIn.userIds[0];
            anotherId = seedIn.userIds[1];
            userId3 = seedIn.userIds[2];
            miller = seedIn.userIds[3];

            this.Config = System.Text.Json.JsonSerializer.Deserialize<ConfigFile>(File.OpenText("./config.json").ReadToEnd());
            ctx = new FSADbContext(new DbContextOptionsBuilder().UseSqlServer(Config.dbConn).Options);
            simsData = new SIMSDataManager(ctx, userId);
        }

        [Fact]
        public async Task AddFBOWithNewAddress()
        {
            var orga = new FboAddress
            {
                Title = "Testing address ",
                FboTypes = FboTypes.Consignor | FboTypes.E_trader,
                EmailAddress = "Terry@amil.com",
                MainContact = "Terry the data",
                AddressLine1 = "Address line 1",
                AddressLine2 = "Address line 2",
                PostCode = "Postoce",
                TownCity = "Town City",
                CountryId = 103,
                County = "Counry",
                TelephoneNumber = ""
            };

            var newaddress = await simsData.Addresses.AddFbo(orga);
            Assert.IsType<FboAddress>(newaddress);
        }

        [Fact]
        public async Task UpdateFbo()
        {
            var address = await simsData.Addresses.GetFbo(3);
            address.EmailAddress = "Updated@email.com";
            address.FboTypes = FboTypes.Consignor;
            var item  = await simsData.Addresses.UpdateFbo(address);
            Assert.True(item.EmailAddress == "Updated@email.com" && item.FboTypes == FboTypes.Consignor);
        }

        [Fact]
        public async Task AssignFbo()
        {
            var address = await simsData.Addresses.Get(22);
            var fbo = FboTypes.Importer | FboTypes.Supplier | FboTypes.Trader_Broker;
            var fboId = await simsData.Addresses.AssignFbo(fbo, address.Id);
            var fboAdd = await simsData.Addresses.GetFbo(fboId);
            Assert.True(fboAdd.FboTypes == fbo);
        }

        [Fact]
        public async Task GetFBOAddress()
        {
            var itme = await simsData.Addresses.Get(1);

            Assert.NotNull(itme);
        }

        [Fact]
        public async Task SearchFBOAddress()
        {
            var addr = await simsData.Addresses.FindFbo("Council");
            // None (No councils in test Data)
            Assert.True(addr.ToList().Count == 0);
            // Many
            addr = await simsData.Addresses.FindFbo("PostCode");
            Assert.True(addr.ToList().Count > 1);
            // one post code match
            addr = await simsData.Addresses.FindFbo("P1 C10DE");
            Assert.True(addr.ToList().Count == 1);
        }
    }
}
