using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Contracts
{
    public interface IProductsManagement
    {
        Task<Product> Add(int incidentId, Product newProduct);
        Task<Product> Update(Product product);
        Task<Product> Get(int productId);
        Task<IEnumerable<Product>> IncidentProducts(int incidentId);
        Task<IEnumerable<FboAddress>> GetProductAddresses(int productId);
        Task<IPaging<ProductDashboard>> DashboardItems(int incidentId, int pageSize = 10, int startPage = 1);
        Task AddAddress(int v1, int v2);
    }
}
