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
    [Route("api/v1/Products")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class OldProductsController : ControllerBase
    {
        private ILogger<OLDLookupsController> log;
        private readonly ISIMSManager simsManager;

        public OldProductsController(ILogger<OLDLookupsController> log, ISIMSManager simsManager)
        {
            this.log = log;
            this.simsManager = simsManager;
        }


        [HttpPost("")]
        [SwaggerOperation(Summary = "Create new Product")]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddProduct([FromBody] ProductViewModel newProduct)
        {
            try
            {
                var item = newProduct.ToClient();
                var product = await this.simsManager.Products.Add(newProduct.IncidentId, item);
                return new OkObjectResult(product);
            }catch(IncidentClosedException ex)
            {
                log.LogWarning(ex, ex.Message);
                return new BadRequestObjectResult("Incident closed");
            }
            catch (IncidentMissingException ex)
            {
                log.LogWarning(ex, ex.Message);
                return new BadRequestObjectResult("Incident Id missing");
            }
            catch(ProductExistsException ex)
            {
                log.LogWarning(ex, ex.Message);
                return new BadRequestObjectResult("Product already exists");
            }
        }

        [HttpPut("")]
        [SwaggerOperation(Summary = "Update Product")]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(403)]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductViewModel product)
        {
            try
            {
                var updatedProduct = await this.simsManager.Products.Update(product.ToClient());
                return new OkObjectResult(updatedProduct);
            }
            catch(IncidentClosedException ex)
            {
                log.LogWarning(ex, ex.Message);
                return new BadRequestObjectResult("Incident was closed");
            }
        }

        [HttpGet("")]
        [SwaggerOperation(Summary = "Fetch product")]
        [ProducesResponseType(typeof(ProductDisplayModel), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProduct([FromQuery] int productId)
        {
            if (productId == 0)
                return new BadRequestObjectResult("product id missing");

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
        [ProducesResponseType(typeof(List<ProductFboAddressViewModel>), 200)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProductAddresses(int productId)
        {
            var addresses = await this.simsManager.Products.GetProductAddresses(productId);
            return new OkObjectResult(addresses.ToWeb().ToList());
        }

        [HttpGet("Dashboard")]
        [SwaggerOperation(Summary = "Product dashboard")]
        [ProducesResponseType(typeof(PagedResult<ProductDashboard>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProductDashboard([FromQuery] int incidentId, [FromQuery] int pageSize = 10, [FromQuery] int pageNo = 1)
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


        [HttpPost("AssignFbo")]
        [SwaggerOperation(Summary = "Assign fbo to product")]
        [ProducesResponseType(200)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AssignFbo([Required] ProductAddress assignObj)
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

        [HttpPost("UpdateFbo")]
        [SwaggerOperation(Summary = "Update fbo to product")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateFbo([Required] ProductAddress assignObj)
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

        [HttpPost("RemoveFbo")]
        [SwaggerOperation(Summary = "Remove fbo from product")]
        [ProducesResponseType(typeof(PagedResult<FboAddress>), 200)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> RemoveFbo([Required] ProductAddress assignObj)
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

    }
}
