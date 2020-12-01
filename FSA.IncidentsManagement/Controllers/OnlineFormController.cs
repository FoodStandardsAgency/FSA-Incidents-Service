using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Graph;
using Sims.Application.Exceptions;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    public class OnlineFormController : ControllerBase
    {
        private ILogger<OnlineFormController> log;
        private ISIMSApplication simsApp;

        public OnlineFormController(ILogger<OnlineFormController> log, ISIMSApplication simsApp)
        {
            this.log = log;
            this.simsApp = simsApp;
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get Online form by id", Description = "Get Online form by id")]
        [ProducesResponseType(typeof(SimsOnlineForm), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetOnlineForm(int id)
        {
            var result = await this.simsApp.OnlineForms.Get(id);
            return new OkObjectResult(result);
        }

        [HttpPut()]
        [SwaggerOperation(Summary = "Replace an Online form", Description = "Replaces an Online form")]
        [ProducesResponseType(typeof(SimsOnlineForm), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateOnlineForm([FromBody, SwaggerParameter("Updated Signal", Required = true)] SimsOnlineForm onlineForm)
        {
            try
            {
                var result = await simsApp.OnlineForms.Update(onlineForm);
                return new OkObjectResult(result);
            }
            catch (SIMSException ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }

        }

        [HttpPost("Dashboard")]
        [SwaggerOperation(Summary = "OnlineForm dashboard search", Description = "OnlineForm dashboard search")]
        [ProducesResponseType(typeof(PagedResultsViewModel<SimsOnlineFormDashboardItem>), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetOnlineDashboard(DashboardSearchViewModel dashboard)
        {
            try
            {

                if (dashboard.PageNo < 1 || dashboard.PageSize < 0)
                    return new OkObjectResult(new
                    {
                        Results = Enumerable.Empty<SignalDashboardItem>().ToList(),
                        TotalRecords = 0
                    });

                var dashBoard = dashboard.PageSize.HasValue && dashboard.PageSize > 0
                                                    ? await this.simsApp.OnlineForms.DashboardSearch(search: dashboard.Search ?? "", startPage: dashboard.PageNo, pageSize: dashboard.PageSize.Value)
                                                    : await this.simsApp.OnlineForms.DashboardSearch(search: dashboard.Search ?? "", startPage: dashboard.PageNo);
                return new OkObjectResult(new PagedResultsViewModel<SimsOnlineFormDashboardItem>
                {
                    Results = dashBoard.ToList(),
                    TotalRecords = dashBoard.TotalResults
                });
            }
            catch (SIMSException ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        [HttpPost("Close/Create")]
        [SwaggerOperation(Summary = "Close form create incident", Description = "Close form  Create incident")]
        [ProducesResponseType(typeof(IncidentIdViewModel), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> CloseOnlineFormCreateIncident(SimsCloseCreateIncident closeCreate)
        {
            var incidentId = await this.simsApp.OnlineForms.CloseCreateIncident(closeCreate.HostId, closeCreate.ReasonNote);
            return new OkObjectResult(new IncidentIdViewModel { IncidentId = incidentId });
        }

        [HttpPost("Close/NoIncident")]
        [SwaggerOperation(Summary = "Close form no incident", Description = "Close form no incident")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> CloseOnlineFormNoIncident(SimsCloseCreateIncident closeCreate)
        {
            await this.simsApp.OnlineForms.CloseNoIncident(closeCreate.HostId, closeCreate.ReasonNote);
            return Ok();
        }



    }
}
