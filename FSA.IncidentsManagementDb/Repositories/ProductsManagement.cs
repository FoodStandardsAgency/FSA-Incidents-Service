using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FSA.IncidentsManagementDb.Repositories
{
    internal class ProductsManagement : IProductsManagement
    {
        private FSADbContext ctx;

        public ProductsManagement(FSADbContext ctx, string editor)
        {
            this.ctx = ctx;
        }

        public async Task<Product> Add(int incidentId, Product newProduct)
        {
            if (incidentId == 0) throw new ArgumentNullException("No incident provided.");
            if (newProduct.Id != 0) throw new ArgumentOutOfRangeException("This product appears to already exist.");
            var dbProduct = newProduct.ToDb();
            dbProduct.IncidentId = incidentId;
           
            ctx.Products.Add(dbProduct);
            await ctx.SaveChangesAsync();
            return dbProduct.ToClient();
        }

        public  async Task<Product> Get(int productId)
        {
            var productDb = await ctx.Products.AsNoTracking()
                       .Include(o => o.ProductDates)
                       .Include(o => o.ProductType)
                       .Include(o => o.PackSizes)
                       .FirstAsync(p => p.Id == productId);

            return productDb.ToClient();
        }

        public async Task<ProductDetail> GetProductDetail(int productId)
        {
            var productDb = await ctx.Products.AsNoTracking()
                                   .Include(o => o.ProductDates)
                                   .Include(o => o.ProductType)
                                   .Include(o=>o.PackSizes)
                                   .FirstAsync(p => p.Id == productId);

            return productDb.ToDetail();
        }

        public async Task<IEnumerable<Product>> AllProducts(int incidentId)
        {
            var items = this.ctx.Products.AsNoTracking()
                   .Include(o => o.ProductDates)
                   .Include(o => o.ProductType)
                   .Include(o => o.AmountUnitType)
                   .Include(o => o.PackSizes)
                   .Include(o => o.PackDescription)
                   .Include(o => o.RelatedFBOs)
                   .ThenInclude(o => o.FBO).ThenInclude(o => o.Organisation)
                    .Where(p => p.IncidentId == incidentId);
            var allProducts = items.Select(o => o.ToClient());
            return allProducts.ToList();
        }

        public async Task<Product> Update(Product product)
        {
            var productDb = ctx.Products
                .Include(o => o.ProductDates)
                .Include(o => o.ProductType)
                .Include(o => o.PackSizes)
                .First(p=>p.Id==product.Id);

            product.ToUpdateDb(productDb);
            ctx.Products.Update(productDb);
            await ctx.SaveChangesAsync();
            return productDb.ToClient();
        }


    }
}