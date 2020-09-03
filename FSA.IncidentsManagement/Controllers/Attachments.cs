using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.SharePoint.Client;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Controllers
{

    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [Authorize]
    public class AttachmentsController : ControllerBase
    {
        private readonly ILogger<AttachmentsController> log;
        private readonly ISIMSApplication simsApp;

        public AttachmentsController(ILogger<AttachmentsController> log, ISIMSApplication simsApp)
        {
            this.log = log;
            this.simsApp = simsApp;
        }

        [HttpPost("EnsureLibrary/{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Ensure library exists")]
        [ProducesResponseType(typeof(AttachmentLibraryInfo), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> EnsureLibrary([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            return incidentSignal.ToLower() switch
            {
                IncidentOrSignal.Incidents => new OkObjectResult(await this.simsApp.Incidents.Attachments.EnsureLibrary(id)),
                IncidentOrSignal.Signals => new OkObjectResult(await this.simsApp.Signals.Attachments.EnsureLibrary(id)),
                _ => BadRequest("Unknown route")
            };
        }

        [HttpPost("{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Add Attachment to incident/signal")]
        [ProducesResponseType(typeof(SimsAttachmentFileInfo), 200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(400)]
        [ProducesResponseType(403)]
        [Produces("application/json")]
        public async Task<IActionResult> AddAttachment([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            // The action to actually upload the file
            // But also validates the action without doing work
            Func<string, string, int, Task<SimsAttachmentFileInfo>> UploadFile = incidentSignal.ToLower() switch
            {
                IncidentOrSignal.Incidents => this.simsApp.Incidents.Attachments.AddAttachment,
                IncidentOrSignal.Signals => this.simsApp.Signals.Attachments.AddAttachment,
                _ => throw new InvalidOperationException("Unknown route")
            };

            // Ensure a file has been added to the request
            var file = this.Request.Form.Files.Count > 0 ? this.Request.Form.Files[0] : null;
            if (file == null)
                return new OkObjectResult("No files uploaded : Successfully!");

            var fileTempPath = Path.GetTempFileName();
            var fileName = file.FileName;
            try
            {
                using (var stream = System.IO.File.OpenWrite(fileTempPath))
                {
                    await file.CopyToAsync(stream);
                }
                // Where the delegate is finally used.
                var attachedFile = await UploadFile(fileTempPath, fileName, id);
                return new OkObjectResult(attachedFile);
            }
            catch (System.IO.IOException ex)
            {
                this.log.LogWarning(ex, "error during Attachment upload.");
                return this.StatusCode(500, "Error during upload.");
            }
            catch (ServerException)
            {
                this.log.LogWarning("Duplicate file attempt");
                return this.StatusCode(500, "Duplicate file cannot be added.");
            }
            finally
            {
                System.IO.File.Delete(fileTempPath);
            }
        }

        [HttpGet("{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Download incident attachments info")]
        [ProducesResponseType(typeof(List<SimsAttachmentFileInfo>), 200)]
        public async Task<IActionResult> FetchAllAttachmentInfo([FromRoute] string incidentSignal, [FromRoute] int id)
        {

           var fileInfo = incidentSignal.ToLower() switch
            {
                IncidentOrSignal.Incidents => await this.simsApp.Incidents.Attachments.FetchAllAttchmentsLinks(id),
                IncidentOrSignal.Signals => await this.simsApp.Signals.Attachments.FetchAllAttchmentsLinks(id),
                _ => throw new InvalidOperationException("Unknown route")
            };


            return new OkObjectResult(fileInfo.ToList());
        }

        [HttpPost("Tags/{incidentSignal}")]
        [SwaggerOperation(Summary = "Update tags for for an attachment.")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateAttachmentTags([FromBody] UpdateDocumentTagsModel updateTags)
        {
            await this.simsApp.AttachmentUpdates.UpdateTags(updateTags.DocUrl, updateTags.Tags);
            return new OkResult();
        }

        [HttpPost("Rename")]
        [SwaggerOperation(Summary = "Renames an attachment.")]
        [ProducesResponseType(typeof(SimsAttachmentFileInfo), 200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(400)]
        [ProducesResponseType(403)]
        [Produces("application/json")]
        public async Task<IActionResult> RenameAttachment([FromBody] RenameFile renameFile)
        {
            try
            {
                var fileInfo = await this.simsApp.AttachmentUpdates.Rename(renameFile.FileName, renameFile.ExistingUrl);
                return new OkObjectResult(fileInfo);
            }
            catch (ArgumentOutOfRangeException ex) // new filename already exitst
            {
                log.LogError(nameof(RenameAttachment), ex);
                return new ConflictResult();
            }
        }

    }
}
