using FSA.IncidentsManagement.Root.Models;
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
        Task<IEnumerable<Product>> AllProducts(int incidentId);
    }
}
