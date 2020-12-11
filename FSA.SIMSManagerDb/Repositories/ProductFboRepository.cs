using AutoMapper;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities.Core;
using FSA.SIMSManagerDbEntities.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
   internal class ProductFboRepository<ProductFBO> : IDbProductFboRepository where ProductFBO : BaseProductFboDb, new()
    {
        private readonly SimsDbContext ctx;
        private readonly DbSet<ProductFBO> DbSet;
        private readonly IMapper mapper;

        private ImmutableDictionary<int, string> typeList; 

        public ProductFboRepository(SimsDbContext ctx, IMapper mapper)
        {
            this.ctx = ctx;
            this.DbSet = ctx.Set<ProductFBO>();
            this.mapper = mapper;
        }

        public async Task Add(int productId, int addressId, int types)
        {

            this.DbSet.Add(new ProductFBO
            {
                FboTypes = (FboTypes)types,
                AddressId = addressId,
                ProductId = productId
            });
            await ctx.SaveChangesAsync();

        }

        public async Task Update(int productId, int addressId, int fboTypes)
        {

            var addressInfo = this.DbSet.Find(productId, addressId);

            if (addressInfo != null)
            {
                addressInfo.FboTypes = (FboTypes)fboTypes;
                await this.ctx.SaveChangesAsync();
            }

        }

        public async Task Remove(int productId, int addressId)
        {
            var item = this.DbSet.Find(productId, addressId);
            this.DbSet.Remove(item);
            await ctx.SaveChangesAsync();
        }

        public async Task<IEnumerable<SimsProductFboAddress>> GetAddresses(int productId)
        {
            var productDbItems = await this.DbSet.AsNoTracking()
                                    .Include(o => o.Address)
                                    .ThenInclude(o => o.Contacts)
                                    .Where(p => p.ProductId == productId).ToListAsync();
            return mapper.Map<List<ProductFBO>, IEnumerable<SimsProductFboAddress>>(productDbItems).ToList();
        }

        public IEnumerable<string> GetNamesFromId(IEnumerable<int> fbosTypeIds)
        {
            if(typeList  == null)
            {
                typeList = this.ctx.FBOTypes.ToImmutableDictionary(a => a.Id, a => a.Title);
            }
            return typeList.Where(a => fbosTypeIds.Any(b => a.Key == b)).Select(a => a.Value);
        }
    }
}
