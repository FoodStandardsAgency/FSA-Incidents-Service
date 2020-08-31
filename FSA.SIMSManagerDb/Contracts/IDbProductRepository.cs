using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Contracts
{
    public interface IDbProductRepository
    {
        Task<SimsProduct> Add(int HostId, SimsProduct newProduct);
        Task<IPaging<SimsProductDashboard>> DashboardItems(int hostId, int pageSize = 10, int startPage = 1);
        Task<SimsProductDisplayModel> Get(int productId);
        Task<SimsProductDetail> GetDetail(int productId);
        Task<IEnumerable<SimsProduct>> HostProducts(int hostId);
        Task<SimsProduct> Update(SimsProduct product);

        IDbProductFboRepository Fbos { get; }
    }
}