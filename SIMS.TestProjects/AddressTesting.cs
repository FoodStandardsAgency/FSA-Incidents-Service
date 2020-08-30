using AutoMapper;
using AutoMapper.Configuration;
using FSA.IncidentsManagement.Root.Models;
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
    public class AddressTesting
    {
        private string userId = "";
        private string anotherId = "";
        private string userId3 = "";
        private string miller = "";
        private IMapper mapper;
        private string conn;

        public AddressTesting()
        {

            var seedInfo = new SeedingConfigData();

            userId = seedInfo.userIds[0];
            anotherId = seedInfo.userIds[1];
            userId3 = seedInfo.userIds[2];
            miller = seedInfo.userIds[3];
            var config = seedInfo.GetConfigData();
            this.mapper = seedInfo.GetDbAutoMapper();
            this.conn = ((JsonElement)config["ConnectionStrings:FSADbConn"]).ToString();
        }

        [Fact]
        public async Task AddAddress()
        {
            var testTitle = "Test - New orgnaisations";
            var org = new SimsAddress
            {
                Title = testTitle,
                //MainContact = "New-Org Smity",
                AddressLine1 = "Address line 1",
                AddressLine2 = "Address line 2",
                PostCode = "Test post",
                TownCity = "Test Town City",
                CountryId = 201,
                County = "Country",
                TelephoneNumber = "01234567890",
                Contacts = new List<SimsAddressContact> { new SimsAddressContact { EmailAddress = "email@address", TelephoneNumber = "01234567890", Name = "New-Org Smity", IsMain = true } }
            };

            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = new SimsDbHost(ctx, this.mapper, this.userId);
                var savedAddress = await simsHost.Addresses.Add(org);
                Assert.True(savedAddress.Title == testTitle);
            }

        }


        [Fact]
        public async Task FindAddress()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = new SimsDbHost(ctx, this.mapper, this.userId);
                var results = await simsHost.Addresses.FindAddress("black");
                Assert.True(results.ToList().Count > 0);
            }
        }

    }
}
