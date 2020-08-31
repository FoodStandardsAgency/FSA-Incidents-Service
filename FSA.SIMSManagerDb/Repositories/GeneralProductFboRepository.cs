using AutoMapper;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities.Core.Product;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    class GeneralProductFboRepository<ProductFBO> : IDbProductFboRepository where ProductFBO : CoreProductFboDb, new()
    {
        private readonly SimsDbContext ctx;
        private readonly DbSet<ProductFBO> DbSet;
        private readonly IMapper mapper;

        public GeneralProductFboRepository(SimsDbContext ctx, IMapper mapper)
        {
            this.ctx = ctx;
            this.DbSet = ctx.Set<ProductFBO>();
            this.mapper = mapper;
        }

        public async Task AssignFbo(int productId, int addressId, FboTypes types)
        {

            //if (productId == 0) throw new SIMSException("Product Id missing");
            //if (addressId == 0) throw new SIMSException("Address Id missing");
            //// need to check to see if the incident has already been closed.
            //if (IsProductIncidentClosed(productId)) throw new IncidentClosedException("This incident is closed.");

            this.DbSet.Add(new ProductFBO
            {
                FboTypes = types,
                AddressId = addressId,
                ProductId = productId
            });
            await ctx.SaveChangesAsync();

        }

        public async Task UpdateFbo(int productId, int addressId, FboTypes fboTypes)
        {
            //if (productId == 0) throw new SIMSException("Product Id missing");
            //if (addressId == 0) throw new SIMSException("Address Id missing");
            ////if ((int)fboTypes == 0) throw new SIMSException("No Fbo types selected");

            //// need to check to see if the incident has already been closed.
            //if (IsProductIncidentClosed(productId)) throw new IncidentClosedException("This incident is closed.");

            var addressInfo = this.DbSet.Find(productId, addressId);

            if (addressInfo != null)
            {
                addressInfo.FboTypes = fboTypes;
                await this.ctx.SaveChangesAsync();
            }
            //else
            //{
            //    throw new SIMSException("Product Fbo Address not found");
            //}

        }

        public async Task RemoveFbo(int productId, int addressId)
        {
            //if (productId == 0) throw new SIMSException("Product Id missing");
            //if (addressId == 0) throw new SIMSException("Address Id missing");
            //if (IsProductIncidentClosed(productId)) throw new IncidentClosedException("Incident is closed");

            var item = this.DbSet.Find(productId, addressId);
            this.DbSet.Remove(item);
            await ctx.SaveChangesAsync();
        }

        public async Task<List<SimsProductFboAddress>> GetProductAddresses(int productId)
        {
            var productDbItems = this.DbSet.AsNoTracking()
                                    .Include(o => o.Address)
                                    .ThenInclude(o => o.Contacts)
                                    .Where(p => p.ProductId == productId).ToList();


            //  var organisations = fboData.Select(o => o.FBO.Organisation);
            return mapper.Map<List<ProductFBO>, IEnumerable<SimsProductFboAddress>>(productDbItems).ToList();
        }

    }
}
