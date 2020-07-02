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
    internal class ProductsManagement : CoreRepositoryActions, IProductsManagement
    {
        public ProductsManagement(FSADbContext ctx, string editor) : base(ctx, editor)
        {
        }

        public async Task<Product> AddProduct(int incidentId, Product newProduct)
        {
            if (newProduct.Id != 0) throw new ArgumentOutOfRangeException("This product appears to already exist.");
            var dbProduct = newProduct.ToDb();
            //// Ensure we are setting Audit info
            //foreach(var paket in dbProduct.PackSizes)
            //{
            //    SetAuditInfo(paket);
            //}
            //foreach (var paket in dbProduct.ProductDates)
            //{
            //    SetAuditInfo(paket);
            //}
            

            //SetAuditInfo(dbProduct);
            ctx.Products.Add(dbProduct);
            await ctx.SaveChangesAsync();
            return dbProduct.ToClient();
        }

        public async Task<ProductDetail> GetProductDetail(int productId)
        {
            var productDb = await ctx.Products
                                   .Include(o => o.ProductDates)
                                   .Include(o => o.ProductType)
                                   .Include(o=>o.PackSizes)
                                   .FirstAsync(p => p.Id == productId);

            return productDb.ToDetail();
        }

        public async Task<IEnumerable<Product>> AllProducts(int incidentId)
        {
            this.ctx.Products
                   .Include(o => o.ProductDates)
                   .Include(o => o.ProductType)
                   .Include(o => o.AmountUnitType)
                   .Include(o => o.PackSizes)
                   .Include(o => o.PackDescription)
                   .Include(o => o.RelatedFBOs).ThenInclude(o => o.FBO).ThenInclude(o => o.Organisation);

            return Enumerable.Empty<Product>();
        }

        public Task<Product> UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }


    }
}