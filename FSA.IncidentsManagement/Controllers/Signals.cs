using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.SignalsManagement.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    public class SignalsController:ControllerBase
    {
        private readonly ILogger<SignalsController> log;
        private ISIMSApplication simsApp;

        public SignalsController(ILogger<SignalsController> log, ISIMSApplication simsApp)
        {
            this.log = log;
            this.simsApp = simsApp;
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get Signal by id")]
        [ProducesResponseType(typeof(SimsSignal), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetSignal([FromRoute]int id)
        {
            if (id == 0) return BadRequest("No signal Id was passed");
            return new OkObjectResult(await this.simsApp.Signals.Get(id));
            
        }

        [HttpPut()]
        [SwaggerOperation(Summary = "Replace an Signal")]
        [ProducesResponseType(typeof(SimsSignal), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateSignal([FromBody, SwaggerParameter("Updated Signal", Required = true)] SimsSignal signal)
        {
            var updatedSignal = await this.simsApp.Signals.Update(signal);
            return new OkObjectResult(updatedSignal);
        }

        [HttpPost()]
        [SwaggerOperation(Summary = "Create an Signal")]
        [ProducesResponseType(typeof(SimsSignal), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> CreateSignal([FromBody, SwaggerParameter("Create Signal", Required = true)] SimsSignal signal)
        {
            var createdSignal = await simsApp.Signals.Add(signal);
            return new OkObjectResult(createdSignal);
        }

        [HttpPost("Status/{id}/{statusId}")]
        [SwaggerOperation(Summary = "Update status of an Signal")]
        [ProducesResponseType(typeof(SimsSignal), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateSignalStatus([FromRoute] int id, [FromRoute] int statusId)
        {
            await simsApp.Signals.UpdateStatus(id, statusId);
            return new OkResult();
        }

        [HttpPost("LeadOfficer")]
        [SwaggerOperation(Summary = "Update Signal(s) lead officer")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateSignalLeadOfficer([FromBody, SwaggerParameter("Update Lead officer entries", Required = true)] UpdateLeadOfficerModel officer)
        {
            await simsApp.Signals.UpdateLeadOfficer(officer.Ids, officer.Officer);
            return new OkResult();
        }


        [HttpPost("Promote/{id}")]
        [SwaggerOperation(Summary = "Update Signal(s) lead officer")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> PromoteToSignal([FromRoute] int id)
        {
            await this.simsApp.Signals.PromoteToIncident(id);
            return new OkResult();
        }

        [HttpPost("Dashboard")]
        [SwaggerOperation(Summary = "Incident dashboard search")]
        [ProducesResponseType(typeof(SignalDashboardItem), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetSignalDashboard(DashboardSearchViewModel dashboard)
        {
            log.LogInformation($"search terms : {dashboard.Search} {dashboard.PageNo} {dashboard.PageSize}", "GetIncidentsDashboard");

            if (dashboard.PageNo < 1 || dashboard.PageSize < 0)
                return new OkObjectResult(new
                {
                    Results = Enumerable.Empty<SignalDashboardItem>(),
                    TotalRecords = 0
                });

            var dashBoard = dashboard.PageSize.HasValue && dashboard.PageSize > 0 
                                                ? await this.simsApp.Signals.DashboardSearch(search: dashboard.Search ?? "", startPage: dashboard.PageNo, pageSize: dashboard.PageSize.Value)
                                                : await this.simsApp.Signals.DashboardSearch(search: dashboard.Search ?? "", startPage: dashboard.PageNo);
            return new OkObjectResult(new
            {
                Results = dashBoard,
                TotalRecords = dashBoard.TotalResults
            });
        }
    }
}
