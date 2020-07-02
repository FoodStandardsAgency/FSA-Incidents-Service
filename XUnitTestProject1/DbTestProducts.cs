using _UnitTests;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb;
using FSA.IncidentsManagementDb.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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
                BatchCodes = "BC1234 BC59867",
                Brand = "New Brand",
                IncidentId = 21,
                CountryOfOriginId = 103,
                Amount = "7",
                ProductTypeId = 2,
                AmountUnitTypeId = 1,
                AdditionalInfo = "More Data needed",
                Name = "Product no collections",
                PackDescription = "This is descirption",
            };

            IFSAIncidentsData fsaData = new FSAIncidentsManagement(this.dbContext, userId3);
            var updatedProduct = await fsaData.Products.AddProduct(product.IncidentId, product);
        }

        [Fact]
        public async Task AddProductPackDates()
        {
            var product = new Product
            {
                BatchCodes = "BC1234 BC59867",
                Brand = "New Brand",
                IncidentId = 21,
                CountryOfOriginId = 103,
                Amount = "7",
                ProductTypeId = 2,
                AmountUnitTypeId = 1,
                AdditionalInfo = "More Data needed",
                Name = "Product no collections",
                PackDescription = "This is description",
                ProductDates = new List<ProductDate>() { 
                        new ProductDate { Date = DateTime.Now, DateTypeId = 2 },
                        new ProductDate { Date = DateTime.Now, DateTypeId = 3 }
                    }
            };

            IFSAIncidentsData fsaData = new FSAIncidentsManagement(this.dbContext, userId3);
            var updatedProduct = await fsaData.Products.AddProduct(product.IncidentId, product);
        }

        [Fact]
        public async Task AddProductPackSizesDefaultAmount()
        {
            var product = new Product
            {
                BatchCodes = "BC New packers BNA2324",
                Brand = "A Brand",
                IncidentId = 17,
                CountryOfOriginId = 89,
                ProductTypeId = 2,
                Amount="0.0",
                AmountUnitTypeId = 1,
                AdditionalInfo = "More Data needed",
                Name = "Product no collections",
                PackDescription = "This is description",
                PackSizes = new List<ProductPackSize>
                {
                    new ProductPackSize{ Size ="7", UnitId=2 },
                    new ProductPackSize{ Size ="18.8", UnitId=2 },
                }
            };

            IFSAIncidentsData fsaData = new FSAIncidentsManagement(this.dbContext, userId3);
            var updatedProduct = await fsaData.Products.AddProduct(product.IncidentId, product);
            Assert.True(updatedProduct.PackSizes.Count() == 2 && updatedProduct.Amount == "0.0");
        }
    }
}
