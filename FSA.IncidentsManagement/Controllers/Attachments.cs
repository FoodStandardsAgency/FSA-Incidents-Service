﻿using FSA.Attachments;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Microsoft.Graph;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.Resource;
using Microsoft.SharePoint.Client;
using Microsoft.SharePoint.Client.Taxonomy;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AttachmentsController : ControllerBase
    {
        private readonly ILogger<AttachmentsController> log;
        private readonly ITokenAcquisition tkns;
        private readonly ISIMSManager sims;
        private readonly IFSAAttachments attachments;
        private readonly IFSATermStore termStore;

        public AttachmentsController(ILogger<AttachmentsController> log, ITokenAcquisition tkns, ISIMSManager sims, IFSAAttachments attachments, IFSATermStore termStore )
        {
            this.log = log;
            this.tkns = tkns;
            this.sims = sims;
            this.attachments = attachments;
            this.termStore = termStore;
        }

        [HttpPost("Incident")]
        [SwaggerOperation(Summary = "Add new Attachement to incident")]
        [ProducesResponseType(typeof((string fileName, string url)), 200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(400)]
        [ProducesResponseType(403)]
        [Produces("application/json")]
        public async Task<IActionResult> AddAttachment([FromQuery] int incidentId)
        {
            // Ensure a file has been added
            var file = this.Request.Form.Files.Count > 0 ? this.Request.Form.Files[0] : null;
            if (file == null)
                return new OkObjectResult("No files uploaded : Successfully!");

            // Ensure the incident is not already closed.
            if (!await sims.Incidents.IsClosed(incidentId))
            {
                var stringId = GeneralExtensions.GenerateIncidentId(incidentId);
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
                    return new OkObjectResult(new { FileName = attachedFile.filename, Url=attachedFile.url });
                }
                catch (System.IO.IOException ex)
                {
                    System.IO.File.Delete(fileTempPath);
                    this.log.LogWarning(ex,"error during Attachment upload.");
                   return this.StatusCode(500, "Error during upload.");
                }
                catch(ServerException ex)
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

        [HttpGet("FetchAll")]
        [SwaggerOperation(Summary = "Download incident attachments info")]
        [ProducesResponseType(typeof(List<AttachmentItem>), 200)]
        public async Task<IActionResult> FetchAttachmentsForIncident([FromQuery]int incidentId)
        {
            string[] scopes = new string[] { "https://graph.microsoft.com/TermStore.ReadWrite.All" };
            var termStoreAccessToken = await tkns.GetAccessTokenForUserAsync(scopes);
            var stringId = GeneralExtensions.GenerateIncidentId(incidentId);
            var fileInfo = await this.attachments.FetchAllAttchmentsLinks(stringId);
            return new OkObjectResult(fileInfo.Select(o => new { FileName = o.filename, Url = o.url }).ToList());
        }

        [HttpGet("Fetch")]
        [SwaggerOperation(Summary = "Download an a file.")]
        [ProducesResponseType(typeof(object), 200)]
        public async Task<IActionResult> FetchAttachment([FromQuery] string linkUrl)
        {
            var fileInfo = await this.attachments.FetchAttachment(linkUrl);
            var fileContentResult = new FileContentResult(fileInfo.Document.ToArray(), "application/octet-stream")
            {
                FileDownloadName = fileInfo.FileName
            };
            return new OkObjectResult(fileInfo);
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
            var fileInfo = await this.attachments.RenameAttachment(renameFile.fileName, renameFile.existingUrl);
            return new OkObjectResult(new { FileName = fileInfo.fileName, Url = fileInfo.url });
        }

    }
}