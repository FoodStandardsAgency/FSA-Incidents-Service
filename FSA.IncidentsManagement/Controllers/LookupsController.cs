using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FSA.IncidentsManagement.Root.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
        public async Task<IActionResult> Countries()
        {
            return new OkObjectResult((await this.lookupdata.Countries
                            .GetAll()).ToList());
        }

        [HttpGet("ContactMethod")]
        public async Task<IActionResult> ContactMethod()
        {
            return new OkObjectResult((await this.lookupdata.ContactMethods
                            .GetAll()).ToList());
        }


        [HttpGet("DataSources")]
        public async Task<IActionResult> DataSource()
        {
            return new OkObjectResult((await this.lookupdata.DataSources
                            .GetAll()).ToList());
        }


        [HttpGet("DeathIllnesses")]
        public async Task<IActionResult> DeathIllness()
        {
            return new OkObjectResult((await this.lookupdata.DeathIllnesses
                            .GetAll()).ToList());
        }

        [HttpGet("OMITGroups")]
        public async Task<IActionResult> OMITGroup()
        {
            return new OkObjectResult((await this.lookupdata.OMITGroups
                            .GetAll()).ToList());
        }

        [HttpGet("OrganisationRoles")]
        public async Task<IActionResult> OrganisationRole()
        {
            return new OkObjectResult((await this.lookupdata.OrganisationsRoles
                            .GetAll()).ToList());
        }

        [HttpGet("PersonaRoles")]
        public async Task<IActionResult> PersonaRole()
        {
            return new OkObjectResult((await this.lookupdata.PersonaRoles
                            .GetAll()).ToList());
        }

        [HttpGet("ProductTypes")]
        public async Task<IActionResult> ProductType()
        {
            return new OkObjectResult((await this.lookupdata.ProductTypes
                            .GetAll()).ToList());
        }

        [HttpGet("Status")]
        public async Task<IActionResult> Status()
        {
            return new OkObjectResult((await this.lookupdata.Status
                            .GetAll()).ToList());
        }

        [HttpGet("Units")]
        public async Task<IActionResult> UnitQuantities()
        {
            return new OkObjectResult((await this.lookupdata.Units
                            .GetAll()).ToList());
        }
    }
}
