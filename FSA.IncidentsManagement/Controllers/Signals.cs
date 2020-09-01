using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Controllers
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
        [SwaggerOperation(Summary = "Get incident by id")]
        [ProducesResponseType(typeof(SimsSignal), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetSignal(int id)
        {
            if (id == 0) return BadRequest("No signal Id was passed");
            return new OkObjectResult(null);
        }

        [HttpPut()]
        [SwaggerOperation(Summary = "Replace an incident")]
        [ProducesResponseType(typeof(SimsSignal), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateSignal([FromBody, SwaggerParameter("Updated Signal", Required = true)] SimsSignal signal)
        {
            return new OkObjectResult(null);
        }

        [HttpPost()]
        [SwaggerOperation(Summary = "Create an incident")]
        [ProducesResponseType(typeof(SimsSignal), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> CreateSignal([FromBody, SwaggerParameter("Create Signal", Required = true)] SimsSignal signal)
        {

            return new OkObjectResult("");
        }

        [HttpPost("Status/{id}")]
        [SwaggerOperation(Summary = "Update status of an incident")]
        [ProducesResponseType(typeof(SimsSignal), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateStatus([FromRoute] int id, [Required] int statusId)
        {
            return new OkObjectResult(null);
        }

        [HttpPost("LeadOfficer")]
        [SwaggerOperation(Summary = "Update incident(s) lead officer")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateLeadOfficer([FromBody, SwaggerParameter("Update Lead officer entries", Required = true)] UpdateLeadOfficerModel officer)
        {
           // await this.simsApp.Incidents.AssignLeadOfficer(officer.IncidentIds, officer.Officer);
            return new OkResult();
        }


        [HttpPost("Promote/{id}")]
        [SwaggerOperation(Summary = "Update incident(s) lead officer")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> PromoteToIncident([FromRoute] int id)
        {
            // await this.simsApp.Incidents.AssignLeadOfficer(officer.IncidentIds, officer.Officer);
            return new OkResult();
        }
    }
}
