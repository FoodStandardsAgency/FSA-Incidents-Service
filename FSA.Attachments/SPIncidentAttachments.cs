using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.Graph;
using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using List = Microsoft.SharePoint.Client.List;

namespace FSA.Attachments
{
    /// <summary>
    /// Manage the attachments to a particular incident
    /// </summary>
    public class SPIncidentAttachments : IFSAAttachments
    {
        private readonly string clientId;
        private readonly X509Certificate2 cert;
        private readonly string thumbprint;
        private readonly string siteUrl;
        private readonly string contentTypeId;
        private readonly string tenantId;

        public SPIncidentAttachments(string clientId, string tenantId, X509Certificate2 cert, string thumbprint, string siteUrl, string contentTypeId)
        {
            this.clientId = clientId;
            this.cert = cert;
            this.thumbprint = thumbprint;
            this.siteUrl = siteUrl;
            this.contentTypeId = contentTypeId;
            this.tenantId = tenantId;
        }

        private async Task<List> Createlist(string incidentId, ClientContext ctx)
        {
            var newListDef = new ListCreationInformation
            {
                TemplateType = (int)ListTemplateType.DocumentLibrary,
                Title = incidentId,

            };
            var newList = ctx.Web.Lists.Add(newListDef);
            var ctype = ctx.Web.ContentTypes.GetById(contentTypeId);
            ctx.Load(newList);
            ctx.Load(ctype);
            await ctx.ExecuteQueryAsync();
            newList.ContentTypesEnabled = true;
            newList.ContentTypes.AddExistingContentType(ctype);
            newList.Update();
            await ctx.ExecuteQueryAsync();
            return newList;
        }

        private async Task<List> EnsureList(string incidentId, ClientContext ctx)
        {
            var itmQ = ctx.Web.Lists.Where(o => o.Title == incidentId);
            var matchedLists = ctx.LoadQuery(itmQ);
            await ctx.ExecuteQueryAsync();

            var count = matchedLists.Count();
            if (count < 1)
            {
                // Create a new list
                return await this.Createlist(incidentId, ctx);
            }
            else
            {
                // well thats's a problem
                if (count > 1)
                {
                    throw new ArgumentOutOfRangeException($"{incidentId} - There are duplicate lists");
                }
                return matchedLists.First();
            }

        }

        public async Task<(string filename, string url)> AddAttachment(string filePath, string fileName, string incidentId)
        {
            var accessToken = await SpContextHelper.GetApplicationAuthenticatedClient(clientId, cert, thumbprint, new string[] { $"https://iamgeekdev.sharepoint.com/.default" }, tenantId);
            using (var ctx = SpContextHelper.GetClientContextWithAccessToken(this.siteUrl, accessToken))
            {
                try
                {
                    // Ensure we have a library related to the incident.(It is created if not)
                    var uploadLib = await EnsureList(incidentId, ctx);
                    // The file has been committed to temp storage on the server.
                    var folder = uploadLib.RootFolder;
                    var fci = new FileCreationInformation
                    {
                        Content = System.IO.File.ReadAllBytes(filePath),
                        Url = fileName,
                        Overwrite = false,
                    };
                    Microsoft.SharePoint.Client.File fileToUpload = folder.Files.Add(fci);
                    ctx.Load(fileToUpload);
                    await ctx.ExecuteQueryAsync();

                    var fileItem = uploadLib.GetItemByUniqueId(fileToUpload.UniqueId);


                    ctx.Load(fileItem);
                    fileItem["ContentTypeId"] = this.contentTypeId;
                    fileItem.Update();
                    await ctx.ExecuteQueryAsync();
                    return (fileToUpload.Name, fileToUpload.LinkingUrl);
                }

                catch (ServerException ex) //may be manage the duplicates here
                {
                    throw ex;
                }
            }
        }

        public async Task<IEnumerable<(string filename, string url)>> FetchAllAttchmentsLinks(string incidentId)
        {
            var accessToken = await SpContextHelper.GetApplicationAuthenticatedClient(clientId, cert, thumbprint, new string[] { $"https://iamgeekdev.sharepoint.com/.default" }, tenantId);
            using (var ctx = SpContextHelper.GetClientContextWithAccessToken(this.siteUrl, accessToken))
            {
                var theLib = await EnsureList(incidentId, ctx);
                var files = theLib.RootFolder.Files;
                ctx.Load(files);
                await ctx.ExecuteQueryAsync();

                return files.Select(p => new { p.Name, p.LinkingUrl }).ToList().Select(p=>(p.Name, p.LinkingUrl));
            }
        }

        public async Task<IncidentAttachment> FetchAttachment(string url)
        {
            var accessToken = await SpContextHelper.GetApplicationAuthenticatedClient(clientId, cert, thumbprint, new string[] { $"https://iamgeekdev.sharepoint.com/.default" }, tenantId);
            using (var ctx = SpContextHelper.GetClientContextWithAccessToken(this.siteUrl, accessToken))
            {
                var file = ctx.Web.GetFileByLinkingUrl(url);

                ctx.Load(file, f => f.ListId);
                await ctx.ExecuteQueryAsync();

                var list = ctx.Web.Lists.GetById(file.ListId);

                var incidentAttachment = new IncidentAttachment();

                if (file != null)
                {
                    var fileData = file.OpenBinaryStream();
                    fileData.Value.CopyTo(incidentAttachment.Document);
                    incidentAttachment.IncidentId = list.Title;
                    incidentAttachment.FileName = file.Name;
                    return incidentAttachment;
                }
                return incidentAttachment;
            }
        }

        public async Task<(string fileName, string url)> RenameAttachment(string fileName, string url)
        {
            var accessToken = await SpContextHelper.GetApplicationAuthenticatedClient(clientId, cert, thumbprint, new string[] { $"https://iamgeekdev.sharepoint.com/.default" }, tenantId);
            using (var ctx = SpContextHelper.GetClientContextWithAccessToken(this.siteUrl, accessToken))
            {
                var file = ctx.Web.GetFileByLinkingUrl(url);

                ctx.Load(file, f => f.ListItemAllFields);
                await ctx.ExecuteQueryAsync();
                if (file != null)
                {
                    file.MoveTo(file.ListItemAllFields["FileDirRef"] + "/" + fileName, MoveOperations.RetainEditorAndModifiedOnMove);
                    await ctx.ExecuteQueryAsync();
                    return (fileName, file.LinkingUrl);
                }
                
            }
            return ("","");
        }

        public Task<bool> ReplaceAttachment(FileStream filem, string url)
        {
            throw new NotImplementedException();
        }



    }
}
