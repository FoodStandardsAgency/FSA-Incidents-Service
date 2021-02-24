using AutoMapper;
using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
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
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Authorize]
    public class NotesController : ControllerBase
    {
        private readonly ILogger<NotesController> log;
        private readonly IMapper mapper;
        private readonly ISIMSApplication simsApp;

        public NotesController(ILogger<NotesController> log, IMapper mapper, ISIMSApplication simsApp)
        {
            this.log = log;
            this.mapper = mapper;
            this.simsApp = simsApp;
        }

        [HttpPost("{incidentSignal}")]
        [SwaggerOperation(Summary = "Add note to an incident/signal")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(string), 403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddNote([FromRoute] string incidentSignal, [FromBody, SwaggerParameter(Required = true)] SimsNoteCreateModel addIncident)
        {
            try
            {
                _ = incidentSignal.ToLower() switch
                {
                    IncidentOrSignalOrOnlineForm.Incidents => await this.simsApp.Incidents.Notes.Add(addIncident.HostId, addIncident.Note, addIncident.Tags.Sum()),
                    IncidentOrSignalOrOnlineForm.Signals => await this.simsApp.Signals.Notes.Add(addIncident.HostId, addIncident.Note, addIncident.Tags.Sum()),
                    IncidentOrSignalOrOnlineForm.OnlineForm => await this.simsApp.OnlineForms.Notes.Add(addIncident.HostId, addIncident.Note, addIncident.Tags.Sum()),
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

        [HttpPatch("{incidentSignal}")]
        [SwaggerOperation(Summary = "Update note to an incident/signal")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(string), 403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateNote([FromRoute] string incidentSignal, [FromBody, SwaggerParameter(Required = true)] SimsNoteUpdateModel updatedNote)
        {
            try
            {
                var tsk = incidentSignal.ToLower() switch
                {
                    IncidentOrSignalOrOnlineForm.Incidents => this.simsApp.Incidents.Notes.Update(updatedNote.NoteId, updatedNote.Tags.Sum()),
                    IncidentOrSignalOrOnlineForm.Signals => this.simsApp.Signals.Notes.Update(updatedNote.NoteId, updatedNote.Tags.Sum()),
                    IncidentOrSignalOrOnlineForm.OnlineForm => this.simsApp.OnlineForms.Notes.Update(updatedNote.NoteId, updatedNote.Tags.Sum()),
                    _ => throw new InvalidOperationException()
                };

                await tsk;
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
        [ProducesResponseType(typeof(IEnumerable<SimsNoteViewModel>), 200)]
        [ProducesResponseType(typeof(string), 403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetNotes([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            try
            {
                var allNotes = incidentSignal.ToLower() switch
                {
                    IncidentOrSignalOrOnlineForm.Incidents => await this.simsApp.Incidents.Notes.GetAll(id),
                    IncidentOrSignalOrOnlineForm.Signals => await this.simsApp.Signals.Notes.GetAll(id),
                    IncidentOrSignalOrOnlineForm.OnlineForm => await this.simsApp.OnlineForms.Notes.GetAll(id),
                    _ => throw new InvalidOperationException()
                };

                var clientNotes = mapper.Map<List<SimsNoteViewModel>>(allNotes);
                return new OkObjectResult(clientNotes);

            }
            catch (InvalidOperationException)
            {
                log.LogError(nameof(GetNotes), $"Unknown route: {incidentSignal}");
                return BadRequest("Unknown route");

            }
        }
    }
}
