using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AddressesController : ControllerBase
    {
        private readonly ILogger<AddressesController> log;
        private readonly ISIMSManager fsaData;

        public AddressesController(ILogger<AddressesController> log, ISIMSManager fsaData)
        {
            this.log = log;
            this.fsaData = fsaData;
        }

        [HttpPost("Find")]
        [SwaggerOperation(Summary = "Find address")]
        [ProducesResponseType(typeof(List<SimsAddressViewModel>), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> FindAddress([FromBody] AddressSearchModel addressSearch) => new OkObjectResult((await fsaData.Addresses.FindAddress(addressSearch.Search)).ToWeb().ToList());

        [HttpPost()]
        [SwaggerOperation(Summary = "Add new Address")]
        [ProducesResponseType(typeof(SimsAddressViewModel), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> AddAddress([FromBody] SimsAddressViewModel newAddress)
        {
            var newDbAddress = newAddress.ToClient();
            var createdAddress = await fsaData.Addresses.Add(newDbAddress);
            return new OkObjectResult(createdAddress);
        }

        [HttpPut()]
        [SwaggerOperation(Summary = "Update Address")]
        [ProducesResponseType(typeof(SimsAddressViewModel), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateAddress([FromBody] SimsAddressViewModel newAddress)
        {
            var newDbAddress = newAddress.ToClient();
            var createdAddress = await fsaData.Addresses.Update(newDbAddress);
            return new OkObjectResult(createdAddress.ToWeb());
        }



        [HttpGet("")]
        [ProducesResponseType(typeof(SimsAddressViewModel), 200)]
        [SwaggerOperation(Summary = "Fetch address")]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetAddress([FromQuery] int addressId)
        {
            var address = await fsaData.Addresses.Get(addressId);
            return new OkObjectResult(address.ToWeb());
        }
    }
}
