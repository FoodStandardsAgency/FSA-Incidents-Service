using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.ModelValidators;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace FSA.IncidentsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class IncidentsController : ControllerBase
    {
        private readonly ILogger<IncidentsController> log;
        private readonly ISIMSManager fsaData;

        public IncidentsController(ILogger<IncidentsController> log, ISIMSManager fsaData)
        {
            this.log = log;
            this.fsaData = fsaData;
        }

        [HttpGet()]
        [SwaggerOperation(Summary = "Get incident by id")]
        [ProducesResponseType(typeof(IncidentsDisplayModel), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetIncident(int id)
        {
            if (id == 0) return BadRequest("No Incident Id was passed.");
            return new OkObjectResult(await this.fsaData.Incidents.GetDisplayItem(id));
        }

        [HttpGet("Dashboard")]
        [SwaggerOperation(Summary = "Incident dashboard search")]
        [ProducesResponseType(typeof(IncidentDashboardView), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetIncidentDashboard(string search, int pageNo, int? pageSize)
        {
            log.LogInformation($"search terms : {search} {pageNo} {pageSize}", "GetIncidentsDashboard");

            if (pageNo < 1 || pageSize<1  )
                return new OkObjectResult(new PagedResult<IncidentDashboardView>(Enumerable.Empty<IncidentDashboardView>(), 0));
            
            var dashBoard = pageSize.HasValue ? await this.fsaData.Incidents.DashboardSearch(search: search ?? "", startPage: pageNo, pageSize: pageSize.Value) :await this.fsaData.Incidents.DashboardSearch(search: search?? "", startPage: pageNo);
            return new OkObjectResult(new { Results=dashBoard, 
                                            TotalRecords =dashBoard.TotalResults});
        }

        [HttpPut()]
        [SwaggerOperation(Summary = "Replace an existing incident")]
        [ProducesResponseType(typeof(BaseIncident), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateIncident([FromBody, SwaggerParameter("Updated Incident", Required = true)] IncidentUpdateModel incident)
        {

            return new OkObjectResult(await this.fsaData.Incidents.Update(incident.ToClient()));
        }

        [HttpPost()]
        [SwaggerOperation(Summary = "Create an existing incident")]
        [ProducesResponseType(typeof(BaseIncident), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> CreateIncident([FromBody, SwaggerParameter("Create Incident", Required = true)] IncidentCreateModel incident)
        {
            return new OkObjectResult(await this.fsaData.Incidents.Add(incident.ToClient()));
        }

        [HttpPost("Classification")]
        [SwaggerOperation(Summary = "Update classification of an incident")]
        [ProducesResponseType(typeof(BaseIncident), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]

        public async Task<IActionResult> UpdateClassification([Required] int incidentId, [Required] int classificationId)
        {
            return new OkObjectResult(await this.fsaData.Incidents.UpdateClassification(incidentId, classificationId));
        }

        [HttpPost("Status")]
        [SwaggerOperation(Summary = "Update status of an incident")]
        [ProducesResponseType(typeof(BaseIncident), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateStatus([Required] int incidentId, [Required] int statusId)
        {
            return new OkObjectResult(await this.fsaData.Incidents.UpdateStatus(incidentId, statusId));
        }

        [HttpPost("CloseAll")]
        [SwaggerOperation(Summary = "Update status of an incident")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> CloseAll([Required] int[] incidentIds)
        {
            await this.fsaData.Incidents.BulkClose(incidentIds);
            return new OkResult();
        }

        [HttpPost("LeadOfficer")]
        [SwaggerOperation(Summary = "Assign lead officer.")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateLeadOfficer([FromBody, SwaggerParameter("Update Lead officer entries", Required =true)] UpdateLeadOfficer officer)
        {
            await this.fsaData.Incidents.AssignLeadOfficer(officer.IncidentIds, officer.Officer);
            return new OkResult();
        }

        [HttpPost("AddLinks")]
        [SwaggerOperation(Summary = "Link two or moreincidents.")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddIncidentLink([FromBody] LinkIncidents addIncident)
        {
            await this.fsaData.Incidents.AddLinks(addIncident.FromIncidentId, addIncident.ToIncidentIds, addIncident.Comment);
            return new OkResult();
        }

        [HttpPost("RemoveLink")]
        [SwaggerOperation(Summary = "Remove link between two incidents.")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> RemoveIncidentLink([FromBody] UnlinkIncident removeIncident)
        {
            await this.fsaData.Incidents.RemoveLink(removeIncident.FromIncidentId, removeIncident.ToIncidentId);
            return new OkResult();
        }



        [HttpGet("GetIncidentLinks")]
        [SwaggerOperation(Summary = "Dashboard info for an incidents links")]
        [ProducesResponseType(typeof(IEnumerable<IncidentDashboardView>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetIncidentLinks([FromQuery] int incidentId)
        {
            return new OkObjectResult(await this.fsaData.Incidents.DashboardIncidentLinks(incidentId));
        }

        [HttpPost("AddNote")]
        [SwaggerOperation(Summary = "Add note to an incident.")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddNote([FromBody, SwaggerParameter(Required=true)] IncidentComment addIncident)
        {
            await this.fsaData.Incidents.AddNote(addIncident.IncidentId, addIncident.Note);
            return new OkResult();
        }

        [HttpGet("GetNotes")]
        [SwaggerOperation(Summary = "Get notes for an incident")]
        [ProducesResponseType(typeof(IEnumerable<IncidentNote>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetNotes([FromQuery] int incidentId)
        {
            return new OkObjectResult(await this.fsaData.Incidents.GetNotes(incidentId));
        }

    }
}
