﻿using System;
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
        [SwaggerOperation(Summary = "Get incident by id")]
        [ProducesResponseType(typeof(IncidentsDisplayModel), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetIncident(int id)
        {
            return new OkObjectResult(await this.fsaData.Incidents.GetDisplayItem(id));
        }

        [HttpGet("Dashboard")]
        [SwaggerOperation(Summary = "Incident dashboard search")]
        [ProducesResponseType(typeof(IncidentDashboardView), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetIncidentDashboard(string search, int pageNo, int? pageSize)
        {
            if (pageNo < 1)
                return new OkObjectResult(new PagedResult<IncidentDashboardView>(Enumerable.Empty<IncidentDashboardView>(), 0));

            var dashBoard = await this.fsaData.Incidents.DashboardSearch(search: search?? "", startPage: pageNo);
            return new OkObjectResult(new { Results=dashBoard, TotalRecords =dashBoard.TotalResults});
        }

        [HttpPut()]
        [SwaggerOperation(Summary = "Replace an existing incident")]
        [ProducesResponseType(typeof(Incident), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateIncident([FromBody, SwaggerParameter("Updated Incident", Required = true)] IncidentApiModel incident)
        {

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
            return new OkObjectResult(await this.fsaData.Incidents.UpdateClassification(incidentId, classificationId));
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
        public async Task<IActionResult> UpdateLeadOfficer([Required] int incidentId, [Required] string officer)
        {
            return new OkObjectResult(await this.fsaData.Incidents.AssignLeadOfficer(incidentId, officer));
        }

        [HttpPost("AddLink")]
        [SwaggerOperation(Summary = "Link two incidents.")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddIncidentLink([FromBody] LinkIncidents addIncident)
        {
            await this.fsaData.Incidents.AddLink(addIncident.FromIncidentId, addIncident.ToIncidentId, addIncident.Comment);
            return new OkResult();
        }

        [HttpGet("GetIncidentLinks")]
        [SwaggerOperation(Summary = "Dashboard info for an incidents links")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetIncidentLinks([FromQuery] int incidentId)
        {
            
            return new OkObjectResult(await this.fsaData.Incidents.DashboardIncidentLinks(incidentId));
        }

        [HttpPost("AddNote")]
        [SwaggerOperation(Summary = "Add note to an incident.")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddNote([FromBody] IncidentComment addIncident)
        {
            await this.fsaData.Incidents.AddNote(addIncident.IncidentId, addIncident.Note);
            return new OkResult();
        }

    }
}
