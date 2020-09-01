using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
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
        private readonly ISimsDbHost simsDbHost;

        public LookupsController(ILogger<LookupsController> log, ISimsDbHost simsDbHost)
        {
            this.log = log;
            this.simsDbHost = simsDbHost;
        }

        [HttpGet("")]
        [ProducesResponseType(typeof(LookupsHost), 200)]
        [ProducesResponseType(500)]
        [SwaggerOperation(Summary = "All lookups")]
        public IActionResult GetAll()
        {
            return new OkObjectResult(this.simsDbHost.Lookups.GetAll());
        }
    }
}
