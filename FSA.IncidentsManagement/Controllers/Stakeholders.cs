using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.SIMSManagerDb.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    public class StakeholdersController : ControllerBase
    {
        private readonly ILogger<StakeholdersController> log;
        private readonly ISIMSApplication simsApp;


        public StakeholdersController(ILogger<StakeholdersController> log, ISIMSApplication simsApp)
        {
            this.log = log;
            this.simsApp = simsApp;

        }


        [HttpGet("{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Get All Stakeholders")]
        [ProducesResponseType(typeof(List<SimsStakeholder>), 200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(typeof(string), 403)]
        [Produces("application/json")]
        public async Task<IActionResult> GetStakeholder([FromRoute] string incidentSignal, [FromRoute] int id)
        {

            return incidentSignal.ToLower() switch
            {
                IncidentOrSignalOrOnlineForm.Incidents => new OkObjectResult(await this.simsApp.Incidents.Stakeholders.GetAll(id)),
                IncidentOrSignalOrOnlineForm.Signals => new OkObjectResult(await this.simsApp.Signals.Stakeholders.GetAll(id)),
                _ => BadRequest("Unknown route")
            };
        }

        [HttpPost("{incidentSignal}")]
        [SwaggerOperation(Summary = "Add a new stakeholder to an incident")]
        [ProducesResponseType(typeof(SimsStakeholder), 200)]
        [ProducesResponseType(typeof(string), 403)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> AddStakeholder([FromRoute] string incidentSignal, [FromBody] SimsStakeholder stakeholder)
        {
            try
            {
                return incidentSignal.ToLower() switch
                {
                    IncidentOrSignalOrOnlineForm.Incidents => new OkObjectResult(await this.simsApp.Incidents.Stakeholders.Add(stakeholder.HostId, stakeholder)),
                    IncidentOrSignalOrOnlineForm.Signals => new OkObjectResult(await this.simsApp.Signals.Stakeholders.Add(stakeholder.HostId, stakeholder)),
                    _ => BadRequest("Unknown route")
                };
            }
            catch (ArgumentOutOfRangeException ex)
            {
                log.LogError(nameof(AddStakeholder), ex);
                return new BadRequestObjectResult(ex.Message);
            }

        }

        [HttpPut("{incidentSignal}")]
        [SwaggerOperation(Summary = "Update a stakeholder")]
        [ProducesResponseType(typeof(SimsStakeholder), 200)]
        [ProducesResponseType(typeof(string), 403)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateStakeholder([FromRoute] string incidentSignal, [FromBody] SimsStakeholder stakeholder)
        {
            try
            {

                return  incidentSignal.ToLower() switch
                {
                    IncidentOrSignalOrOnlineForm.Incidents => new OkObjectResult(await this.simsApp.Incidents.Stakeholders.Update(stakeholder)),
                    IncidentOrSignalOrOnlineForm.Signals => new OkObjectResult(await this.simsApp.Signals.Stakeholders.Update(stakeholder)),
                    _ => BadRequest("Unknown route")
                };
                
            }
            catch (ArgumentOutOfRangeException ex)
            {
                log.LogError(nameof(UpdateStakeholder), ex);
                return new BadRequestObjectResult(ex.Message);
            }

        }


        [HttpDelete("{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Remove a stakeholder to an incident")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(string), 403)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> RemoveStakeholder([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            try
            {

                var t = incidentSignal.ToLower() switch
                {
                    IncidentOrSignalOrOnlineForm.Incidents => this.simsApp.Incidents.Stakeholders.Remove(id),
                    IncidentOrSignalOrOnlineForm.Signals => this.simsApp.Signals.Stakeholders.Remove(id),
                    _ => throw new InvalidOperationException(),
                };
                await t;
                return new OkResult();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                log.LogError(nameof(RemoveStakeholder), ex);
                return BadRequest(ex.Message);
            }
            catch (InvalidOperationException)
            {
                log.LogError(nameof(RemoveStakeholder), $"Unknown route: {incidentSignal}");
                return BadRequest("Unknown route");

            }
        }
    }
}
