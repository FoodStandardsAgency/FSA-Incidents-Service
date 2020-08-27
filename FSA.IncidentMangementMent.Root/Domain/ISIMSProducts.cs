using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSProducts
    {
        Task<Product> Add(int hostId, Product newProduct);
        Task<Product> Update(Product product);
        Task<ProductDisplayModel> Get(int productId);
        Task<IEnumerable<Product>> IncidentProducts(int incidentId);
        Task<IEnumerable<ProductFboAddress>> GetProductAddresses(int productId);
        Task<IPaging<ProductDashboard>> DashboardItems(int hostId, int pageSize = 10, int startPage = 1);
        Task AssignFbo(int productId, int addressId, FboTypes types);
        Task RemoveFbo(int productId, int addressId);
        Task UpdateFbo(int productId, int addressId, FboTypes fboTypes);
    }
}
