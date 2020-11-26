using AutoMapper;
using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.SharePoint.Client;
using Sims.Application.Exceptions;
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
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Authorize]
    public class AttachmentsController : ControllerBase
    {
        private readonly ILogger<AttachmentsController> log;
        private readonly ISIMSApplication simsApp;
        private readonly IMapper mapper;

        public AttachmentsController(ILogger<AttachmentsController> log, ISIMSApplication simsApp, IMapper mapper)
        {
            this.log = log;
            this.simsApp = simsApp;
            this.mapper = mapper;
        }

        [HttpPost("EnsureLibrary/{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Ensure library exists")]
        [ProducesResponseType(typeof(SimsAttachmentLibraryInfo), 200)]
        [ProducesResponseType(typeof(string), 403)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> EnsureLibrary([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            return incidentSignal.ToLower() switch
            {
                IncidentOrSignalOrOnlineForm.Incidents => new OkObjectResult(await this.simsApp.Incidents.Attachments.EnsureLibrary(id)),
                IncidentOrSignalOrOnlineForm.Signals => new OkObjectResult(await this.simsApp.Signals.Attachments.EnsureLibrary(id)),
                _ => BadRequest("Unknown route")
            };
        }

        [HttpPost("{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Add Attachment to incident/signal")]
        [ProducesResponseType(typeof(SimsAttachmentFileInfoViewModel), 200)]
        [ProducesResponseType(typeof(string), 403)]
        [ProducesResponseType(500)]
        [Produces("application/json")]
        public async Task<IActionResult> AddAttachment([FromRoute] string incidentSignal, [FromRoute] int id)
        {

            try
            {
                // The action to actually upload the file
                // But also validates the action without doing work
                Func<string, string, int, Task<SimsAttachmentFileInfo>> UploadFile = incidentSignal.ToLower() switch
                {
                    IncidentOrSignalOrOnlineForm.Incidents => this.simsApp.Incidents.Attachments.AddAttachment,
                    IncidentOrSignalOrOnlineForm.Signals => this.simsApp.Signals.Attachments.AddAttachment,
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
            catch(SIMSException ex)
            {
                this.log.LogInformation(nameof(AddAttachment),ex);
                return this.StatusCode(500, ex.Message);
            }
        }


        [HttpPost("Register/{incidentSignal}")]
        [SwaggerOperation(Summary = "Register attachment to  incident/signal")]
        [ProducesResponseType(typeof(SimsAttachmentFileInfoViewModel), 200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(typeof(string), 403)]
        [Produces("application/json")]
        public async Task<IActionResult> RegisterAttachment([FromRoute] string incidentSignal, [FromBody] RegisterAttachmentModel newAttachment)
        {
            var docUri = new Uri(newAttachment.DocUrl).GetComponents(UriComponents.Scheme | UriComponents.Host | UriComponents.Path, UriFormat.UriEscaped);

            // The action to actually upload the file
            // But also validates the action without doing work
            var model =  incidentSignal.ToLower() switch
            {
                IncidentOrSignalOrOnlineForm.Incidents => await this.simsApp.Incidents.Attachments.RegisterAttachment(docUri, newAttachment.HostId),
                IncidentOrSignalOrOnlineForm.Signals => await this.simsApp.Signals.Attachments.RegisterAttachment(docUri, newAttachment.HostId),
                _ => throw new InvalidOperationException("Unknown route")
            };

            return new OkObjectResult(this.mapper.Map<SimsAttachmentFileInfoViewModel>(model));

        }

        [HttpGet("{incidentSignal}/{id}")]
        [SwaggerOperation(Summary = "Download attachments info")]
        [ProducesResponseType(typeof(List<SimsAttachmentFileInfoViewModel>), 200)]
        [ProducesResponseType(typeof(string), 403)]
        public async Task<IActionResult> FetchAllAttachmentInfo([FromRoute] string incidentSignal, [FromRoute] int id)
        {
            try
            {
                var fileInfo = incidentSignal.ToLower() switch
                {
                    IncidentOrSignalOrOnlineForm.Incidents => await this.simsApp.Incidents.Attachments.FetchAllAttchmentsLinks(id),
                    IncidentOrSignalOrOnlineForm.Signals => await this.simsApp.Signals.Attachments.FetchAllAttchmentsLinks(id),
                    _ => throw new InvalidOperationException("Unknown route")
                };
                return new OkObjectResult(this.mapper.Map<List<SimsAttachmentFileInfoViewModel>>(fileInfo));
            }
            catch(InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Tags/{incidentSignal}")]
        [SwaggerOperation(Summary = "Update tags for for an attachment.")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(typeof(string), 403)]
        public async Task<IActionResult> UpdateAttachmentTags([FromRoute] string incidentSignal, [FromBody] UpdateDocumentTagsModel updateTags)
        {
            try
            {
                var docUri = new Uri(updateTags.DocUrl).GetComponents(UriComponents.Scheme | UriComponents.Host | UriComponents.Path, UriFormat.UriEscaped);
                var model = incidentSignal.ToLower() switch
                {
                    IncidentOrSignalOrOnlineForm.Incidents => await this.simsApp.Incidents.Attachments.Update(docUri, (SimsDocumentTagTypes)updateTags.Tags.Sum()),
                    IncidentOrSignalOrOnlineForm.Signals => await this.simsApp.Signals.Attachments.Update(docUri, (SimsDocumentTagTypes)updateTags.Tags.Sum()),
                    _ => throw new InvalidOperationException("Unknown route")
                };
                return new OkObjectResult(this.mapper.Map<SimsAttachmentFileInfoViewModel>(model));
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost("Rename/{incidentSignal}")]
        [SwaggerOperation(Summary = "Renames an attachment.")]
        [ProducesResponseType(typeof(SimsAttachmentFileInfoViewModel), 200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(409)]
        [ProducesResponseType(typeof(string), 403)]
        [Produces("application/json")]
        public async Task<IActionResult> RenameAttachment([FromRoute] string incidentSignal, [FromBody] RenameFileViewModel renameFile)
        {
            try
            {
                var fileInfo = incidentSignal.ToLower() switch
                {
                    IncidentOrSignalOrOnlineForm.Incidents => await this.simsApp.Incidents.Attachments.Rename(renameFile.ExistingUrl, renameFile.FileName),
                    IncidentOrSignalOrOnlineForm.Signals => await this.simsApp.Signals.Attachments.Rename(renameFile.ExistingUrl, renameFile.FileName),
                    _ => throw new InvalidOperationException("Unknown route")
                };
                return new OkObjectResult(this.mapper.Map<SimsAttachmentFileInfoViewModel>(fileInfo));
            }
            catch (ArgumentOutOfRangeException ex) // new filename already exitst
            {
                log.LogError(nameof(RenameAttachment), ex);
                return new ConflictResult();
            }
            catch(InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
