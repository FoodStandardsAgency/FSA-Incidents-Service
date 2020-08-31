using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using FSA.IncidentsManagementDb.Entities.Helpers;
using FSA.IncidentsManagementDb.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.InteropServices;
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
            if (incidentId == 0) throw new IncidentMissingException("No incident provided.");
            if (newProduct.Id != 0) throw new ProductExistsException("This product appears to already exist.");

            if (this.IsIncidentClosed(incidentId)) { throw new IncidentClosedException("Incident is closed"); }

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

        public async Task<IEnumerable<ProductFboAddress>> GetProductAddresses(int productId)
        {
            var productDb = await ctx.Products.AsNoTracking()
                                    .Include(o => o.RelatedFBOs)
                                    .ThenInclude(o => o.Address).ThenInclude(o => o.Contacts)
                                    .FirstAsync(p => p.Id == productId);

            var fboData = productDb.RelatedFBOs.ToList();
            //  var organisations = fboData.Select(o => o.FBO.Organisation);
            return fboData.ToClient().ToList();
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
                   .ThenInclude(o => o.Address)
                    .Where(p => p.IncidentId == incidentId);
            var allProducts = await items.Select(o => o.ToClient()).ToListAsync();
            return allProducts.ToList();
        }

        public async Task<Product> Update(Product product)
        {
            // ensure we can update the incident.
            // need to check to see if the incident has already been closed.
            var isClosed = IsIncidentClosed(product.HostId);
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
                throw new IncidentClosedException("This incident is closed.");
            }

        }

        public async Task<IPaging<ProductDashboard>> DashboardItems(int incidentId, int pageSize = 10, int startPage = 1)
        {
            if (pageSize < 1 || startPage < 1) return new PagedResult<ProductDashboard>(Enumerable.Empty<ProductDashboard>(), 0);

            var startRecord = pageSize * (startPage - 1);

            var totalRecords = ctx.Products.AsNoTracking()
                    .Include(o => o.RelatedFBOs).ThenInclude(o => o.Address)
                    .Include(o => o.ProductType).Where(o => o.IncidentId == incidentId).Count();

            var items = await ctx.Products.AsNoTracking()
                    .Include(o => o.RelatedFBOs).ThenInclude(o => o.Address)
                    .Include(o => o.ProductType).Where(o => o.IncidentId == incidentId)
                    .Skip(startRecord).Take(pageSize).ToListAsync();

            return new PagedResult<ProductDashboard>(items.ToDashboard(), totalRecords);
        }

        public async Task AssignFbo(int productId, int addressId, FboTypes types)
        {

            if (productId == 0) throw new SIMSException("Product Id missing");
            if (addressId == 0) throw new SIMSException("Address Id missing");
            // need to check to see if the incident has already been closed.
            if (IsProductIncidentClosed(productId)) throw new IncidentClosedException("This incident is closed.");

            ctx.ProductFBOItems.Add(new Entities.ProductFBODb
            {
                FboTypes = types,
                AddressId = addressId,
                ProductId = productId
            });
            await ctx.SaveChangesAsync();

        }

        public async Task UpdateFbo(int productId, int addressId, FboTypes fboTypes)
        {
            if (productId == 0) throw new SIMSException("Product Id missing");
            if (addressId == 0) throw new SIMSException("Address Id missing");
            //if ((int)fboTypes == 0) throw new SIMSException("No Fbo types selected");

            // need to check to see if the incident has already been closed.
            if (IsProductIncidentClosed(productId)) throw new IncidentClosedException("This incident is closed.");

            var addressInfo = this.ctx.ProductFBOItems.Find(productId, addressId);

            if (addressInfo != null)
            {
                addressInfo.FboTypes = fboTypes;
                await this.ctx.SaveChangesAsync();
            }
            else
            {
                throw new SIMSException("Product Fbo Address not found");
            }

        }

        public async Task RemoveFbo(int productId, int addressId)
        {
            if (productId == 0) throw new SIMSException("Product Id missing");
            if (addressId == 0) throw new SIMSException("Address Id missing");
            if (IsProductIncidentClosed(productId)) throw new IncidentClosedException("Incident is closed");

            var item = ctx.ProductFBOItems.Find(productId, addressId);
            ctx.ProductFBOItems.Remove(item);
            await ctx.SaveChangesAsync();
        }
        /// <summary>
        /// Cannot update an incident that is currently closed.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
 
        private bool IsProductIncidentClosed(int productId)
        {
            return ctx.Products.AsNoTracking()
                    .Include(o => o.Incident)
                    .Single(p => p.Id == productId)
                    .Incident.IncidentStatusId == (int)IncidentStatusTypes.Closed;
        }

        private bool IsIncidentClosed(int incidentId)
        {
            return ctx.Incidents
                      .Single(i => i.Id == incidentId)
                      .IncidentStatusId == (int)IncidentStatusTypes.Closed;
        }
    }
}