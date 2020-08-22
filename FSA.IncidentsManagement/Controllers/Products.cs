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
        [SwaggerOperation(Summary = "Create new Product")]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddProduct([FromBody] NewProductModel newProduct)
        {
            var item = newProduct.ToClient();
            var product = await this.simsManager.Products.Add(newProduct.IncidentId, item);
            return new OkObjectResult(product);
        }

        [HttpPut("")]
        [SwaggerOperation(Summary = "Update Product")]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateProduct([FromBody] NewProductModel product)
        {
            var updatedProduct = await this.simsManager.Products.Update(product.ToClient());
            return new OkObjectResult(updatedProduct);
        }

        [HttpGet("")]
        [SwaggerOperation(Summary = "Fetch product")]
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
        [SwaggerOperation(Summary = "Fetch products")]
        [ProducesResponseType(typeof(List<Product>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetIncidentProducts(int incidentId)
        {
            var products = await this.simsManager.Products.IncidentProducts(incidentId);
            return new OkObjectResult(products);
        }

        [HttpGet("Addresses/{productId}")]
        [SwaggerOperation(Summary = "Fetch product addresses")]
        [ProducesResponseType(typeof(List<ProductFboAddress>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProductAddresses(int productId)
        {
            var addresses = await this.simsManager.Products.GetProductAddresses(productId);
            return new OkObjectResult(addresses.ToList());
        }

        [HttpGet("Dashboard")]
        [SwaggerOperation(Summary = "Product dashboard")]
        [ProducesResponseType(typeof(PagedResult<ProductDashboard>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProductDashboard([FromQuery] int incidentId, [FromQuery] int pageSize = 10, [FromQuery] int pageNo = 1)
        {
            var addresses = await this.simsManager.Products.DashboardItems(incidentId, pageSize, pageNo);
            return new OkObjectResult(new { Results = addresses, TotalRecords = addresses.TotalResults });
        }


        [HttpPost("AssignFbo")]
        [SwaggerOperation(Summary = "Assign fbo to product")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AssignFbo([Required] AssignItemToFbo assignObj)
        {
            await this.simsManager.Products.AssignFbo(assignObj.Id, assignObj.FboId, (FboTypes)assignObj.FboTypes.Sum());
            return new OkResult();
        }

        [HttpPost("UpdateFbo")]
        [SwaggerOperation(Summary = "Update fbo to product")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateFbo([Required] AssignItemToFbo assignObj)
        {
            await this.simsManager.Products.UpdateFbo(assignObj.Id, assignObj.FboId, (FboTypes)assignObj.FboTypes.Sum());
            return new OkResult();
        }

        [HttpPost("RemoveFbo")]
        [SwaggerOperation(Summary = "Remove fbo from product")]
        [ProducesResponseType(typeof(PagedResult<FboAddress>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> RemoveFbo([Required] AssignItemToFbo assignObj)
        {
            await this.simsManager.Products.RemoveFbo(assignObj.Id, assignObj.FboId);
            return new OkResult();
        }

    }
}
