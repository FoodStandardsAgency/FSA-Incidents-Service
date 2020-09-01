using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Contracts;
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
        private readonly ISimsDbHost simsDbHost;

        public NotesController(ILogger<NotesController> log, ISimsDbHost fsaData)
        {
            this.log = log;
            this.simsDbHost = fsaData;
        }

        [HttpPost("{incidentSignal}")]
        [SwaggerOperation(Summary = "Add note to an incident/signal")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddNote([FromRoute] string incidentSignal, [FromBody, SwaggerParameter(Required = true)] IncidentComment addIncident)
        {
            try
            {
                _ = incidentSignal.ToLower() switch
                {
                    "incident" => await this.simsDbHost.Incidents.Notes.Add(addIncident.IncidentId, addIncident.Note),
                    "signal" => await this.simsDbHost.Signals.Notes.Add(addIncident.IncidentId, addIncident.Note),
                    _ => throw new InvalidOperationException()
            };
                return new OkResult();
            }
            catch (ArgumentOutOfRangeException ex)
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
                    "incident" => await this.simsDbHost.Incidents.Notes.GetAll(id),
                    "signal" => await this.simsDbHost.Signals.Notes.GetAll(id),
                    _ => throw new InvalidOperationException()
                };
                return new OkResult();
            }
            catch (InvalidOperationException ex)
            {
                log.LogError(nameof(GetNotes), $"Unknown route: {incidentSignal}");
                return BadRequest("Unknown route");

            }
        }
    }
}
