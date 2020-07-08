using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

        [HttpGet()]
        public Task<IActionResult> FindAddress(string addressSearch)
        {
            throw new NotImplementedException();
        }

        [HttpPost("Fbo")]
        public async Task<IActionResult> AddFboAddress([FromBody]FboAddressModel newFbo)
        {
            return new OkObjectResult(await fsaData.Addresses.AddFbo(newFbo.ToClient()));
        }

        [HttpPut("Fbo")]
        public async Task<IActionResult> UpdatedFboAddress([FromBody]FboAddressModel updtedFbo)
        {
            return new OkObjectResult(await fsaData.Addresses.UpdateFbo(updtedFbo.ToClient()));
        }

        [HttpGet("Fbo/{fboId}")]
        public async Task<IActionResult> GetFboAddress(int fboId)
        {
            var fboAddres = await fsaData.Addresses.GetFbo(fboId);
            return new OkObjectResult(fboAddres.ToWeb());
        }



    }
}
