using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Contracts
{
    public interface IDbProductFboRepository
    {
        Task<List<SimsProductFboAddress>> GetAddresses(int productId);
        Task Add(int productId, int addressId, FboTypes types);
        Task Remove(int productId, int addressId);
        Task Update(int productId, int addressId, FboTypes fboTypes);
    }
}