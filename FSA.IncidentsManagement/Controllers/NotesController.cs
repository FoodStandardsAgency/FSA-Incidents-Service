using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.BusinessData.MetadataModel;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Controllers
{

    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    public class NotesController : ControllerBase
    {
        private readonly ILogger<NotesController> log;
        private readonly ISIMSApplication simsApp;

        public NotesController(ILogger<NotesController> log, ISIMSApplication simsApp)
        {
            this.log = log;
            this.simsApp = simsApp;
        }

        [HttpPost("{incidentSignal}")]
        [SwaggerOperation(Summary = "Add note to an incident/signal")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddNote([FromRoute] string incidentSignal, [FromBody, SwaggerParameter(Required = true)] SimsCommentModel addIncident)
        {
            try
            {
                _ = incidentSignal.ToLower() switch
                {
                    IncidentOrSignal.Incidents => await this.simsApp.Incidents.Notes.Add(addIncident.HostId, addIncident.Note),
                    IncidentOrSignal.Signals => await this.simsApp.Signals.Notes.Add(addIncident.HostId, addIncident.Note),
                    _ => throw new InvalidOperationException()
            };
                return new OkResult();
            }
            catch (InvalidOperationException)
            {
                log.LogError(nameof(AddNote), $"Unknown route: {incidentSignal}");
                return BadRequest("Unknown route");

            }

        }

        [HttpGet("{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Get notes for an incident/signal")]
        [ProducesResponseType(typeof(IEnumerable<SimsNote>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetNotes([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            try
            {
                _ = incidentSignal.ToLower() switch
                {
                    IncidentOrSignal.Incidents => await this.simsApp.Incidents.Notes.GetAll(id),
                    IncidentOrSignal.Signals => await this.simsApp.Signals.Notes.GetAll(id),
                    _ => throw new InvalidOperationException()
                };
                return new OkResult();
            }
            catch (InvalidOperationException)
            {
                log.LogError(nameof(GetNotes), $"Unknown route: {incidentSignal}");
                return BadRequest("Unknown route");

            }
        }
    }
}
