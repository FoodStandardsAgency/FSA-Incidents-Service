using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Controllers
{
    [Route("api/v1/Incidents")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class OldIncidentsController : ControllerBase
    {
        private readonly ILogger<OldIncidentsController> log;
        private readonly ISIMSManager fsaData;
        private readonly IFSAAttachments attachments;

        public OldIncidentsController(ILogger<OldIncidentsController> log, ISIMSManager fsaData, IFSAAttachments attachments)
        {
            this.log = log;
            this.fsaData = fsaData;
            this.attachments = attachments;
        }

        [HttpGet()]
        [SwaggerOperation(Summary = "Get incident by id")]
        [ProducesResponseType(typeof(IncidentsDisplayModel), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetIncident(int id)
        {
            if (id == 0) return BadRequest("No Incident Id was passed");
            return new OkObjectResult(await this.fsaData.Incidents.GetDisplayItem(id));
        }

        [HttpGet("Dashboard")]
        [SwaggerOperation(Summary = "Incident dashboard search")]
        [ProducesResponseType(typeof(IncidentDashboardView), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetIncidentDashboard(string search, int pageNo, int? pageSize)
        {
            log.LogInformation($"search terms : {search} {pageNo} {pageSize}", "GetIncidentsDashboard");

            if (pageNo < 1 || pageSize < 1)
                return new OkObjectResult(new PagedResult<IncidentDashboardView>(Enumerable.Empty<IncidentDashboardView>(), 0));

            var dashBoard = pageSize.HasValue ? await this.fsaData.Incidents.DashboardSearch(search: search ?? "", startPage: pageNo, pageSize: pageSize.Value) : await this.fsaData.Incidents.DashboardSearch(search: search ?? "", startPage: pageNo);
            return new OkObjectResult(new
            {
                Results = dashBoard,
                TotalRecords = dashBoard.TotalResults
            });
        }

        [HttpPut()]
        [SwaggerOperation(Summary = "Replace an existing incident")]
        [ProducesResponseType(typeof(BaseIncident), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateIncident([FromBody, SwaggerParameter("Updated Incident", Required = true)] IncidentUpdateModel incident)
        {

            return new OkObjectResult(await this.fsaData.Incidents.Update(incident.ToClient()));
        }

        [HttpPost()]
        [SwaggerOperation(Summary = "Create an existing incident")]
        [ProducesResponseType(typeof(BaseIncident), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> CreateIncident([FromBody, SwaggerParameter("Create Incident", Required = true)] IncidentCreateModel incident)
        {
            return new OkObjectResult(await this.fsaData.Incidents.Add(incident.ToClient()));
        }

        [HttpPost("Classification")]
        [SwaggerOperation(Summary = "Update classification of an incident")]
        [ProducesResponseType(typeof(BaseIncident), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateClassification([Required] int incidentId, [Required] int classificationId)
        {
            return new OkObjectResult(await this.fsaData.Incidents.UpdateClassification(incidentId, classificationId));
        }

        [HttpPost("Status")]
        [SwaggerOperation(Summary = "Update status of an incident")]
        [ProducesResponseType(typeof(BaseIncident), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateStatus([Required] int incidentId, [Required] int statusId)
        {
            return new OkObjectResult(await this.fsaData.Incidents.UpdateStatus(incidentId, statusId));
        }

        [HttpPost("CloseAll")]
        [SwaggerOperation(Summary = "Update status of an incident")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> CloseAll([Required] int[] incidentIds)
        {
            await this.fsaData.Incidents.BulkClose(incidentIds);
            return new OkResult();
        }

        [HttpPost("LeadOfficer")]
        [SwaggerOperation(Summary = "Assign lead officer")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateLeadOfficer([FromBody, SwaggerParameter("Update Lead officer entries", Required = true)] UpdateLeadOfficerModel officer)
        {
            await this.fsaData.Incidents.AssignLeadOfficer(officer.Ids, officer.Officer);
            return new OkResult();
        }

        [HttpPost("AddLinks")]
        [SwaggerOperation(Summary = "Link two or moreincidents")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddIncidentLink([FromBody] LinkModel addIncident)
        {
            await this.fsaData.Incidents.AddLinks(addIncident.FromId, addIncident.ToIds, addIncident.Comment);
            return new OkResult();
        }

        [HttpPost("RemoveLink")]
        [SwaggerOperation(Summary = "Remove link between two incidents")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> RemoveIncidentLink([FromBody] UnlinkModel removeIncident)
        {
            await this.fsaData.Incidents.RemoveLink(removeIncident.FromId, removeIncident.ToId);
            return new OkResult();
        }

        [HttpGet("GetIncidentLinks")]
        [SwaggerOperation(Summary = "Dashboard info for an incidents links")]
        [ProducesResponseType(typeof(IEnumerable<IncidentDashboardView>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetIncidentLinks([FromQuery] int incidentId)
        {
            return new OkObjectResult(await this.fsaData.Incidents.DashboardIncidentLinks(incidentId));
        }

        [HttpPost("AddNote")]
        [SwaggerOperation(Summary = "Add note to an incident")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddNote([FromBody, SwaggerParameter(Required = true)] IncidentComment addIncident)
        {
            await this.fsaData.Incidents.AddNote(addIncident.IncidentId, addIncident.Note);
            return new OkResult();
        }

        [HttpGet("GetNotes")]
        [SwaggerOperation(Summary = "Get notes for an incident")]
        [ProducesResponseType(typeof(IEnumerable<SimsNote>), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetNotes([FromQuery] int incidentId)
        {
            return new OkObjectResult(await this.fsaData.Incidents.GetNotes(incidentId));
        }

        [HttpPost("EnsureLibrary")]
        [SwaggerOperation(Summary = "Ensure library exists for incident")]
        [ProducesResponseType(typeof(AttachmentLibraryInfo), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> EnsureLibrary([FromQuery] int Id)
        {
            var stringId = GeneralExtensions.GenerateIncidentId(Id);
            if (await this.fsaData.Incidents.Exists(Id))
            {
                var listInfo = await this.attachments.EnsureLibrary(stringId);
                return new OkObjectResult(listInfo);
            }
            return new OkObjectResult(null);

        }

        [HttpGet("Stakeholders")]
        [SwaggerOperation(Summary = "Get all stakeholder for an incident")]
        [ProducesResponseType(typeof(List<StakeholderModel>), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> GetStakeholder([FromQuery] int incidentId)
        {
            var stakeholders = await this.fsaData.Incidents.GetStakeholders(incidentId);
            var addressItems = stakeholders.Where(o => o.AddressId.HasValue).Select(o => new { Id = o.Id, AddressId = o.AddressId.Value });

            var addressList = new List<SimsAddress>();
            foreach (var item in addressItems)
            {
                var address = await fsaData.Addresses.Get(item.AddressId);
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

        [HttpPost("Stakeholders")]
        [SwaggerOperation(Summary = "Add a new stakeholder to an incident")]
        [ProducesResponseType(typeof(StakeholderModel), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> AddStakeholder([FromBody] StakeholderModel stakeholder)
        {
            try
            {
                var newStakeholder = await this.fsaData.Incidents.AddStakeholder(stakeholder.ToClient());
                return new OkObjectResult(newStakeholder);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        [HttpPut("Stakeholders")]
        [SwaggerOperation(Summary = "Update a  stakeholder to an incident")]
        [ProducesResponseType(typeof(StakeholderModel), 200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateStakeholder([FromBody] StakeholderModel stakeholder)
        {
            try
            {
                var updatedStakeholder = await this.fsaData.Incidents.UpdateStakeholder(stakeholder.ToClient());
                return new OkObjectResult(updatedStakeholder);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }


        [HttpDelete("Stakeholders")]
        [SwaggerOperation(Summary = "Remove a stakeholder to an incident")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> DeleteStakeholder([FromQuery] int stakeholderId)
        {
            try
            {
                await this.fsaData.Incidents.RemoveStakeholder(stakeholderId);
                return new OkResult();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

    }
}
