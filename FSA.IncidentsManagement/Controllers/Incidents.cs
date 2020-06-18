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
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace FSA.IncidentsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class IncidentsController : ControllerBase
    {
        private readonly ILogger<IncidentsController> log;
        private readonly IFSAIncidentsData fsaData;

        public IncidentsController(ILogger<IncidentsController> log, IFSAIncidentsData fsaData)
        {
            this.log = log;
            this.fsaData = fsaData;
        }

        [HttpGet()]
        [SwaggerOperation(Summary ="Get incident by id")]
        [ProducesResponseType(typeof(IncidentsDisplayModel), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetIncident(int id)
        {
            return new OkObjectResult(await this.fsaData.Incidents.GetDisplayItem(id));
        }

        [HttpPut()]
        [SwaggerOperation(Summary ="Replace an existing incident")]
        [ProducesResponseType(typeof(Incident), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateIncident([FromBody, SwaggerParameter("Updated Incident", Required = true)] IncidentApiModel incident) {

            return new OkObjectResult(await this.fsaData.Incidents.UpdateIncident(incident.ToClient()));
        }

        [HttpPost()]
        [SwaggerOperation(Summary = "Create an existing incident")]
        [ProducesResponseType(typeof(Incident), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> CreateIncident([FromBody, SwaggerParameter("Create Incident", Required = true)] IncidentApiModel incident)
        {
            return new OkObjectResult(await this.fsaData.Incidents.Add(incident.ToClient()));
            
        }

        [HttpPost("Classification")]
        [SwaggerOperation(Summary = "Update classification of an incident")]
        [ProducesResponseType(typeof(Incident), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateClassification([Required] int incidentId, [Required] int classificationId)
        {
            return new OkObjectResult(await this.fsaData.Incidents.UpdateClassification(incidentId,classificationId));
        }

        [HttpPost("Status")]
        [SwaggerOperation(Summary = "Update status of an incident")]
        [ProducesResponseType(typeof(Incident), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateStatus([Required] int incidentId, [Required] int statusId)
        {
            return new OkObjectResult(await this.fsaData.Incidents.UpdateStatus(incidentId, statusId));
        }

        [HttpPost("LeadOfficer")]
        [SwaggerOperation(Summary = "Assign lead officer.")]
        [ProducesResponseType(typeof(Incident), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateStatus([Required] int incidentId, [Required]string officer)
        {
            return new OkObjectResult(await this.fsaData.Incidents.AssignLeadOfficer(incidentId, officer));
        }
    }
}
