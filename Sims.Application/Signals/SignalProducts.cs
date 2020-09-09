using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using FSA.SIMSManagerDb.Contracts;
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

        public Task<SimsProduct> Add(int hostId, SimsProduct newSimsProduct)
        {
            return dbHost.Signals.Products.Add(hostId, newSimsProduct);
        }

        public Task AssignFbo(int SimsProductId, int addressId, SimsFboTypes types)
        {
            return dbHost.Signals.Products.Fbos.Add(SimsProductId, addressId, (int)types);
        }

        public Task<IPaging<SimsProductDashboard>> DashboardItems(int hostId, int pageSize = 10, int startPage = 1)
        {
            return dbHost.Signals.Products.DashboardItems(hostId, pageSize, startPage);
        }

        public Task<SimsProductDisplayModel> Get(int SimsProductId)
        {
            return dbHost.Signals.Products.Get(SimsProductId);
        }

        public Task<IEnumerable<SimsProductFboAddress>> GetAddress(int SimsProductId)
        {
            return dbHost.Signals.Products.Fbos.GetAddresses(SimsProductId);
        }

        public Task<IEnumerable<SimsProduct>> GetAll(int hostId)
        {
            return dbHost.Signals.Products.HostProducts(hostId);
        }

        public Task RemoveFbo(int SimsProductId, int addressId)
        {
            return dbHost.Signals.Products.Fbos.Remove(SimsProductId, addressId);
        }

        public Task<SimsProduct> Update(SimsProduct SimsProduct)
        {
            return dbHost.Signals.Products.Update(SimsProduct);
        }

        public Task UpdateFbo(int SimsProductId, int addressId, SimsFboTypes fboTypes)
        {
            return dbHost.Signals.Products.Fbos.Update(SimsProductId, addressId, (int)fboTypes);
        }
    }
}