using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sims.Application.Exceptions;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
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

        [HttpGet()]
        [SwaggerOperation(Summary = "Get Signal by id")]
        [ProducesResponseType(typeof(SimsSignal), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetSignal(int id)
        {
            if (id == 0) return BadRequest("No signal Id was passed");
            return new OkObjectResult(null);
        }

        [HttpPut()]
        [SwaggerOperation(Summary = "Replace an Signal")]
        [ProducesResponseType(typeof(SimsSignal), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateSignal([FromBody, SwaggerParameter("Updated Signal", Required = true)] SimsSignal signal)
        {
            return new OkObjectResult(null);
        }

        [HttpPost()]
        [SwaggerOperation(Summary = "Create an Signal")]
        [ProducesResponseType(typeof(SimsSignal), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> CreateSignal([FromBody, SwaggerParameter("Create Signal", Required = true)] SimsSignal signal)
        {

            return new OkObjectResult("");
        }

        [HttpPost("Status/{id}")]
        [SwaggerOperation(Summary = "Update status of an Signal")]
        [ProducesResponseType(typeof(SimsSignal), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateSignalStatus([FromRoute] int id, [Required] int statusId)
        {
            return new OkObjectResult(null);
        }

        [HttpPost("LeadOfficer")]
        [SwaggerOperation(Summary = "Update Signal(s) lead officer")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateSignalLeadOfficer([FromBody, SwaggerParameter("Update Lead officer entries", Required = true)] UpdateLeadOfficerModel officer)
        {
           // await this.simsApp.Signals.AssignLeadOfficer(officer.SignalIds, officer.Officer);
            return new OkResult();
        }


        [HttpPost("Promote/{id}")]
        [SwaggerOperation(Summary = "Update Signal(s) lead officer")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> PromoteToSignal([FromRoute] int id)
        {
            // await this.simsApp.Signals.AssignLeadOfficer(officer.SignalIds, officer.Officer);
            return new OkResult();
        }
    }
}
