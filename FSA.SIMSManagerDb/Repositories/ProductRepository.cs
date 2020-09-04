using AutoMapper;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities;
using FSA.SIMSManagerDb.Entities.Core.Product;
using FSA.SIMSManagerDb.Entities.Lookups;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    class ProductRepository<T, FBO, Pack, Date> : IDbProductRepository where T : CoreProductDb, ICoreProduct<FBO, Pack, Date>
                            where FBO : CoreProductFboDb, new()
                            where Date : CoreProductDateDb
    {
        private readonly SimsDbContext ctx;
        private readonly DbSet<T> DbSet;

        public DbSet<Date> DbSetDates { get; }

        public IDbProductFboRepository Fbos => new ProductFboRepository<FBO>(ctx, mapper);

        private readonly IMapper mapper;

        public ProductRepository(SimsDbContext ctx, IMapper mapper)
        {
            this.ctx = ctx;
            this.DbSet = ctx.Set<T>();
            this.DbSetDates = ctx.Set<Date>();
            this.mapper = mapper;
        }

        public async Task<SimsProduct> Add(int HostId, SimsProduct newProduct)
        {
            if (HostId == 0) throw new ArgumentOutOfRangeException("No host selected.");
            var dbItem = mapper.Map<SimsProduct, T>(newProduct);
            dbItem.HostId = HostId;
            var dbCreated = DbSet.Add(dbItem);
            await ctx.SaveChangesAsync();
            return mapper.Map<T, SimsProduct>(dbCreated.Entity);
        }

        public async Task<SimsProduct> Update(SimsProduct product)
        {
            var productDb = this.DbSet
                        .Include(o => o.ProductType)
                        .Include(o => o.PackSizes)
                        .First(p => p.Id == product.Id);

            var pDates = this.DbSetDates.Where(i => i.ProductId == product.Id).ToList();

            mapper.Map(product, productDb);

            var updatedEnt = this.DbSet.Update(productDb);
            await ctx.SaveChangesAsync();
            return mapper.Map<T, SimsProduct>(updatedEnt.Entity);
        }

        /// <summary>
        /// Don't forget DataSource
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public async Task<SimsProductDisplayModel> Get(int productId)
        {
            var productDb = await this.DbSet.AsNoTracking()
                              .Include(o => o.ProductDates)
                              .Include(o => o.ProductType)
                              //.Include(o => o.Host).ThenInclude(o => o.DataSource)
                              .Include(o => o.AmountUnitType)
                              .Include(o => o.PackSizes)
                              .Include(o => o.RelatedFBOs)
                              //.ThenInclude(o => o.FBO).ThenInclude(o => o.Organisation)
                              .FirstOrDefaultAsync(p => p.Id == productId);

            return mapper.Map<T, SimsProductDisplayModel>(productDb);
        }

        public async Task<SimsProductDetail> GetDetail(int productId)
        {
            var productDb = await this.DbSet.AsNoTracking()
                                   .Include(o => o.ProductDates)
                                   .Include(o => o.ProductType)
                                   .Include(o => o.PackSizes)
                                   .FirstAsync(p => p.Id == productId);

            return mapper.Map<T, SimsProductDetail>(productDb);
        }

        public async Task<IEnumerable<SimsProduct>> HostProducts(int hostId)
        {
            var items = this.DbSet.AsNoTracking()
                   .Include(o => o.ProductDates)
                   .Include(o => o.ProductType)
                   .Include(o => o.AmountUnitType)
                   .Include(o => o.PackSizes)
                   .Where(p => p.HostId == hostId);
            var allProducts = await items.Select(o => mapper.Map<T, SimsProduct>(o)).ToListAsync();
            return allProducts.ToList();
        }

        public async Task<IPaging<SimsProductDashboard>> DashboardItems(int hostId, int pageSize = 10, int startPage = 1)
        {
            if (pageSize < 1 || startPage < 1) return new PagedResult<SimsProductDashboard>(Enumerable.Empty<SimsProductDashboard>(), 0);

            var startRecord = pageSize * (startPage - 1);

            var totalRecords = this.DbSet.AsNoTracking()
                    .Include(o => o.RelatedFBOs).ThenInclude(o => o.Address)
                    .Include(o => o.ProductType).Where(o => o.HostId == hostId).Count();

            var items = await this.DbSet.AsNoTracking()
                    .Include(o => o.RelatedFBOs).ThenInclude(o => o.Address)
                    .Include(o => o.ProductType).Where(o => o.HostId == hostId)
                    .Skip(startRecord).Take(pageSize).ToListAsync();

            return new PagedResult<SimsProductDashboard>(mapper.Map<IEnumerable<T>, IEnumerable<SimsProductDashboard>>(items), totalRecords);
        }

    }
}
