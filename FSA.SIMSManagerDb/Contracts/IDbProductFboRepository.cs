using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Contracts
{
    interface IDbProductFboRepository
    {
        Task<List<SimsProductFboAddress>> GetProductAddresses(int productId);
        Task AssignFbo(int productId, int addressId, FboTypes types);
        Task RemoveFbo(int productId, int addressId);
        Task UpdateFbo(int productId, int addressId, FboTypes fboTypes);
    }
}