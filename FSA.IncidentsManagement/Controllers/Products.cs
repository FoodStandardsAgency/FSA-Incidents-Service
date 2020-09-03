using AutoMapper;
using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sims.Application.Exceptions;
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
        private readonly IMapper mapper;
        private readonly ISIMSApplication simsApp;

        public ProductsController(ILogger<ProductsController> log, IMapper mapper, ISIMSApplication simsApp)
        {
            this.log = log;
            this.mapper = mapper;
            this.simsApp = simsApp;
        }

        [HttpPost("{incidentSignal}")]
        [SwaggerOperation(Summary = "Create new Product")]
        [ProducesResponseType(typeof(SimsProduct), 200)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddProduct([FromRoute] string incidentSignal, [FromBody] ProductViewModel newProduct)
        {
            try
            {
                var newSimsProduct = mapper.Map<SimsProduct>(newProduct);
                return incidentSignal.ToLower() switch
                {
                    IncidentOrSignal.Incidents => new OkObjectResult(await this.simsApp.Incidents.Products.Add(newProduct.HostId, newSimsProduct)),
                    IncidentOrSignal.Signals => new OkObjectResult(await this.simsApp.Signals.Products.Add(newProduct.HostId, newSimsProduct)),
                    _ => BadRequest("Unknown route")
                };
            }
            catch (Sims.Application.Exceptions.SIMSException ex)
            {
                log.LogWarning(ex, ex.Message);
                return new BadRequestObjectResult(ex.Message);
            }
        }

        [HttpGet("{incidentSignal}/{productId}")]
        [SwaggerOperation(Summary = "Fetch product")]
        [ProducesResponseType(typeof(SimsProductDisplayModel), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProduct([FromRoute] string incidentSignal, [FromRoute] int productId)
        {

            return incidentSignal.ToLower() switch
            {
                IncidentOrSignal.Incidents => new OkObjectResult(await this.simsApp.Incidents.Products.Get(productId)),
                IncidentOrSignal.Signals => new OkObjectResult(await this.simsApp.Signals.Products.Get(productId)),
                _ => BadRequest("Unknown route")
            };
        }

        [HttpGet("all/{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Fetch products")]
        [ProducesResponseType(typeof(List<SimsProduct>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAllProducts([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            return incidentSignal.ToLower() switch
            {
                IncidentOrSignal.Incidents => new OkObjectResult(await this.simsApp.Incidents.Products.GetAll(id)),
                IncidentOrSignal.Signals => new OkObjectResult(await this.simsApp.Signals.Products.GetAll(id)),
                _ => BadRequest("Unknown route")
            };
        }

        [HttpGet("Addresses/{incidentSignal}/{productId}")]
        [SwaggerOperation(Summary = "Fetch product addresses")]
        [ProducesResponseType(typeof(List<ProductFboAddressViewModel>), 200)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProductAddresses([FromRoute] string incidentSignal, [FromRoute] int productId)
        {
            var addresses = incidentSignal.ToLower() switch
            {
                IncidentOrSignal.Incidents => await this.simsApp.Incidents.Products.GetAddress(productId),
                IncidentOrSignal.Signals => await this.simsApp.Signals.Products.GetAddress(productId),
                _ => throw new InvalidOperationException("Unknow Route")
            };
            var mapped = mapper.Map<IEnumerable<SimsProductFboAddress>, List<ProductFboAddressViewModel>>(addresses);
            return new OkObjectResult(mapped);
        }


        [HttpPost("Fbo/{incidentSignal}")]
        [SwaggerOperation(Summary = "Assign fbo to product")]
        [ProducesResponseType(200)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddFbo([FromRoute] string incidentSignal, [Required] ProductFboInfoViewModel assignObj)
        {
            try
            {

                var t = incidentSignal.ToLower() switch
                {
                    IncidentOrSignal.Incidents => this.simsApp.Incidents.Products.AssignFbo(assignObj.Id, assignObj.AddressId, (SimsFboTypes)assignObj.FboTypes.Sum()),
                    IncidentOrSignal.Signals => this.simsApp.Signals.Products.AssignFbo(assignObj.Id, assignObj.AddressId, (SimsFboTypes)assignObj.FboTypes.Sum()),
                    _ => throw new InvalidOperationException("Unknow Route")
                };
                await t;
                return new OkResult();
            }
            catch (Sims.Application.Exceptions.SIMSException ex)
            {
                this.log.LogError(ex, ex.Message);
                return new BadRequestObjectResult(ex.Message);
            }
        }

        [HttpDelete("Fbo/{incidentSignal}")]
        [SwaggerOperation(Summary = "Remove fbo from product")]
        [ProducesResponseType( 200)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> RemoveFbo([FromRoute] string incidentSignal, [Required] ProductFboInfoViewModel assignObj)
        {
            try
            {
                var t = incidentSignal.ToLower() switch
                {
                    IncidentOrSignal.Incidents => this.simsApp.Incidents.Products.RemoveFbo(assignObj.Id, assignObj.AddressId),
                    IncidentOrSignal.Signals => this.simsApp.Signals.Products.RemoveFbo(assignObj.Id, assignObj.AddressId),
                    _ => throw new InvalidOperationException("Unknow Route")
                };

                await t;
                return new OkResult();

            }
            catch (SIMSException ex)
            {
                this.log.LogError(ex, ex.Message);
                return new BadRequestObjectResult(ex.Message);
            }
        }

        [HttpPut("Fbo/{incidentSignal}")]
        [SwaggerOperation(Summary = "Update fbo to product")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateFbo([FromRoute] string incidentSignal,[Required] ProductFboInfoViewModel assignObj)
        {
            try
            {
                var t = incidentSignal.ToLower() switch
                {
                    IncidentOrSignal.Incidents => this.simsApp.Incidents.Products.UpdateFbo(assignObj.Id, assignObj.AddressId, (SimsFboTypes)assignObj.FboTypes.Sum()),
                    IncidentOrSignal.Signals => this.simsApp.Signals.Products.UpdateFbo(assignObj.Id, assignObj.AddressId, (SimsFboTypes)assignObj.FboTypes.Sum()),
                    _ => throw new InvalidOperationException("Unknow Route")
                };
                await t;
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
        [ProducesResponseType(typeof(PagedResult<SimsProductDashboard>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProductDashboard([FromRoute] string incidentSignal, [FromRoute] int id, [FromQuery] int pageSize = 10, [FromQuery] int pageNo = 1)
        {
            try
            {
                return incidentSignal.ToLower() switch
                {
                    IncidentOrSignal.Incidents => new OkObjectResult(await this.simsApp.Incidents.Products.DashboardItems(id, pageSize, pageNo)),
                    IncidentOrSignal.Signals => new OkObjectResult(await this.simsApp.Signals.Products.DashboardItems(id, pageSize, pageNo)),
                    _ => BadRequest("Unknown route")
                };

            }
            catch (Exception ex)
            {
                this.log.LogError(ex, ex.Message);
                return new StatusCodeResult(500);
            }
        }

    }
}
