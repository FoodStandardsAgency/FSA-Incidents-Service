using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
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
    [Authorize]
    public class StakeholdersController : ControllerBase
    {
        private readonly ILogger<StakeholdersController> log;
        private readonly ISimsDbHost simsDbhost;

        public StakeholdersController(ILogger<StakeholdersController> log, ISimsDbHost simsDbhost)
        {
            this.log = log;
            this.simsDbhost = simsDbhost;
        }


        [HttpGet("{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Get All Stakeholders")]
        [ProducesResponseType(typeof(List<SimsStakeholder>), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetStakeholder([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            try
            {
                var stakeholders = incidentSignal.ToLower() switch
                {
                    "incident" => await this.simsDbhost.Incidents.Stakeholders.GetAll(id),
                    "signal" => await this.simsDbhost.Signals.Stakeholders.GetAll(id),
                    _ => throw new InvalidOperationException(),
                };

                return new OkObjectResult(stakeholders);
            }
            catch (InvalidOperationException ex)
            {
                log.LogError(nameof(GetStakeholder), $"Unknown route: {incidentSignal}");
                return BadRequest("Unknown route");

            }
        }

        [HttpPost("{incidentSignal}")]
        [SwaggerOperation(Summary = "Add a new stakeholder to an incident")]
        [ProducesResponseType(typeof(SimsStakeholder), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> AddStakeholder([FromRoute] string incidentSignal, [FromBody] SimsStakeholder stakeholder)
        {
            try
            {
                
                var newStakeholder = incidentSignal.ToLower() switch
                {
                    "incident" => await this.simsDbhost.Incidents.Stakeholders.Add(stakeholder.Id, stakeholder),
                    "signal" => await this.simsDbhost.Signals.Stakeholders.Add(stakeholder.Id, stakeholder),
                    _ => throw new InvalidOperationException(),
                };
                return new OkObjectResult(newStakeholder);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                log.LogError(nameof(AddStakeholder), $"Unknown route: {incidentSignal}");
                return BadRequest("Unknown route");

            }

        }

        [HttpPut("{incidentSignal}")]
        [SwaggerOperation(Summary = "Update a stakeholder")]
        [ProducesResponseType(typeof(SimsStakeholder), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateStakeholder([FromRoute] string incidentSignal, [FromBody] SimsStakeholder stakeholder)
        {
            try
            {

                var newStakeholder = incidentSignal.ToLower() switch
                {
                    "incident" => await this.simsDbhost.Incidents.Stakeholders.Update(stakeholder),
                    "signal" => await this.simsDbhost.Signals.Stakeholders.Update(stakeholder),
                    _ => throw new InvalidOperationException(),
                };
                return new OkObjectResult(newStakeholder);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                log.LogError(nameof(AddStakeholder), $"Unknown route: {incidentSignal}");
                return BadRequest("Unknown route");

            }
        }


        [HttpDelete("{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Remove a stakeholder to an incident")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> RemoveStakeholder([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            try
            {

                var t = incidentSignal.ToLower() switch
                {
                    "incident" =>  this.simsDbhost.Incidents.Stakeholders.Remove(id),
                    "signal" =>  this.simsDbhost.Signals.Stakeholders.Remove(id),
                    _ => throw new InvalidOperationException(),
                };
                await t;
                return new OkResult();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                log.LogError(nameof(AddStakeholder), $"Unknown route: {incidentSignal}");
                return BadRequest("Unknown route");

            }
        }
    }
}
