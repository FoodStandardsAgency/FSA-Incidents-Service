using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

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

        [HttpPost()]
        [SwaggerOperation(Summary = "Find address.")]
        [ProducesResponseType(typeof(List<FboAddressModel>), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> FindAddress([FromBody]AddressSearchModel addressSearch)
        {
            return addressSearch.AddressType switch
            {
                SearchAddressType.FBO => new OkObjectResult(await fsaData.Addresses.FindFbo(addressSearch.Search)),
                SearchAddressType.Notifiers => new OkObjectResult(await fsaData.Addresses.FindNotifier(addressSearch.Search)),
                SearchAddressType.LocalAuthority => new OkObjectResult(await fsaData.Addresses.FindLocalAuthority(addressSearch.Search)),
                SearchAddressType.BasicAddress => new OkObjectResult(await fsaData.Addresses.FindAddress(addressSearch.Search)),
                SearchAddressType.Unknown => BadRequest("Unknown address type."),
                _=>BadRequest("Unknown address issues.")
            };   
        }

        [HttpPost("Fbo")]
        [SwaggerOperation(Summary = "Add new Address and new fbo.")]
        [ProducesResponseType(typeof(FboAddressModel), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> AddFboAddress([FromBody]FboAddressModel newFbo)
        {
            var fboADdress = await fsaData.Addresses.AddFbo(newFbo.ToClient());
            return new OkObjectResult(fboADdress.ToWeb());
        }

        [HttpPut("Fbo")]
        [ProducesResponseType(typeof(FboAddressModel), 200)]
        [SwaggerOperation(Summary = "Update Address and fbo types.")]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdatedFboAddress([FromBody]FboAddressModel updtedFbo)
        {
            var fboAddress = await fsaData.Addresses.UpdateFbo(updtedFbo.ToClient());
            return new OkObjectResult(fboAddress.ToWeb());
        }

        [HttpGet("Fbo/{fboId}")]
        [ProducesResponseType(typeof(FboAddressModel), 200)]
        [SwaggerOperation(Summary = "Fetch fbo address.")]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetFboAddress(int fboId)
        {
            var fboAddres = await fsaData.Addresses.GetFbo(fboId);
            return new OkObjectResult(fboAddres.ToWeb());
        }
    }
}
