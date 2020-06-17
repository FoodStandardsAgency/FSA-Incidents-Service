using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace FSA.IncidentsManagement.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    public class LookupsController : ControllerBase
    {
        private readonly ILogger<LookupsController> log;
        private readonly ILookupDataHost lookupdata;

        public LookupsController(ILogger<LookupsController> log, ILookupDataHost lookupdata)
        {
            this.log = log;
            this.lookupdata = lookupdata;
        }

        [HttpGet("Categories")]
        [ProducesResponseType(typeof(IEnumerable<Category>), 200)]
        [ProducesResponseType(500)]
        [SwaggerOperation(Summary = "Get all categories")]
        public async Task<IActionResult> Categories()
        {
            return new OkObjectResult((await this.lookupdata.Categories
                            .GetAll()).ToList());
        }

        /// <summary>
        /// The list of classifications for an incident
        /// </summary>
        /// <returns></returns>
        /// <response code="200">A list of items (Can be empty)</response>
        [HttpGet("Classifications")]
        [ProducesResponseType(typeof(IEnumerable<Classification>), 200)]
        [ProducesResponseType(500)]
        [SwaggerOperation(Summary = "Get all classifications")]
        public async Task<IActionResult> Classifications()
        {
            return new OkObjectResult((await this.lookupdata.Classifications
                            .GetAll()).ToList());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("Countries")]
        [ProducesResponseType(typeof(IEnumerable<Country>), 200)]
        [ProducesResponseType(500)]
        [SwaggerOperation(Summary = "Get all countries")]
        public async Task<IActionResult> Countries()
        {
            return new OkObjectResult((await this.lookupdata.Countries
                            .GetAll()).ToList());
        }

        [HttpGet("ContactMethod")]
        [ProducesResponseType(typeof(IEnumerable<ContactMethod>), 200)]
        [ProducesResponseType(500)]
        [SwaggerOperation(Summary = "Get all Contact methods")]
        public async Task<IActionResult> ContactMethod()
        {
            return new OkObjectResult((await this.lookupdata.ContactMethods
                            .GetAll()).ToList());
        }


        [HttpGet("DataSources")]
        [ProducesResponseType(typeof(IEnumerable<DataSource>), 200)]
        [ProducesResponseType(500)]
        [SwaggerOperation(Summary = "Data sources")]
        public async Task<IActionResult> DataSource()
        {
            return new OkObjectResult((await this.lookupdata.DataSources
                            .GetAll()).ToList());
        }


        [HttpGet("DeathIllnesses")]
        [ProducesResponseType(typeof(IEnumerable<DeathIllness>), 200)]
        [ProducesResponseType(500)]
        [SwaggerOperation(Summary = "Get all Death/Illnes")]
        public async Task<IActionResult> DeathIllness()
        {
            return new OkObjectResult((await this.lookupdata.DeathIllnesses
                            .GetAll()).ToList());
        }

        [HttpGet("OMITGroups")]
        [ProducesResponseType(typeof(IEnumerable<OMITGroup>), 200)]
        [ProducesResponseType(500)]
        [SwaggerOperation(Summary = "Get all OMIT groups")]
        public async Task<IActionResult> OMITGroup()
        {
            return new OkObjectResult((await this.lookupdata.OMITGroups
                            .GetAll()).ToList());
        }

        [HttpGet("OrganisationRoles")]
        [ProducesResponseType(typeof(IEnumerable<OrganisationRole>), 200)]
        [ProducesResponseType(500)]
        [SwaggerOperation(Summary = "Get all organisational roles")]
        public async Task<IActionResult> OrganisationRole()
        {
            return new OkObjectResult((await this.lookupdata.OrganisationsRoles
                            .GetAll()).ToList());
        }

        [HttpGet("PersonaRoles")]
        [ProducesResponseType(typeof(IEnumerable<PersonaRole>), 200)]
        [ProducesResponseType(500)]
        [SwaggerOperation(Summary = "Get all Persona Roiles")]
        public async Task<IActionResult> PersonaRole()
        {
            return new OkObjectResult((await this.lookupdata.PersonaRoles
                            .GetAll()).ToList());
        }

        [HttpGet("ProductTypes")]
        [ProducesResponseType(typeof(IEnumerable<ProductType>), 200)]
        [ProducesResponseType(500)]
        [SwaggerOperation(Summary = "list all Product types")]
        public async Task<IActionResult> ProductType()
        {
            return new OkObjectResult((await this.lookupdata.ProductTypes
                            .GetAll()).ToList());
        }

        [HttpGet("Status")]
        [ProducesResponseType(typeof(IEnumerable<SignalStatus>), 200)]
        [ProducesResponseType(500)]
        [SwaggerOperation(Summary = "Divine all status values")]
        public async Task<IActionResult> SignalStatus()
        {
            return new OkObjectResult((await this.lookupdata.SignalStatus
                            .GetAll()).ToList());
        }

        [HttpGet("Units")]
        [ProducesResponseType(typeof(IEnumerable<UnitQuantity>), 200)]
        [ProducesResponseType(500)]
        [SwaggerOperation(Summary = "unit information")]
        public async Task<IActionResult> UnitQuantities()
        {
            return new OkObjectResult((await this.lookupdata.Units
                            .GetAll()).ToList());
        }
        [HttpGet("Organisations")]
        [ProducesResponseType(typeof(IEnumerable<UnitQuantity>), 200)]
        [ProducesResponseType(500)]
        [SwaggerOperation(Summary = "Organisation pick list")]
        public async Task<IActionResult> Organisations()
        {
            return new OkObjectResult((await this.lookupdata.Organisations
                            .GetAll()).ToList());
        }

        [HttpGet("Priorities")]
        [ProducesResponseType(typeof(IEnumerable<UnitQuantity>), 200)]
        [ProducesResponseType(500)]
        [SwaggerOperation(Summary = "Priorities values")]
        public async Task<IActionResult> Priorities()
        {
            return new OkObjectResult((await this.lookupdata.Priorities
                            .GetAll()).ToList());
        }

        [HttpGet("Status")]
        [ProducesResponseType(typeof(IEnumerable<UnitQuantity>), 200)]
        [ProducesResponseType(500)]
        [SwaggerOperation(Summary = "Incident Statusvalues")]
        public async Task<IActionResult> IncidentStatus()
        {
            return new OkObjectResult((await this.lookupdata.Status
                            .GetAll()).ToList());
        }
    }
}
