using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using FSA.SIMSManagerDb.Contracts;
using Sims.Application.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class IncidentProducts : ISIMSProducts
    {
        private ISimsDbHost dbHost;

        public IncidentProducts(ISimsDbHost dbHost)
        {
            this.dbHost = dbHost;
        }

        public async Task<SimsProduct> Add(int hostId, SimsProduct newSimsProduct)
        {
            if (hostId == 0) throw new SimsIncidentMissingException("Incident missing");
            if (!await dbHost.Incidents.IsClosed(hostId))
                return await dbHost.Incidents.Products.Add(hostId, newSimsProduct);
            else
                throw new SimsIncidentClosedException("Incident closed");

        }

        public async Task AssignFbo(int productId, int addressId, FboTypes types)
        {
            if (productId == 0) throw new SimsItemMissing("Prouct Id missing");
            if (addressId == 0) throw new SimsItemMissing("address Id missing");

            var product = await dbHost.Incidents.Products.Get(productId);
            if (!await dbHost.Incidents.IsClosed(product.HostId))
                await dbHost.Incidents.Products.Fbos.Add(productId, addressId, types);
            else
                throw new SimsIncidentClosedException("Incident closed");

        }

        public Task<IPaging<SimsProductDashboard>> DashboardItems(int hostId, int pageSize = 10, int startPage = 1)
        {
            if (hostId == 0) throw new SimsItemMissing("No Host id present.");
            return dbHost.Incidents.Products.DashboardItems(hostId, pageSize, startPage);
        }

        public async Task<SimsProductDisplayModel> Get(int SimsProductId)
        {
            var productDispModel = await dbHost.Incidents.Products.Get(SimsProductId);
            var incident = await this.dbHost.Incidents.Get(productDispModel.HostId);
            productDispModel.DataSourceId = incident.DataSourceId;
            productDispModel.SignalUrl = incident.SignalUrl;
            return productDispModel;
        }

        public Task<IEnumerable<SimsProductFboAddress>> GetAddress(int SimsProductId)
        {
            return dbHost.Incidents.Products.Fbos.GetAddresses(SimsProductId);
        }

        public async Task RemoveFbo(int productId, int addressId)
        {
            var product = await dbHost.Incidents.Products.Get(productId);
            if (!await dbHost.Incidents.IsClosed(product.HostId))
                await dbHost.Incidents.Products.Fbos.Remove(productId, addressId);
            else
                throw new SimsIncidentClosedException("Incident closed");
        }

        public async Task<SimsProduct> Update(SimsProduct SimsProduct)
        {
            if (SimsProduct.Id == 0) throw new SimsItemMissing("Missing id");
            var product = await dbHost.Incidents.Products.Get(SimsProduct.Id);
            if (!await dbHost.Incidents.IsClosed(product.HostId))
                return await dbHost.Incidents.Products.Update(SimsProduct);
            else
                throw new SimsIncidentClosedException("Incident closed");
        }

        public async Task UpdateFbo(int productId, int addressId, FboTypes fboTypes)
        {
            if (productId == 0) throw new SimsItemMissing("Missing id");
            var product = await dbHost.Incidents.Products.Get(productId);
            if (!await dbHost.Incidents.IsClosed(product.HostId))
                await dbHost.Incidents.Products.Fbos.Update(productId, addressId, fboTypes);
            else
                throw new SimsIncidentClosedException("Incident closed");
        }

        public Task<IEnumerable<SimsProduct>> GetAll(int hostId)
        {
            return dbHost.Incidents.Products.HostProducts(hostId);
        }

    }
}