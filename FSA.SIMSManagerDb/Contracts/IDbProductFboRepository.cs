using FSA.IncidentsManagement.Root.DTOS;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Contracts
{
    public interface IDbProductFboRepository
    {
        Task<IEnumerable<SimsProductFboAddress>> GetAddresses(int productId);
        Task Add(int productId, int addressId, int types);
        Task Remove(int productId, int addressId);
        Task Update(int productId, int addressId, int fboTypes);
        IEnumerable<string> GetNamesFromId(IEnumerable<int> fbosTypes);
    }
}