using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root;
using FSA.IncidentsManagement.Root.Contracts;
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
        private readonly IFSAAttachments attachments;
        private readonly ISIMSManager sims;

        public AttachmentsController(ILogger<AttachmentsController> log, IFSAAttachments attachments, ISIMSManager sims)
        {
            this.log = log;
            this.attachments = attachments;
            this.sims = sims;
        }

        [HttpPost("EnsureLibrary/{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Ensure library exists")]
        [ProducesResponseType(typeof(AttachmentLibraryInfo), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> EnsureLibrary([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            //var stringId = GeneralExtensions.GenerateIncidentId(Id);
            //if (await this.fsaData.Incidents.Exists(Id))
            //{
            //    var listInfo = await this.attachments.EnsureLibrary(stringId);
            //    return new OkObjectResult(listInfo);
            //}
            return new OkObjectResult(null);
        }

        [HttpPost("{incidentSignal/{id}")]
        [SwaggerOperation(Summary = "Add Attachment to incident/signal")]
        [ProducesResponseType(typeof((string fileName, string url)), 200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(400)]
        [ProducesResponseType(403)]
        [Produces("application/json")]
        public async Task<IActionResult> AddAttachment([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            // Ensure a file has been added
            var file = this.Request.Form.Files.Count > 0 ? this.Request.Form.Files[0] : null;
            if (file == null)
                return new OkObjectResult("No files uploaded : Successfully!");

            // Ensure the incident is not already closed.
            if (!await sims.Incidents.IsClosed(id))
            {
                var stringId = GeneralExtensions.GenerateIncidentId(id);
                string[] scopes = new string[] { ".default" };

                // Should also be the id of the document library
                var fileTempPath = Path.GetTempFileName();
                var fileName = file.FileName;
                try
                {
                    using (var stream = System.IO.File.OpenWrite(fileTempPath))
                    {
                        await file.CopyToAsync(stream);
                    }
                    var attachedFile = await attachments.AddAttachment(fileTempPath, fileName, stringId);
                    System.IO.File.Delete(fileTempPath);
                    return new OkObjectResult(new { FileName = attachedFile.filename, Url = attachedFile.url });
                }
                catch (System.IO.IOException ex)
                {
                    System.IO.File.Delete(fileTempPath);
                    this.log.LogWarning(ex, "error during Attachment upload.");
                    return this.StatusCode(500, "Error during upload.");
                }
                catch (ServerException ex)
                {
                    System.IO.File.Delete(fileTempPath);
                    this.log.LogWarning("Duplicate file attempt");
                    return this.StatusCode(500, "Duplicate file cannot be added.");
                }
            }
            else
            {
                return new BadRequestObjectResult("Incident is closed");
            }
            //attachments.AddAttachment(file)
        }

        [HttpGet("{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Download incident attachments info")]
        [ProducesResponseType(typeof(List<AttachmentFileInfo>), 200)]
        public async Task<IActionResult> FetchAllAttachmentInfo([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            var stringId = GeneralExtensions.GenerateIncidentId(id);
            var fileInfo = await this.attachments.FetchAllAttchmentsLinks(stringId);
            var tags = await sims.Incidents.GetAttachmentTags(id);
            // This may be the worst code I've written this year.
            var completeFileInfo = fileInfo.Select(o =>
            {
                var itm = tags.SingleOrDefault(p => p.fileUrl == o.Url);
                o.Tags = itm.Equals(default(ValueTuple<string, string>)) ? o.Tags : Utilities.SelectedFlags<DocumentTagTypes>(itm.tags).Select(o => (int)o).ToList();
                return o;
            });

            return new OkObjectResult(completeFileInfo.ToList());
        }

        [HttpPost("Tags/{incidentSignal}")]
        [SwaggerOperation(Summary = "Update tags for for an attachment.")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateAttachmentTags([FromRoute] string incidentSignal, [FromBody] UpdateDocumentTagsModel updateTags)
        {
            var docTags = (DocumentTagTypes)updateTags.Tags.ToList().Sum();
            await sims.Incidents.UpdateAttachmentTags(updateTags.Id, updateTags.DocUrl, docTags);
            return new OkResult();
        }

        [HttpPost("Rename")]
        [SwaggerOperation(Summary = "Renames an attachment.")]
        [ProducesResponseType(typeof((string fileName, string url)), 200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(400)]
        [ProducesResponseType(403)]
        [Produces("application/json")]
        public async Task<IActionResult> RenameAttachment([FromBody] RenameFile renameFile)
        {
            try
            {
                var fileInfo = await this.attachments.RenameAttachment(renameFile.FileName, renameFile.ExistingUrl);
                return new OkObjectResult(new { FileName = fileInfo.fileName, Url = fileInfo.url });
            }
            catch (ArgumentOutOfRangeException ex) // new filename already exitst
            {
                return new ConflictResult();
            }
        }

    }
}
