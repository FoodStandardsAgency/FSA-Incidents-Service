using AutoMapper;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Authorize]
    public class AddressesController : ControllerBase
    {

        private readonly ILogger<AddressesController> log;
        private readonly ISIMSApplication simsApp;
        private readonly IMapper mapper;

        public AddressesController(ILogger<AddressesController> log, ISIMSApplication simsApp, IMapper mapper)
        {
            this.log = log;
            this.simsApp = simsApp;
            this.mapper = mapper;
        }

        [HttpPost("Find")]
        [SwaggerOperation(Summary = "Find address")]
        [ProducesResponseType(typeof(List<SimsAddressViewModel>), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> FindAddress([FromBody] AddressSearchModel addressSearch)
        {
            var results = await simsApp.Addresses.FindAddress(addressSearch.Search);
            return new OkObjectResult(mapper.Map<IEnumerable<SimsAddress>, List<SimsAddressViewModel>>(results));
        }

        [HttpPost()]
        [SwaggerOperation(Summary = "Add Address")]
        [ProducesResponseType(typeof(SimsAddressViewModel), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> AddAddress([FromBody] SimsAddressViewModel newAddress)
        {
            var newDbAddress = mapper.Map<SimsAddressViewModel, SimsAddress>(newAddress);
            var createdAddress = await simsApp.Addresses.Add(newDbAddress);
            return new OkObjectResult(mapper.Map<SimsAddress, SimsAddressViewModel>(createdAddress));
        }

        [HttpPut()]
        [SwaggerOperation(Summary = "Update Address")]
        [ProducesResponseType(typeof(SimsAddressViewModel), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateAddress([FromBody] SimsAddressViewModel updateAddress)
        {
            var updateAppAddress = mapper.Map<SimsAddressViewModel, SimsAddress>(updateAddress);
            var createdAddress = await simsApp.Addresses.Update(updateAppAddress);
            return new OkObjectResult(mapper.Map<SimsAddress, SimsAddressViewModel>(createdAddress));

        }


        [HttpGet("{addressId}")]
        [ProducesResponseType(typeof(SimsAddressViewModel), 200)]
        [SwaggerOperation(Summary = "Fetch address")]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetAddress([FromRoute] int addressId)
        {
            var address = await simsApp.Addresses.Get(addressId);
            return new OkObjectResult(mapper.Map<SimsAddress, SimsAddressViewModel>(address));
        }
    }
}
