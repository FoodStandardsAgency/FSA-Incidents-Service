using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Domain;
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
    public class LinksController : ControllerBase
    {
        private readonly ILogger<LinksController> log;
        private readonly ISIMSApplication simsApp;

        public LinksController(ILogger<LinksController> log, ISIMSApplication simsApp)
        {
            this.log = log;
            this.simsApp = simsApp;
        }

        [HttpGet("{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Get All links for incident/signal")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(string), 403)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetLinks([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            return incidentSignal.ToLower() switch
            {
                IncidentOrSignal.Incidents => new OkObjectResult(await simsApp.Incidents.DashboardLinks(id)),
                IncidentOrSignal.Signals => new OkObjectResult(await simsApp.Signals.DashboardLinks(id)),
                _ => BadRequest("Route not found")
            };
        }

        [HttpDelete("{incidentSignal}")]
        [SwaggerOperation(Summary = "Remove links for incident/signal")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(typeof(string), 403)]
        [Produces("application/json")]
        public async Task<IActionResult> RemoveLink([FromRoute] string incidentSignal, [FromBody] UnlinkModel unlink)
        {
            return incidentSignal.ToLower() switch
            {
                IncidentOrSignal.Incidents => new OkObjectResult(await simsApp.Incidents.Links.Remove(unlink.FromId, unlink.ToId)),
                IncidentOrSignal.Signals => new OkObjectResult(await simsApp.Signals.Links.Remove(unlink.FromId, unlink.ToId)),
                _ => BadRequest("Route not found")
            };
        }

        [HttpPost("{incidentSignal}")]
        [SwaggerOperation(Summary = "Link two or more incidents")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(string), 403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddLink([FromRoute] string incidentSignal, [FromBody] LinkModel links)
        {
            return incidentSignal.ToLower() switch
            {
                IncidentOrSignal.Incidents => new OkObjectResult(await simsApp.Incidents.Links.Add(links.FromId, links.ToIds, links.Comment)),
                IncidentOrSignal.Signals => new OkObjectResult(await simsApp.Signals.Links.Add(links.FromId, links.ToIds, links.Comment)),
                _ => BadRequest("Route not found")
            };
        }
    }
}
