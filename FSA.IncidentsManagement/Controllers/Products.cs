using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Exceptions;
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
        private readonly ILogger<ProductsController> log;
        private readonly ISIMSManager simsManager;

        public ProductsController(ILogger<ProductsController> log, ISIMSManager simsManager)
        {
            this.log = log;
            this.simsManager = simsManager;
        }

        [HttpPost("{incidentSignal}")]
        [SwaggerOperation(Summary = "Create new Product")]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddProduct([FromRoute] string incidentSignal, [FromBody] ProductViewModel newProduct)
        {
            try
            {
                var item = newProduct.ToClient();
                var product = await this.simsManager.Products.Add(newProduct.HostId, item);
                return new OkObjectResult(product);
            }
            catch (IncidentClosedException ex)
            {
                log.LogWarning(ex, ex.Message);
                return new BadRequestObjectResult("Incident closed");
            }
            catch (IncidentMissingException ex)
            {
                log.LogWarning(ex, ex.Message);
                return new BadRequestObjectResult("Incident Id missing");
            }
            catch (ProductExistsException ex)
            {
                log.LogWarning(ex, ex.Message);
                return new BadRequestObjectResult("Product already exists");
            }
        }

        [HttpGet("{productId}")]
        [SwaggerOperation(Summary = "Fetch product")]
        [ProducesResponseType(typeof(ProductDisplayModel), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProduct([FromRoute] int productId)
        {
            if (productId == 0)
                return new BadRequestObjectResult("product id missing");

            var product = await this.simsManager.Products.Get(productId);
            return new OkObjectResult(product);
        }

        [HttpGet("{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Fetch products")]
        [ProducesResponseType(typeof(List<Product>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAllProducts([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            var products = await this.simsManager.Products.IncidentProducts(id);
            return new OkObjectResult(products);
        }

        [HttpGet("Addresses/{productId}")]
        [SwaggerOperation(Summary = "Fetch product addresses")]
        [ProducesResponseType(typeof(List<ProductFboAddressViewModel>), 200)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProductAddresses([FromRoute]int productId)
        {
            var addresses = await this.simsManager.Products.GetProductAddresses(productId);
            return new OkObjectResult(addresses.ToWeb().ToList());
        }


        [HttpPost("Fbo")]
        [SwaggerOperation(Summary = "Assign fbo to product")]
        [ProducesResponseType(200)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddAddress([Required] ProductAddress assignObj)
        {
            try
            {
                await this.simsManager.Products.AssignFbo(assignObj.Id, assignObj.AddressId, (FboTypes)assignObj.FboTypes.Sum());
                return new OkResult();
            }
            catch (SIMSException ex)
            {
                this.log.LogError(ex, ex.Message);
                return new BadRequestObjectResult(ex.Message);
            }
        }

        [HttpDelete("Fbo")]
        [SwaggerOperation(Summary = "Remove fbo from product")]
        [ProducesResponseType(typeof(PagedResult<FboAddress>), 200)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> RemoveAddress([Required] ProductAddress assignObj)
        {
            try
            {
                await this.simsManager.Products.RemoveFbo(assignObj.Id, assignObj.AddressId);
                return new OkResult();
            }
            catch (SIMSException ex)
            {
                this.log.LogError(ex, ex.Message);
                return new BadRequestObjectResult(ex.Message);
            }
        }

        [HttpPut("Fbo")]
        [SwaggerOperation(Summary = "Update fbo to product")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateAddress([Required] ProductAddress assignObj)
        {
            try
            {
                await this.simsManager.Products.UpdateFbo(assignObj.Id, assignObj.AddressId, (FboTypes)assignObj.FboTypes.Sum());
                return new OkResult();
            }
            catch (SIMSException ex)
            {
                this.log.LogError(ex, ex.Message);
                return new BadRequestObjectResult(ex.Message);
            }
        }


        [HttpGet("Dashboard/{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Product dashboard")]
        [ProducesResponseType(typeof(PagedResult<ProductDashboard>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProductDashboard([FromRoute] string incidentSignal, [FromRoute] int incidentId, [FromQuery] int pageSize = 10, [FromQuery] int pageNo = 1)
        {
            try
            {
                var addresses = await this.simsManager.Products.DashboardItems(incidentId, pageSize, pageNo);
                return new OkObjectResult(new { Results = addresses, TotalRecords = addresses.TotalResults });
            }
            catch (Exception ex)
            {
                this.log.LogError(ex, ex.Message);
                return new StatusCodeResult(500);
            }
        }

    }
}
