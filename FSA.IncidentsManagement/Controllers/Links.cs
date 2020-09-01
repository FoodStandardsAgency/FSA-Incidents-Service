using FSA.IncidentsManagement.Models;
using FSA.SIMSManagerDb.Contracts;
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
        private readonly ISimsDbHost simsDbHost;

        public LinksController(ILogger<LinksController> log, ISimsDbHost simsDbHost)
        {
            this.log = log;
            this.simsDbHost = simsDbHost;
        }

        [HttpGet("{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Get All links for incident/signal")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetLinks([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            return incidentSignal.ToLower() switch
            {
                "incident" => new OkObjectResult(await simsDbHost.Incidents.DashboardIncidentLinks(id)),
                "signal" => new OkObjectResult(await simsDbHost.Signals.DashboardIncidentLinks(id)),
                _ => new BadRequestObjectResult("Route not found")
            };
        }

        [HttpDelete("{incidentSignal}")]
        [SwaggerOperation(Summary = "Remove links for incident/signal")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> RemoveLink([FromRoute] string incidentSignal, [FromBody] UnlinkModel unlink)
        {
            return incidentSignal.ToLower() switch
            {
                "incident" => new OkObjectResult(await simsDbHost.Incidents.Links.Remove(unlink.FromId, unlink.ToId)),
                "signal" => new OkObjectResult(await simsDbHost.Signals.Links.Remove(unlink.FromId, unlink.ToId)),
                _ => new BadRequestObjectResult("Route not found")
            };
        }

        [HttpPost("{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Link two or more incidents")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddLink([FromRoute] string incidentSignal, [FromBody] LinkModel links)
        {
            return incidentSignal.ToLower() switch
            {
                "incident" => new OkObjectResult(await simsDbHost.Incidents.Links.Add(links.FromId, links.ToIds, links.Comment)),
                "signal" => new OkObjectResult(await simsDbHost.Signals.Links.Add(links.FromId, links.ToIds, links.Comment)),
                _ => new BadRequestObjectResult("Route not found")
            };
        }
    }
}
