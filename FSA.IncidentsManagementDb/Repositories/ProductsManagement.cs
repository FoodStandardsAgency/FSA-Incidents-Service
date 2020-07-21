using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Threading.Tasks;

namespace FSA.IncidentsManagementDb.Repositories
{
    internal class ProductsManagement : IProductsManagement
    {
        private readonly FSADbContext ctx;

        public ProductsManagement(FSADbContext ctx)
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

        public async Task<ProductDisplayModel> Get(int productId)
        {
            var productDb = await this.ctx.Products.AsNoTracking()
                              .Include(o => o.ProductDates)
                              .Include(o => o.ProductType)
                              .Include(o => o.Incident).ThenInclude(o => o.DataSource)
                              .Include(o => o.AmountUnitType)
                              .Include(o => o.PackSizes)
                              .Include(o => o.RelatedFBOs)
                              //.ThenInclude(o => o.FBO).ThenInclude(o => o.Organisation)
                              .FirstOrDefaultAsync(p => p.Id == productId);

            return productDb.ToClientDisplay();
        }

        public async Task<IEnumerable<FboAddress>> GetProductAddresses(int productId)
        {
            var productDb = await ctx.Products.AsNoTracking()
                                    .Include(o => o.RelatedFBOs)
                                    .ThenInclude(o => o.FBO)
                                    .ThenInclude(o => o.Organisation)
                                    .FirstAsync(p => p.Id == productId);

            var fboData = productDb.RelatedFBOs.ToList();
            //  var organisations = fboData.Select(o => o.FBO.Organisation);
            return fboData.Select(o => o.FBO.ToClient());
        }

        public async Task<ProductDetail> GetProductDetail(int productId)
        {
            var productDb = await ctx.Products.AsNoTracking()
                                   .Include(o => o.ProductDates)
                                   .Include(o => o.ProductType)
                                   .Include(o => o.PackSizes)
                                   .FirstAsync(p => p.Id == productId);

            return productDb.ToDetail();
        }

        public async Task<IEnumerable<Product>> IncidentProducts(int incidentId)
        {
            var items = this.ctx.Products.AsNoTracking()
                   .Include(o => o.ProductDates)
                   .Include(o => o.ProductType)
                   .Include(o => o.AmountUnitType)
                   .Include(o => o.PackSizes)
                   .Include(o => o.RelatedFBOs)
                   .ThenInclude(o => o.FBO).ThenInclude(o => o.Organisation)
                    .Where(p => p.IncidentId == incidentId);
            var allProducts = await items.Select(o => o.ToClient()).ToListAsync();
            return allProducts.ToList();
        }

        public async Task<Product> Update(Product product)
        {
            // ensure we can update the incident.
            // need to check to see if the incident has already been closed.
            var isClosed = ctx.Products.AsNoTracking()
                    .Include(o => o.Incident)
                    .Single(p => p.Id == product.Id).Incident.IncidentClosed != null;
            if (!isClosed)
            {
                var productDb = ctx.Products
                        .Include(o => o.ProductDates)
                        .Include(o => o.ProductType)
                        .Include(o => o.PackSizes)
                        .First(p => p.Id == product.Id);
                product.ToUpdateDb(productDb);
                ctx.Products.Update(productDb);
                await ctx.SaveChangesAsync();
                return productDb.ToClient();
            }
            else
            {
                throw new ArgumentOutOfRangeException("This incident is closed.");
            }

        }

        public async Task<IPaging<ProductDashboard>> DashboardItems(int incidentId, int pageSize = 10, int startPage = 1)
        {
            if (pageSize < 1 || startPage < 1) return new PagedResult<ProductDashboard>(Enumerable.Empty<ProductDashboard>(), 0);

            var startRecord = pageSize * (startPage - 1);

            var totalRecords = ctx.Products.AsNoTracking()
                    .Include(o => o.RelatedFBOs).ThenInclude(o => o.FBO).ThenInclude(o => o.Organisation)
                    .Include(o => o.ProductType).Where(o => o.IncidentId == incidentId).Count();

            var items = await ctx.Products.AsNoTracking()
                    .Include(o => o.RelatedFBOs).ThenInclude(o => o.FBO).ThenInclude(o => o.Organisation)
                    .Include(o => o.ProductType).Where(o => o.IncidentId == incidentId)
                    .Skip(startRecord).Take(pageSize).ToListAsync();

            return new PagedResult<ProductDashboard>(items.ToDashboard(), totalRecords);
        }

        public async Task AssignFbo(int productId, int FboId)
        {
            // need to check to see if the incident has already been closed.
            var isClosed = ctx.Products.AsNoTracking()
                    .Include(o => o.Incident)
                    .Single(p => p.Id == productId).Incident.IncidentClosed != null;

            if (!isClosed)
            {
                ctx.ProductFBOItems.Add(new Entities.ProductFBODb
                {
                    FBOId = FboId,
                    ProductId = productId
                });
                await ctx.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentOutOfRangeException("This incident is closed.");
            }
        }

        public async Task RemoveFbo(int productId, int fboId)
        {
            var item = ctx.ProductFBOItems.Find(productId, fboId);
            ctx.ProductFBOItems.Remove(item);
            await ctx.SaveChangesAsync();
        }
    }
}