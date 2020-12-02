using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Shared;
using FSA.SIMSManagerDb.Contracts;
using Sims.Application.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class OnlineFormProducts : ISIMSProducts
    {
        private ISimsDbHost dbHost;

        public OnlineFormProducts(ISimsDbHost dbHost)
        {
            this.dbHost = dbHost;
        }

        public async Task<SimsProduct> Add(int hostId, SimsProduct newSimsProduct)
        {
                return await dbHost.OnlineForms.Products.Add(hostId, newSimsProduct);
        }

        public async Task<SimsProductDisplayModel> Get(int productId)
        {
            var productDispModel = await dbHost.OnlineForms.Products.Get(productId);
            var OnlineForm = await this.dbHost.OnlineForms.Get(productDispModel.HostId);
            productDispModel.DataSourceId = -1;
            /// YEEEEUUUUUUCK!
            return productDispModel;
        }


        public async Task<SimsProduct> Update(SimsProduct product)
        {
            if (product.Id == 0) throw new SimsItemMissing("Missing id");
            var appProduct = await dbHost.OnlineForms.Products.Get(product.Id);
            if (!await dbHost.OnlineForms.IsClosed((int)appProduct.HostId))
                return await dbHost.OnlineForms.Products.Update((SimsProduct)product);
            else
                throw new SimsOnlineFormClosedException("OnlineForm closed");
        }

        public async Task AssignFbo(int productId, int addressId, SimsFboTypes types)
        {
            if (productId == 0) throw new SimsItemMissing("Product Id missing");
            if (addressId == 0) throw new SimsItemMissing("Address Id missing");

            if (!await dbHost.OnlineForms.IsClosed(productId))
                await dbHost.OnlineForms.Products.Fbos.Add(productId, addressId, (int)types);
            else
                throw new SimsIncidentClosedException("OnlineForm  closed");
        }

        public Task<IPaging<SimsProductDashboard>> DashboardItems(int hostId, int pageSize = 10, int startPage = 1)
        {
            if (hostId == 0) throw new SimsItemMissing("No Host id present.");
            return dbHost.OnlineForms.Products.DashboardItems(hostId, pageSize, startPage);
        }


        public Task<IEnumerable<SimsProductFboAddress>> GetAddress(int productId)
        {
            if (productId == 0) throw new SimsItemMissing("No product id present.");
            return dbHost.OnlineForms.Products.Fbos.GetAddresses(productId);
        }

        public Task<IEnumerable<SimsProduct>> GetAll(int hostId)
        {
            return dbHost.OnlineForms.Products.HostProducts(hostId);
        }

        public async Task RemoveFbo(int productId, int addressId)
        {
            var product = await dbHost.OnlineForms.Products.Get(productId);
            if (!await dbHost.OnlineForms.IsClosed(product.HostId))
                await dbHost.OnlineForms.Products.Fbos.Remove(productId, addressId);
            else
                throw new SimsOnlineFormClosedException("OnlineForm closed");
        }

        public async Task UpdateFbo(int productId, int addressId, SimsFboTypes fboTypes)
        {
            if (productId == 0) throw new SimsItemMissing("Missing id");
            var product = await dbHost.OnlineForms.Products.Get(productId);
            if (!await dbHost.OnlineForms.IsClosed(product.HostId))
                await dbHost.OnlineForms.Products.Fbos.Update(productId, addressId, (int)fboTypes);
            else
                throw new SimsOnlineFormClosedException("OnlineForm closed");
        }
    }
}