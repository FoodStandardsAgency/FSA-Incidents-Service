using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FSA.IncidentsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidentsController : ControllerBase
    {
        public IncidentsController(ILogger<IncidentsController> log)
        {

        }

        [HttpGet()]
        public async Task<IActionResult>GetIncident()
        {
            return new OkObjectResult(Enumerable.Empty<string>());
        }

        [HttpPost()]
        public async Task<IActionResult> UpdateIncident() {
            return new OkObjectResult(Enumerable.Empty<string>());
        }

        [HttpPost("Classification")]
        public async Task<IActionResult> UpdateClassification(int incidentId)
        {
            return new OkObjectResult(new { });
        }

        [HttpPost("Status")]
        public async Task<IActionResult> UpdateStatus(int incidentId)
        {
            return new OkResult();
        }
    }
}
