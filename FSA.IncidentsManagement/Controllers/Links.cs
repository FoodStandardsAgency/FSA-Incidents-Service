using FSA.IncidentsManagement.Models;
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
    [Authorize]
    public class LinksController : ControllerBase
    {
        private readonly ILogger<LinksController> log;

        public LinksController(ILogger<LinksController> log)
        {
            this.log = log;
        }

        [HttpGet("{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Get All links for incident/signal")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetLinks([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            return new OkResult();
        }

        [HttpDelete("{incidentSignal}")]
        [SwaggerOperation(Summary = "Remove links for incident/signal")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> RemoveLink([FromRoute] string incidentSignal, [FromBody] UnlinkModel unlink)
        {
            return new OkResult();
        }

        [HttpPost("{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Link two or moreincidents")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddLink([FromRoute] string incidentSignal, [FromBody] LinkModel links)
        {
            return new OkResult();
        }
    }
}
