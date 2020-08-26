using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    public class IncidentsController : ControllerBase
    {
        private readonly ILogger<IncidentsController> log;
        private readonly ISIMSManager fsaData;
        private readonly IFSAAttachments attachments;

        public IncidentsController(ILogger<IncidentsController> log, ISIMSManager fsaData, IFSAAttachments attachments)
        {
            this.log = log;
            this.fsaData = fsaData;
            this.attachments = attachments;
        }

        [HttpGet()]
        [SwaggerOperation(Summary = "Get incident by id")]
        [ProducesResponseType(typeof(IncidentsDisplayModel), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetIncident(int id)
        {
            if (id == 0) return BadRequest("No Incident Id was passed");
            return new OkObjectResult(await this.fsaData.Incidents.GetDisplayItem(id));
        }

        [HttpPut()]
        [SwaggerOperation(Summary = "Replace an incident")]
        [ProducesResponseType(typeof(BaseIncident), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateIncident([FromBody, SwaggerParameter("Updated Incident", Required = true)] IncidentUpdateModel incident)
        {

            return new OkObjectResult(await this.fsaData.Incidents.Update(incident.ToClient()));
        }

        [HttpPost()]
        [SwaggerOperation(Summary = "Create an incident")]
        [ProducesResponseType(typeof(BaseIncident), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> CreateIncident([FromBody, SwaggerParameter("Create Incident", Required = true)] IncidentCreateModel incident)
        {
            return new OkObjectResult(await this.fsaData.Incidents.Add(incident.ToClient()));
        }

        [HttpPost("Classification/{id}")]
        [SwaggerOperation(Summary = "Update classification of an incident")]
        [ProducesResponseType(typeof(BaseIncident), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateClassification([FromRoute] int id, [Required] int classificationId)
        {
            return new OkObjectResult(await this.fsaData.Incidents.UpdateClassification(id, classificationId));
        }

        [HttpPost("Status/{id}")]
        [SwaggerOperation(Summary = "Update status of an incident")]
        [ProducesResponseType(typeof(BaseIncident), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateStatus([FromRoute] int id, [Required] int statusId)
        {
            return new OkObjectResult(await this.fsaData.Incidents.UpdateStatus(id, statusId));
        }

        [HttpPost("CloseAll")]
        [SwaggerOperation(Summary = "Close list of incidents")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> CloseAll([Required] int[] incidentIds)
        {
            await this.fsaData.Incidents.BulkClose(incidentIds);
            return new OkResult();
        }

        [HttpPost("LeadOfficer")]
        [SwaggerOperation(Summary = "Update incident(s) lead officer")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateLeadOfficer([FromBody, SwaggerParameter("Update Lead officer entries", Required = true)] UpdateLeadOfficer officer)
        {
            await this.fsaData.Incidents.AssignLeadOfficer(officer.IncidentIds, officer.Officer);
            return new OkResult();
        }

    }
}
