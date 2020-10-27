using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sims.Application.Exceptions;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.SignalsManagement.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    public class SignalsController : ControllerBase
    {
        private readonly ILogger<SignalsController> log;
        private ISIMSApplication simsApp;

        public SignalsController(ILogger<SignalsController> log, ISIMSApplication simsApp)
        {
            this.log = log;
            this.simsApp = simsApp;
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get Signal by id", Description = "Get Signal by id")]
        [ProducesResponseType(typeof(SimsSignal), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetSignal(int id)
        {
            if (id == 0) return BadRequest("No signal Id was passed");
            return new OkObjectResult(await this.simsApp.Signals.Get(id));

        }

        [HttpPut()]
        [SwaggerOperation(Summary = "Replace an Signal", Description = "Replaces a Signal")]
        [ProducesResponseType(typeof(SimsSignal), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateSignal([FromBody, SwaggerParameter("Updated Signal", Required = true)] SimsSignal signal)
        {
            var updatedSignal = await this.simsApp.Signals.Update(signal);
            return new OkObjectResult(updatedSignal);
        }

        [HttpPost()]
        [SwaggerOperation(Summary = "Create an Signal", Description = "Creates a new Signal")]
        [ProducesResponseType(typeof(SimsSignal), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> CreateSignal([FromBody, SwaggerParameter("Signal", Required = true)] SimsSignal signal)
        {
            var createdSignal = await simsApp.Signals.Add(signal);
            return new OkObjectResult(createdSignal);
        }

        [HttpPost("Status/{id}/{statusId}")]
        [SwaggerOperation(Summary = "Update status of an Signal", Description = "Update status of an Signal")]
        [ProducesResponseType(typeof(SimsSignal), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateSignalStatus([FromRoute] int id, [FromRoute] int statusId)
        {
            await simsApp.Signals.UpdateStatus(id, statusId);
            return new OkResult();
        }

        [HttpPost("LeadOfficer")]
        [SwaggerOperation(Summary = "Update Signal(s) lead officer", Description = "Update Signal(s) lead officer")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateSignalLeadOfficer([FromBody, SwaggerParameter("Update Lead officer entries", Required = true)] UpdateLeadOfficerModel officer)
        {
            await simsApp.Signals.UpdateLeadOfficer(officer.Ids, officer.Officer);
            return Ok();
        }


        [HttpPost("Dashboard")]
        [SwaggerOperation(Summary = "Signals dashboard search", Description = "Signals dashboard search")]
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

        [HttpPost("Close/NoIncident")]
        [SwaggerOperation(Summary = "Close no incident", Description = "Close no incident")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> CloseNoIncident(SimsSignalCloseNoIncident closeNoIncident)
        {
            await this.simsApp.Signals.CloseNoIncident(closeNoIncident);
            return this.Ok();
        }

        [HttpPost("Close/Create")]
        [SwaggerOperation(Summary = "Close create incident", Description = "Close Create incident")]
        [ProducesResponseType(typeof(IncidentIdViewModel), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> CloseCreateIncident(SimsSignalCloseCreateIncident closeCreate)
        {
            var incidentId = await this.simsApp.Signals.CloseCreateIncident(closeCreate);
            return new OkObjectResult(new IncidentIdViewModel { IncidentId = incidentId });

        }

        [HttpPost("Close/Link")]
        [SwaggerOperation(Summary = "Close link incident", Description = "Close link incident")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> CloseLinkIncident(SimsSignalCloseLinkIncident closeLink)
        {
            try
            {
                await this.simsApp.Signals.CloseLinkIncident(closeLink);
                return this.Ok();
            }
            catch(SIMSException ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("Sensitive")]
        [SwaggerOperation(Summary = "Signals sensitive info")]
        [ProducesResponseType(typeof(IncidentDashboardItem), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateSignalSensitiveInfo(SensitiveInfoViewModel sensitiveInfo)
        {
            await this.simsApp.Signals.UpdateSensitiveInfoStatus(sensitiveInfo.HostId, sensitiveInfo.IsSensitive);
            return new OkResult();
        }
    }
}
