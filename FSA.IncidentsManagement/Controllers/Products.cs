using AutoMapper;
using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
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
    [ApiConventionType(typeof(DefaultApiConventions))]
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
        [SwaggerOperation(Summary = "Create new Product", Description = "Create new Product")]
        [ProducesResponseType(typeof(SimsProduct), 200)]
        [ProducesResponseType(typeof(string), 403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddProduct([FromRoute] string incidentSignal, [FromBody] ProductViewModel newProduct)
        {
            try
            {
                var newSimsProduct = mapper.Map<SimsProduct>(newProduct);
                return incidentSignal.ToLower() switch
                {
                    IncidentOrSignalOrOnlineForm.Incidents => new OkObjectResult(await this.simsApp.Incidents.Products.Add(newProduct.HostId, newSimsProduct)),
                    IncidentOrSignalOrOnlineForm.Signals => new OkObjectResult(await this.simsApp.Signals.Products.Add(newProduct.HostId, newSimsProduct)),
                    IncidentOrSignalOrOnlineForm.OnlineForm => new OkObjectResult(await this.simsApp.OnlineForms.Products.Add(newProduct.HostId, newSimsProduct)),
                    _ => BadRequest("Unknown route")
                };
            }
            catch (Sims.Application.Exceptions.SIMSException ex)
            {
                log.LogWarning(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{incidentSignal}")]
        [SwaggerOperation(Summary = "Update Product", Description = "Update Product")]
        [ProducesResponseType(typeof(SimsProduct), 200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(typeof(string), 403)]
        public async Task<IActionResult> UpdateProduct([FromRoute] string incidentSignal,[FromBody] ProductViewModel product)
        {
            try
            {
                var updatedProduct = mapper.Map<SimsProduct>(product);

                return incidentSignal.ToLower() switch
                {
                    IncidentOrSignalOrOnlineForm.Incidents => new OkObjectResult(await this.simsApp.Incidents.Products.Update(updatedProduct)),
                    IncidentOrSignalOrOnlineForm.Signals => new OkObjectResult(await this.simsApp.Signals.Products.Update(updatedProduct)),
                    IncidentOrSignalOrOnlineForm.OnlineForm => new OkObjectResult(await this.simsApp.OnlineForms.Products.Update(updatedProduct)),
                    _ => BadRequest("Unknown route")
                };

            }
            catch (SIMSException ex)
            {
                log.LogWarning(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{incidentSignal}/{productId}")]
        [SwaggerOperation(Summary = "Fetch product", Description = "Fetch product")]
        [ProducesResponseType(typeof(SimsProductDisplayModel), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProduct([FromRoute] string incidentSignal, [FromRoute] int productId)
        {

            return incidentSignal.ToLower() switch
            {
                IncidentOrSignalOrOnlineForm.Incidents => new OkObjectResult(await this.simsApp.Incidents.Products.Get(productId)),
                IncidentOrSignalOrOnlineForm.Signals => new OkObjectResult(await this.simsApp.Signals.Products.Get(productId)),
                IncidentOrSignalOrOnlineForm.OnlineForm => new OkObjectResult(await this.simsApp.OnlineForms.Products.Get(productId)),
                _ => BadRequest("Unknown route")
            };
        }

        [HttpGet("all/{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Fetch products", Description = "Fetch products")]
        [ProducesResponseType(typeof(List<SimsProduct>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAllProducts([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            return incidentSignal.ToLower() switch
            {
                IncidentOrSignalOrOnlineForm.Incidents => new OkObjectResult(await this.simsApp.Incidents.Products.GetAll(id)),
                IncidentOrSignalOrOnlineForm.Signals => new OkObjectResult(await this.simsApp.Signals.Products.GetAll(id)),
                IncidentOrSignalOrOnlineForm.OnlineForm => new OkObjectResult(await this.simsApp.OnlineForms.Products.GetAll(id)),
                _ => BadRequest("Unknown route")
            };
        }

        [HttpGet("Addresses/{incidentSignal}/{productId}")]
        [SwaggerOperation(Summary = "Fetch product addresses", Description = "Fetch product addresses")]
        [ProducesResponseType(typeof(List<ProductFboAddressViewModel>), 200)]
        [ProducesResponseType(typeof(string), 403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetProductAddresses([FromRoute] string incidentSignal, [FromRoute] int productId)
        {
            var addresses = incidentSignal.ToLower() switch
            {
                IncidentOrSignalOrOnlineForm.Incidents => await this.simsApp.Incidents.Products.GetAddress(productId),
                IncidentOrSignalOrOnlineForm.Signals => await this.simsApp.Signals.Products.GetAddress(productId),
                IncidentOrSignalOrOnlineForm.OnlineForm => await this.simsApp.OnlineForms.Products.GetAddress(productId),
                _ => throw new InvalidOperationException("Unknow Route")
            };
            var mapped = mapper.Map<IEnumerable<SimsProductFboAddress>, List<ProductFboAddressViewModel>>(addresses);
            return new OkObjectResult(mapped);
        }


        [HttpPost("Fbo/{incidentSignal}")]
        [SwaggerOperation(Summary = "Assign fbo to product", Description = "Assign fbo to product")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(string), 403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddFbo([FromRoute] string incidentSignal, [Required] ProductFboInfoViewModel assignObj)
        {
            try
            {

                var t = incidentSignal.ToLower() switch
                {
                    IncidentOrSignalOrOnlineForm.Incidents => this.simsApp.Incidents.Products.AssignFbo(assignObj.Id, assignObj.AddressId, (SimsFboTypes)assignObj.FboTypes.Sum()),
                    IncidentOrSignalOrOnlineForm.Signals => this.simsApp.Signals.Products.AssignFbo(assignObj.Id, assignObj.AddressId, (SimsFboTypes)assignObj.FboTypes.Sum()),
                    IncidentOrSignalOrOnlineForm.OnlineForm=> this.simsApp.OnlineForms.Products.AssignFbo(assignObj.Id, assignObj.AddressId, (SimsFboTypes)assignObj.FboTypes.Sum()),
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
        [SwaggerOperation(Summary = "Remove fbo from product", Description = "Remove fbo from product")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(string), 403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> RemoveFbo([FromRoute] string incidentSignal, [Required] ProductFboInfoViewModel assignObj)
        {
            try
            {
                var t = incidentSignal.ToLower() switch
                {
                    IncidentOrSignalOrOnlineForm.Incidents => this.simsApp.Incidents.Products.RemoveFbo(assignObj.Id, assignObj.AddressId),
                    IncidentOrSignalOrOnlineForm.Signals => this.simsApp.Signals.Products.RemoveFbo(assignObj.Id, assignObj.AddressId),
                    IncidentOrSignalOrOnlineForm.OnlineForm => this.simsApp.OnlineForms.Products.RemoveFbo(assignObj.Id, assignObj.AddressId),
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
        [SwaggerOperation(Summary = "Update fbo to product", Description = "Update fbo to product")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(string), 403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateFbo([FromRoute] string incidentSignal, [Required] ProductFboInfoViewModel assignObj)
        {
            try
            {
                var t = incidentSignal.ToLower() switch
                {
                    IncidentOrSignalOrOnlineForm.Incidents => this.simsApp.Incidents.Products.UpdateFbo(assignObj.Id, assignObj.AddressId, (SimsFboTypes)assignObj.FboTypes.Sum()),
                    IncidentOrSignalOrOnlineForm.Signals => this.simsApp.Signals.Products.UpdateFbo(assignObj.Id, assignObj.AddressId, (SimsFboTypes)assignObj.FboTypes.Sum()),
                    IncidentOrSignalOrOnlineForm.OnlineForm => this.simsApp.OnlineForms.Products.UpdateFbo(assignObj.Id, assignObj.AddressId, (SimsFboTypes)assignObj.FboTypes.Sum()),
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
        [SwaggerOperation(Summary = "Product dashboard", Description = "Product dashboard")]
        [ProducesResponseType(typeof(PagedResult<SimsProductDashboard>), 200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(typeof(string), 403)]
        public async Task<IActionResult> GetProductDashboard([FromRoute] string incidentSignal, [FromRoute] int id, [FromQuery] int pageSize = 10, [FromQuery] int pageNo = 1)
        {
            try
            {
                var items = incidentSignal.ToLower() switch
                {
                    IncidentOrSignalOrOnlineForm.Incidents => await this.simsApp.Incidents.Products.DashboardItems(id, pageSize, pageNo),
                    IncidentOrSignalOrOnlineForm.Signals => await this.simsApp.Signals.Products.DashboardItems(id, pageSize, pageNo),
                    IncidentOrSignalOrOnlineForm.OnlineForm => await this.simsApp.OnlineForms.Products.DashboardItems(id, pageSize, pageNo),
                    _ => throw new InvalidOperationException("Unknown route")
                };

                return new OkObjectResult(new { Results = items, TotalRecords = items.TotalResults });
            }
            catch (InvalidOperationException ex)
            {
                this.log.LogError(nameof(GetProductDashboard), ex.Message);
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                this.log.LogError(ex, ex.Message);
                return new StatusCodeResult(500);
            }
        }

    }
}
