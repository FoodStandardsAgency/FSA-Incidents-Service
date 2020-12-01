using FSA.IncidentsManagement.Root.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OnlineFormProcessor : ControllerBase
    {
        private readonly ILogger<OnlineFormProcessor> logger;
        private readonly ISIMSApplication simsApp;

        public OnlineFormProcessor(ILogger<OnlineFormProcessor> logger, ISIMSApplication simsApp)
        {
            this.logger = logger;
            this.simsApp = simsApp;
        }
        [HttpPost("")]
        [Authorize(Policy = "OnlineFormOnly")]
        public async Task AddOnlineForm()
        {
            var formDocument= await JsonDocument.ParseAsync(this.Request.Body);
            await simsApp.OnlineForms.ImportNewForm(formDocument);
            logger.LogInformation("");
        }
    }
}
