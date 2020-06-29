using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Root.Contracts
{
    public interface IProductsManagement
    {
        Task<Product> AddProduct(int incidentId, Product newProduct);
        Task<IEnumerable<Product>> AllProducts(int incidentId);
        Task<Product> UpdateProduct(Product product);
    }
}
