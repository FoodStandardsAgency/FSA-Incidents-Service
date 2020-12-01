using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Controllers
{

    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Authorize]
    public class LookupsController : ControllerBase
    {
        private readonly ILogger<LookupsController> log;
        private readonly ISIMSApplication simsApp;

        public LookupsController(ILogger<LookupsController> log, ISIMSApplication simsApp)
        {
            this.log = log;
            this.simsApp = simsApp;
        }

        [HttpGet("")]
        [ProducesResponseType(typeof(LookupsHost), 200)]
        [ProducesResponseType(500)]
        [SwaggerOperation(Summary = "All lookups")]
        public IActionResult GetAll()
        {
            return new OkObjectResult(this.simsApp.Lookups.GetAll());
        }

        [HttpGet("external")]
        [Authorize(Policy = "OnlineFormOnly")]
        public async Task<IActionResult> GetExternalLookups()
        {
            return new OkObjectResult(simsApp.Lookups.GetExternalLookups());
        }
    }
}
