using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private ILogger<LookupsController> log;
        private readonly ISIMSManager simsManager;

        public ProductsController(ILogger<LookupsController> log, ISIMSManager simsManager)
        {
            this.log = log;
            this.simsManager = simsManager;
        }


        [HttpPost("")]
        [SwaggerOperation(Description =  "Create new Product.")]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddProduct([FromBody] NewProductModel newProduct)
        {
            var item = newProduct.ToClient();
            var product = await this.simsManager.Products.Add(newProduct.IncidentId, item);
            return new OkObjectResult(product);
        }

        [HttpPut("")]
        [SwaggerOperation(Description =  "Update Product.")]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateProduct([FromBody] NewProductModel product)
        {
            var updatedProduct = await this.simsManager.Products.Update(product.ToClient());
            return new OkObjectResult(updatedProduct);
        }

        [HttpGet("")]
        [SwaggerOperation(Description = "get product")]
        [ProducesResponseType(typeof(ProductDisplayModel), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProduct([FromQuery] int productId)
        {
            if (productId == 0)
                return new StatusCodeResult(500);

            var product = await this.simsManager.Products.Get(productId);
            return new OkObjectResult(product);
        }

        [HttpGet("Incident/{incidentId}")]
        [SwaggerOperation(Description =  "Fetch products.")]
        [ProducesResponseType(typeof(List<Product>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetIncidentProducts(int incidentId)
        {
            var products = await this.simsManager.Products.IncidentProducts(incidentId);
            return new OkObjectResult(products);
        }

        [HttpGet("Addresses/{productId}")]
        [SwaggerOperation(Description =  "Fetch product addresses.")]
        [ProducesResponseType(typeof(List<FboAddressModel>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProductAddresses(int productId)
        {
            var addresses = await this.simsManager.Products.GetProductAddresses(productId);
            return new OkObjectResult(addresses.ToWeb().ToList());
        }

        [HttpGet("Dashboard")]
        [SwaggerOperation(Description =  "Fetch product addresses.")]
        [ProducesResponseType(typeof(PagedResult<FboAddress>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProductDashboard([FromQuery]int incidentId, [FromQuery] int pageSize=10, [FromQuery]int pageNo=1)
        {
            var addresses = await this.simsManager.Products.DashboardItems(incidentId, pageSize, pageNo);
            return new OkObjectResult(new { Results = addresses, TotalRecords = addresses.TotalResults });
        }


        [HttpPost("AssignFbo")]
        [SwaggerOperation(Description = "Assigns fbo to product.")]
        [ProducesResponseType(typeof(PagedResult<FboAddress>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AssignFbo([Required] AssignItemToFbo assignObj )
        {
            await this.simsManager.Products.AssignFbo(assignObj.Id, assignObj.FboId);
            return new OkResult();
        }

        [HttpPost("RemoveFbo")]
        [SwaggerOperation(Description = "Removes fbo from product.")]
        [ProducesResponseType(typeof(PagedResult<FboAddress>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> RemoveFbo([Required] AssignItemToFbo assignObj)
        {
            await this.simsManager.Products.RemoveFbo(assignObj.Id, assignObj.FboId);
            return new OkResult();
        }

    }
}
