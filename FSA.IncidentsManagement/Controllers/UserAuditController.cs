using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Root.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sims.Application.Exceptions;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserAuditController : ControllerBase
    {
        private readonly ILogger<UserAuditController> log;
        private readonly ISIMSApplication simsApp;

        public UserAuditController(ILogger<UserAuditController> log, ISIMSApplication simsApp)
        {
            this.log = log;
            this.simsApp = simsApp;
        }

        [HttpPost("{incidentSignal}/{pageName}/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [SwaggerOperation(Summary = "Log user", Description = "Adds user info to the log for explict action")]
        public Task AddUserLogEntry(string incidentSignal, string pageName, int id)
        {
            try
            {
                return incidentSignal.ToLowerInvariant() switch
                {
                    IncidentOrSignal.Incidents => this.simsApp.AuditLog.AddIncidentLog(pageName, id),
                    IncidentOrSignal.Signals => this.simsApp.AuditLog.AddSignalLog(pageName, id),
                    _ => throw new InvalidOperationException("Incident/Signal missing")
                };

            }
            catch (SIMSException ex)
            {
                log.LogError(ex.Message, ex);
                return Task.CompletedTask;
            }
            catch (InvalidOperationException ex)
            {
                log.LogError(nameof(AddUserLogEntry), ex);
                return Task.CompletedTask;
            }

        }


    }
}
