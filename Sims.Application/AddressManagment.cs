using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.SIMSManagerDb.Contracts;
using Sims.Application.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sims.Application
{
    class AddressManagment : ISIMSAddress
    {
        private readonly ISimsDbHost dbHost;

        internal AddressManagment(ISimsDbHost dbHost)
        {
            this.dbHost = dbHost;
        }
        public Task<SimsAddress> Add(SimsAddress address)
        {
            if (address.Id != 0) throw new SimsItemExists("SimsAddress already exists");
            return dbHost.Addresses.Add(address);
        }

        public Task Add(IEnumerable<SimsAddress> addresses)=> dbHost.Addresses.Add(addresses);

        public Task<IEnumerable<SimsAddress>> FindAddress(string search) => dbHost.Addresses.FindAddress(search);

        public Task<SimsAddress> Get(int addressId) => dbHost.Addresses.Get(addressId);

        public Task<SimsAddress> Update(SimsAddress address)
        {
            if (address.Id == 0) throw new SimsItemMissing("Address Id missing");
            return dbHost.Addresses.Update(address);
        }
    }
}
