using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
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
        private readonly ISIMSManager simsData;

        public StakeholdersController(ILogger<StakeholdersController> log, ISIMSManager simsData)
        {
            this.log = log;
            this.simsData = simsData;
        }


        [HttpGet("{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Get All Stakeholders")]
        [ProducesResponseType(typeof(List<StakeholderModel>), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetStakeholder([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            var stakeholders = await this.simsData.Incidents.GetStakeholders(id);
            var addressItems = stakeholders.Where(o => o.AddressId.HasValue).Select(o => new { Id = o.Id, AddressId = o.AddressId.Value });

            var addressList = new List<SimsAddress>();
            foreach (var item in addressItems)
            {
                var address = await simsData.Addresses.Get(item.AddressId);
                addressList.Add(address);
            }

            var completedStakeholders = stakeholders.Select(o =>
            {
                var sHolder = o.ToWeb();
                if (sHolder.AddressId.HasValue)
                    sHolder.AddressTitle = addressList.FirstOrDefault(o => o.Id == sHolder.AddressId)?.Title ?? "";
                return sHolder;
            }).ToList();
            return new OkObjectResult(completedStakeholders);

        }

        [HttpPost("{incidentSignal}")]
        [SwaggerOperation(Summary = "Add a new stakeholder to an incident")]
        [ProducesResponseType(typeof(StakeholderModel), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> AddStakeholder([FromRoute] string incidentSignal, [FromBody] StakeholderModel stakeholder)
        {
            try
            {
                var newStakeholder = await this.simsData.Incidents.AddStakeholder(stakeholder.ToClient());
                return new OkObjectResult(newStakeholder);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        [HttpPut("{incidentSignal}")]
        [SwaggerOperation(Summary = "Update a  stakeholder to an incident")]
        [ProducesResponseType(typeof(StakeholderModel), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateStakeholder([FromRoute] string incidentSignal,[FromBody] StakeholderModel stakeholder)
        {
            try
            {
                var updatedStakeholder = await this.simsData.Incidents.UpdateStakeholder(stakeholder.ToClient());
                return new OkObjectResult(updatedStakeholder);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

    }
}
