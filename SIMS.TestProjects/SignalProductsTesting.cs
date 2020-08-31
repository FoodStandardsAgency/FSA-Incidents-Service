using AutoMapper;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Repositories;
using SIMS.TestProjects.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace SIMS.Database
{
    public class SignalProductsTesting
    {
        private string userId = "";
        private string anotherId = "";
        private string userId3 = "";
        private string miller = "";
        private IMapper mapper;
        private string conn;
        public SignalProductsTesting()
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
        public async Task AddProductNoCollections()
        {
            var newName = "Product no collections";
            var product = new SimsProduct
            {
                Name = newName,
                BatchCodes = "BC1234 BC59867",
                Brand = "New Brand",
                HostId = 21,
                CountryOfOriginId = 103,
                Amount = "7",
                ProductTypeId = 2,
                AmountUnitTypeId = 1,
                AdditionalInfo = "Signal Data",
                PackDescription = "This is descirption",
            };
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = new SimsDbHost(ctx, this.mapper, this.userId);
                var updatedProduct = await simsHost.Signals.Products.Add(product.HostId, product);
                Assert.True(updatedProduct.Name == newName);
            }


        }

        [Fact]
        public async Task GetDisplayProduct()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = new SimsDbHost(ctx, this.mapper, this.userId);
                var prodDisplay = await simsHost.Signals.Products.Get(1);
                Assert.True(String.IsNullOrEmpty(prodDisplay.Amount) != false);
            }
        }

        [Fact]
        public async Task AddProductPackDates()
        {
            var product = new SimsProduct
            {
                Name = "Product PackDates no sizes with dates",
                BatchCodes = "BC1234 BC59867",
                Brand = "New Brand",
                HostId = 21,
                CountryOfOriginId = 103,
                Amount = "7",
                ProductTypeId = 2,
                AmountUnitTypeId = 1,
                AdditionalInfo = "More Data needed",
                PackDescription = "This is description",
                ProductDates = new List<SimsProductDate>() {
                        new SimsProductDate { Date = DateTime.Now, DateTypeId = 2 },
                        new SimsProductDate { Date = DateTime.Now, DateTypeId = 3 }
                    }
            };

            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = new SimsDbHost(ctx, this.mapper, this.userId);
                var updatedProduct = await simsHost.Signals.Products.Add(product.HostId, product);
                Assert.True(updatedProduct.ProductDates.Count() > 0);
            }
        }

        [Fact]
        public async Task AddProductPackSizesDefaultAmount()
        {
            var product = new SimsProduct
            {
                Name = "Product Pack Sizes no dates with sizes",
                BatchCodes = "BC New packers BNA2324",
                Brand = "A Brand",
                HostId = 17,
                CountryOfOriginId = 47,
                ProductTypeId = 2,
                Amount = "0.0",
                AmountUnitTypeId = 3,
                AdditionalInfo = "More Data needed",
                PackDescription = "This is description",
                PackSizes = new List<SimsProductPackSize>
                {
                    new SimsProductPackSize{ Size ="7", UnitId=2 },
                    new SimsProductPackSize{ Size ="18.8", UnitId=2 },
                }
            };

            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = new SimsDbHost(ctx, this.mapper, this.userId);
                var updatedProduct = await simsHost.Signals.Products.Add(product.HostId, product);
                Assert.True(updatedProduct.PackSizes.Count() == 2 && updatedProduct.Amount == "0.0");
            }

        }

        [Fact]
        public async Task UpdateProduct()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = new SimsDbHost(ctx, this.mapper, this.userId);
                var product = await simsHost.Signals.Products.Get(1);
                product.Name = "Updated Producted";
                var pDates = product.ProductDates.ToList();
                pDates.Add(new SimsProductDate { Date = DateTime.Parse("30/09/1978").ToUniversalTime(), DateTypeId = 2, });
                product.ProductDates = pDates;
                // product this is annoying
                var updatedProduct = await simsHost.Signals.Products.Update(product);
                var date = updatedProduct.ProductDates.FirstOrDefault(o => o.Date.Equals(DateTime.Parse("30/09/1978").ToUniversalTime()));
                Assert.True(updatedProduct.Name == "Updated Producted" && date != null);
            }
        }

        [Fact]
        public async Task GetProductAddresses()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = new SimsDbHost(ctx, this.mapper, this.userId);
                var addresses = await simsHost.Signals.Products.Fbos.GetAddresses(1);
            }
        }


    }
}
