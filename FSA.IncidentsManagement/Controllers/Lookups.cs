﻿using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpGet("")]
        [ProducesResponseType(typeof(LookupsHost), 200)]
        [ProducesResponseType(500)]
        [SwaggerOperation(Summary = "All The lookups in the WORLD")]
        public IActionResult GetAll()
        {
            return new OkObjectResult(this.lookupdata.GetAll());
        }
    }
}
