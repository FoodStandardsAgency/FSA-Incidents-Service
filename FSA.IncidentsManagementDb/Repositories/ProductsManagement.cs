using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
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
            ctx.Products.Add(dbProduct);

            await ctx.SaveChangesAsync();

            return dbProduct.ToClient();
        }

        public Task<IEnumerable<Product>> AllProducts(int incidentId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}