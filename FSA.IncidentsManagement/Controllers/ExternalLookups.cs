using FSA.IncidentsManagement.Root.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class ExternalLookupsController : ControllerBase
    {
        private readonly ILogger<ExternalLookupsController> logger;
        private readonly ISIMSApplication simsApp;

        public ExternalLookupsController(ILogger<ExternalLookupsController> logger, ISIMSApplication simsApp)
        {
            this.logger = logger;
            this.simsApp = simsApp;
        }

        [Authorize(Policy = "OnlineFormOnly")]
        public async Task<IActionResult> GetLookups()
        {
            
            return new OkObjectResult(simsApp.Lookups.GetExternalLookups());
        }
    }
}
