using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Shared;
using FSA.SIMSManagerDb.Contracts;
using Sims.Application.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class SignalProducts : ISIMSProducts
    {
        private ISimsDbHost dbHost;

        public SignalProducts(ISimsDbHost dbHost)
        {
            this.dbHost = dbHost;
        }

        public async Task<SimsProduct> Add(int hostId, SimsProduct newSimsProduct)
        {
            if (hostId == 0) throw new SimsSignalMissingException("Signal Id missing");
            if (!await dbHost.Signals.IsClosed(hostId))
                return await dbHost.Signals.Products.Add(hostId, newSimsProduct);
            else
                throw new SimsIncidentClosedException("Signal  closed");
        }

        public async Task AssignFbo(int productId, int addressId, SimsFboTypes types)
        {
            if (productId == 0) throw new SimsItemMissing("Prouct Id missing");
            if (addressId == 0) throw new SimsItemMissing("address Id missing");

            if (!await dbHost.Signals.IsClosed(productId))
                await dbHost.Signals.Products.Fbos.Add(productId, addressId, (int)types);
            else
                throw new SimsIncidentClosedException("Signal  closed");
        }

        public Task<IPaging<SimsProductDashboard>> DashboardItems(int hostId, int pageSize = 10, int startPage = 1)
        {
            if (hostId == 0) throw new SimsItemMissing("No Host id present.");
            return dbHost.Signals.Products.DashboardItems(hostId, pageSize, startPage);
        }

        public async Task<SimsProductDisplayModel> Get(int productId)
        {
            var productDispModel = await dbHost.Signals.Products.Get(productId);
            var signal = await this.dbHost.Signals.Get(productDispModel.HostId);
            productDispModel.DataSourceId = -1;
            productDispModel.SignalUrl = signal.SourceLink;
            /// YEEEEUUUUUUCK!
            productDispModel.SignalDataSource = signal.DataSource;
            return productDispModel;
        }


        public async Task<SimsProduct> Update(SimsProduct product)
        {
            if (product.Id == 0) throw new SimsItemMissing("Missing id");
            var appProduct = await dbHost.Signals.Products.Get(product.Id);
            if (!await dbHost.Signals.IsClosed((int)appProduct.HostId))
                return await dbHost.Signals.Products.Update((SimsProduct)product);
            else
                throw new SimsSignalClosedException("Signal closed");
        }


        public Task<IEnumerable<SimsProductFboAddress>> GetAddress(int productId)
        {
            if (productId == 0) throw new SimsItemMissing("No product id present.");
            return dbHost.Signals.Products.Fbos.GetAddresses(productId);
        }

        public Task<IEnumerable<SimsProduct>> GetAll(int hostId)
        {
            return dbHost.Signals.Products.HostProducts(hostId);
        }

        public async Task RemoveFbo(int productId, int addressId)
        {
            var product = await dbHost.Signals.Products.Get(productId);
            if (!await dbHost.Signals.IsClosed(product.HostId))
                await dbHost.Signals.Products.Fbos.Remove(productId, addressId);
            else
                throw new SimsSignalClosedException("Signal closed");
        }

        public async Task UpdateFbo(int productId, int addressId, SimsFboTypes fboTypes)
        {
            if (productId == 0) throw new SimsItemMissing("Missing id");
            var product = await dbHost.Signals.Products.Get(productId);
            if (!await dbHost.Signals.IsClosed(product.HostId))
                await dbHost.Signals.Products.Fbos.Update(productId, addressId, (int)fboTypes);
            else
                throw new SimsSignalClosedException("Signal closed");
        }
    }
}