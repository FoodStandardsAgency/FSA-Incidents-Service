using AutoMapper;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
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
        private readonly IMapper mapper;
        private readonly ISIMSApplication simsApp;


        public IncidentsController(ILogger<IncidentsController> log, IMapper mapper, ISIMSApplication simsApp)
        {
            this.log = log;
            this.mapper = mapper;
            this.simsApp = simsApp;
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get incident by id")]
        [ProducesResponseType(typeof(IncidentsDisplayModel), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetIncident(int id)
        {
            if (id == 0) return BadRequest("No Incident Id was passed");
            return new OkObjectResult(await this.simsApp.Incidents.GetDisplayItem(id));
        }

        [HttpPut()]
        [SwaggerOperation(Summary = "Replace an incident")]
        [ProducesResponseType(typeof(BaseIncident), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateIncident([FromBody, SwaggerParameter("Updated Incident", Required = true)] IncidentUpdateModel incident)
        {
            var mappedIncindet = mapper.Map<IncidentUpdateModel, BaseIncident>(incident);
            return new OkObjectResult(await this.simsApp.Incidents.Update(mappedIncindet));
        }

        [HttpPost()]
        [SwaggerOperation(Summary = "Create an incident")]
        [ProducesResponseType(typeof(BaseIncident), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> CreateIncident([FromBody, SwaggerParameter("Create Incident", Required = true)] IncidentCreateModel incident)
        {
            return new OkObjectResult(await this.simsApp.Incidents.Add(incident.ToClient()));
        }

        [HttpPost("Classification/{id}/{classificationId}")]
        [SwaggerOperation(Summary = "Update classification of an incident")]
        [ProducesResponseType(typeof(BaseIncident), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateClassification([FromRoute] int id, [FromRoute] int classificationId)
        {
            return new OkObjectResult(await this.simsApp.Incidents.UpdateClassification(id, classificationId));
        }

        [HttpPost("Status/{id}/{statusId}")]
        [SwaggerOperation(Summary = "Update status of an incident")]
        [ProducesResponseType(typeof(BaseIncident), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateStatus([FromRoute] int id, [FromRoute] int statusId)
        {
            return new OkObjectResult(await this.simsApp.Incidents.UpdateStatus(id, statusId));
        }

        [HttpPost("CloseAll")]
        [SwaggerOperation(Summary = "Close list of incidents")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> CloseAll([Required] IncidentCloseViewModel incidentClose)
        {
            await this.simsApp.Incidents.BulkClose(incidentClose.IncidentIds);
            return new OkResult();
        }

        [HttpPost("LeadOfficer")]
        [SwaggerOperation(Summary = "Update incident(s) lead officer")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateLeadOfficer([FromBody, SwaggerParameter("Update Lead officer entries", Required = true)] UpdateLeadOfficerModel officer)
        {
            await this.simsApp.Incidents.UpdateLeadOfficer(officer.Ids, officer.Officer);
            return new OkResult();
        }

        [HttpPost("Dashboard")]
        [SwaggerOperation(Summary = "Incident dashboard search")]
        [ProducesResponseType(typeof(IncidentDashboardView), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetIncidentDashboard(DashboardSearchViewModel dashboard)
        {
            log.LogInformation($"search terms : {dashboard.Search} {dashboard.PageNo} {dashboard.PageSize}", "GetIncidentsDashboard");

            if (dashboard.PageNo < 1 || dashboard.PageSize < 0)
                return new OkObjectResult(new PagedResult<IncidentDashboardView>(Enumerable.Empty<IncidentDashboardView>(), 0));

            var dashBoard = dashboard.PageSize.HasValue && dashboard.PageSize>0 ? await this.simsApp.Incidents.DashboardSearch(search: dashboard.Search ?? "", startPage: dashboard.PageNo, pageSize: dashboard.PageSize.Value) 
                                                : await this.simsApp.Incidents.DashboardSearch(search: dashboard.Search ?? "", startPage: dashboard.PageNo);
            return new OkObjectResult(new
            {
                Results = dashBoard,
                TotalRecords = dashBoard.TotalResults
            });
        }

    }
}
