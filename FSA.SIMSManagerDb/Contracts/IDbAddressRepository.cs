using FSA.IncidentsManagement.Root.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    public interface IDbAddressRepository
    {
        Task Add(IEnumerable<SimsAddress> addresses);
        Task<SimsAddress> Add(SimsAddress address);
        Task<IEnumerable<SimsAddress>> FindAddress(string search);
        Task<SimsAddress> Get(int addressId);
        Task<SimsAddress> Update(SimsAddress address);
    }
}