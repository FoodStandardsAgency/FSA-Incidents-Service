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
            throw new System.NotImplementedException();
        }

        public Task AssignFbo(int SimsProductId, int addressId, FboTypes types)
        {
            throw new System.NotImplementedException();
        }

        public Task<IPaging<SimsProductDashboard>> DashboardItems(int hostId, int pageSize = 10, int startPage = 1)
        {
            throw new System.NotImplementedException();
        }

        public Task<SimsProductDisplayModel> Get(int SimsProductId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<SimsProductFboAddress>> GetAddress(int SimsProductId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<SimsProduct>> GetAll(int incidentId)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveFbo(int SimsProductId, int addressId)
        {
            throw new System.NotImplementedException();
        }

        public Task<SimsProduct> Update(SimsProduct SimsProduct)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateFbo(int SimsProductId, int addressId, FboTypes fboTypes)
        {
            throw new System.NotImplementedException();
        }
    }
}