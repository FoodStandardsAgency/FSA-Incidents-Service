using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace FSA.IncidentsManagement.Controllers
{
    [Route("api/v1/Lookups")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class OLDLookupsController : ControllerBase
    {
        private readonly ILogger<OLDLookupsController> log;
        private readonly ILookupDataHost lookupdata;

        public OLDLookupsController(ILogger<OLDLookupsController> log, ILookupDataHost lookupdata)
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
