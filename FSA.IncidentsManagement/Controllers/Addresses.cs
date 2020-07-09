﻿using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
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
        [SwaggerOperation(Description = "Find address.")]
        [ProducesResponseType(typeof(FboAddressModel), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> FindAddress(string addressSearch)
        {
            return new OkObjectResult(new List<FboAddressModel>());
        }

        [HttpPost("Fbo")]
        [SwaggerOperation(Description ="Add new Address and new fbo.")]
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
        [SwaggerOperation(Description = "update Address and fbo types.")]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdatedFboAddress([FromBody]FboAddressModel updtedFbo)
        {
            var fboAddress = await fsaData.Addresses.UpdateFbo(updtedFbo.ToClient());
            return new OkObjectResult(fboAddress.ToWeb());
        }

        [HttpGet("Fbo/{fboId}")]
        [ProducesResponseType(typeof(FboAddressModel), 200)]
        [SwaggerOperation(Description = "Fetch fbo address.")]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetFboAddress(int fboId)
        {
            var fboAddres = await fsaData.Addresses.GetFbo(fboId);
            return new OkObjectResult(fboAddres.ToWeb());
        }
    }
}
