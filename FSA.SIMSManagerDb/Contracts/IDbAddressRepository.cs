using FSA.IncidentsManagement.Root.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    public interface IDbAddressRepository
    {
        Task Add(IEnumerable<Address> addresses);
        Task<Address> Add(Address address);
        Task<IEnumerable<Address>> FindAddress(string search);
        Task<Address> Get(int addressId);
        Task<Address> Update(Address address);
    }
}