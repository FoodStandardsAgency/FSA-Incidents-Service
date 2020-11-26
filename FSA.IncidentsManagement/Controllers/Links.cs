using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections;
using System.Collections.Generic;
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
        [SwaggerOperation(Summary = "Get All links for incident/signal", Description = "Get All links for incident/signal")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(string), 403)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetLinks([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            return incidentSignal.ToLower() switch
            {
                IncidentOrSignalOrOnlineForm.Incidents => new OkObjectResult(await simsApp.Incidents.DashboardLinks(id)),
                IncidentOrSignalOrOnlineForm.Signals => new OkObjectResult(await simsApp.Signals.DashboardLinks(id)),
                _ => BadRequest("Route not found")
            };
        }

        [HttpGet("Cases/{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Get linked cases for incident/signal", Description ="Get linked cases for incident/signal")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(List<SimsLinkedCase>), 403)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetLinkedCases([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            return incidentSignal.ToLower() switch
            {
                IncidentOrSignalOrOnlineForm.Incidents => new OkObjectResult(await simsApp.Incidents.GetLinkedSignals(id)),
                IncidentOrSignalOrOnlineForm.Signals => new OkObjectResult(await simsApp.Signals.GetLinkedIncidents(id)),
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
                IncidentOrSignalOrOnlineForm.Incidents => new OkObjectResult(await simsApp.Incidents.Links.Remove(unlink.FromId, unlink.ToId)),
                IncidentOrSignalOrOnlineForm.Signals => new OkObjectResult(await simsApp.Signals.Links.Remove(unlink.FromId, unlink.ToId)),
                _ => BadRequest("Route not found")
            };
        }

        [HttpPost("{incidentSignal}")]
        [SwaggerOperation(Summary = "Link two or more incidents")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(string), 403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddLink([FromRoute] string incidentSignal, [FromBody] LinkViewModel links)
        {
            return incidentSignal.ToLower() switch
            {
                IncidentOrSignalOrOnlineForm.Incidents => new OkObjectResult(await simsApp.Incidents.Links.Add(links.FromId, links.ToIds, links.Comment)),
                IncidentOrSignalOrOnlineForm.Signals => new OkObjectResult(await simsApp.Signals.Links.Add(links.FromId, links.ToIds, links.Comment)),
                _ => BadRequest("Route not found")
            };
        }


    }
}
