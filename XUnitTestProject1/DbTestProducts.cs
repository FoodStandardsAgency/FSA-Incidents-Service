using _UnitTests;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb;
using FSA.IncidentsManagementDb.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FSA.UnitTests.Db
{
    public class DbTestProducts
    {
        private string userId = "2f65582c-5970-4848-9020-d65b6df2dc04";
        private string anotherId = "9a8dda39-78ec-496d-8625-f8b24d83aa57";
        private string userId3 = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"; // FSA.Test
        private string miller = "8cc321a9-fea4-4689-a127-c5e141e2810c";

        private ConfigFile Config { get; }

        private FSADbContext dbContext;

        public DbTestProducts()
        {
            this.Config = System.Text.Json.JsonSerializer.Deserialize<ConfigFile>(File.OpenText("./config.json").ReadToEnd());
            dbContext = new FSADbContext(new DbContextOptionsBuilder().UseSqlServer(Config.dbConn).Options);
        }

        [Fact]
        public async Task AddProductNoCollections()
        {
            var product = new Product
            {
                Name = "Product no collections",
                BatchCodes = "BC1234 BC59867",
                Brand = "New Brand",
                IncidentId = 21,
                CountryOfOriginId = 103,
                Amount = "7",
                ProductTypeId = 2,
                AmountUnitTypeId = 1,
                AdditionalInfo = "More Data needed",
                PackDescription = "This is descirption",
            };

            ISIMSManager fsaData = new SIMSDataManager(this.dbContext, userId3);
            var updatedProduct = await fsaData.Products.Add(product.IncidentId, product);
        }

        [Fact]
        public async Task AddProductPackDates()
        {
            var product = new Product
            {
                Name = "Product PackDates no sizes with dates",
                BatchCodes = "BC1234 BC59867",
                Brand = "New Brand",
                IncidentId = 21,
                CountryOfOriginId = 103,
                Amount = "7",
                ProductTypeId = 2,
                AmountUnitTypeId = 1,
                AdditionalInfo = "More Data needed",
                PackDescription = "This is description",
                ProductDates = new List<ProductDate>() { 
                        new ProductDate { Date = DateTime.Now, DateTypeId = 2 },
                        new ProductDate { Date = DateTime.Now, DateTypeId = 3 }
                    }
            };

            ISIMSManager fsaData = new SIMSDataManager(this.dbContext, userId3);
            var updatedProduct = await fsaData.Products.Add(product.IncidentId, product);
        }

        [Fact]
        public async Task AddProductPackSizesDefaultAmount()
        {
            var product = new Product
            {
                Name = "Product Pack Sizes no dates with sizes",
                BatchCodes = "BC New packers BNA2324",
                Brand = "A Brand",
                IncidentId = 17,
                CountryOfOriginId = 47,
                ProductTypeId = 2,
                Amount="0.0",
                AmountUnitTypeId = 3,
                AdditionalInfo = "More Data needed",
                PackDescription = "This is description",
                PackSizes = new List<ProductPackSize>
                {
                    new ProductPackSize{ Size ="7", UnitId=2 },
                    new ProductPackSize{ Size ="18.8", UnitId=2 },
                }
            };

            ISIMSManager fsaData = new SIMSDataManager(this.dbContext, userId3);
            var updatedProduct = await fsaData.Products.Add(product.IncidentId, product);
            Assert.True(updatedProduct.PackSizes.Count() == 2 && updatedProduct.Amount == "0.0");
        }

        [Fact]
        public async Task UpdateProduct()
        {
            ISIMSManager fsaData = new SIMSDataManager(this.dbContext, userId3);
            var product = await fsaData.Products.Get(1);
            product.Name = "Updated Producted";
            var pDates = product.ProductDates.ToList();
            pDates.Add(new ProductDate { Date = DateTime.Parse("30/09/1978").ToUniversalTime(), DateTypeId = 2, });
            product.ProductDates = pDates;
            var updatedProduct = await fsaData.Products.Update(product);
            var date = updatedProduct.ProductDates.FirstOrDefault(o => o.Date.Equals(DateTime.Parse("30/09/1978").ToUniversalTime()));
            Assert.True(updatedProduct.Name == "Updated Producted" && date != null);
        }

        [Fact]
        public async Task GetProductAddresses()
        {
            ISIMSManager fsaData = new SIMSDataManager(this.dbContext, userId3);
            var addresses = await fsaData.Products.GetProductAddresses(1); 
        }

        [Fact]
        public async Task AddressesToProduct()
        {
            ISIMSManager fsaData = new SIMSDataManager(this.dbContext, userId3);
            await fsaData.Products.AddAddress(1, 2);
            await fsaData.Products.AddAddress(1, 1);
            await fsaData.Products.AddAddress(2, 3);
            await fsaData.Products.AddAddress(3, 1);
            await fsaData.Products.AddAddress(3, 2);
            await fsaData.Products.AddAddress(3, 4);

            var p1a = (await fsaData.Products.GetProductAddresses(1)).ToList();
            var p2a = (await fsaData.Products.GetProductAddresses(2)).ToList();
            Assert.True(p1a.Count == 2 && p2a.Count ==1);
        }

        [Fact]
        public async Task DashboardItems()
        {
            ISIMSManager fsaData = new SIMSDataManager(this.dbContext, userId3);
            var rawDash = await fsaData.Products.DashboardItems(17);

        }
    }
}
