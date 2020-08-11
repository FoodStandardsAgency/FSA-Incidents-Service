using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.Graph;
using Microsoft.SharePoint.Client;
using Microsoft.SharePoint.Client.Taxonomy;
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

        private readonly X509Certificate2 cert;
        private readonly string siteUrl;
        private readonly string contentTypeId;

        private readonly Func<Task<string>> fetchAccessToken;
        private readonly Guid SimsIdTermSet;
        private readonly string[] scopes;
        public SPIncidentAttachments(string clientId, string tenantId, X509Certificate2 cert, string hostUrl, string siteUrl, string contentTypeId, Guid simsIdTermSet)
        {
            //this.clientId = clientId;
            this.cert = cert;
            this.siteUrl = siteUrl;
            this.contentTypeId = contentTypeId;
            SimsIdTermSet = simsIdTermSet;
            //this.tenantId = tenantId;
            this.scopes = new string[] { $"https://{hostUrl}/.default" }; // "https://{hostUrl}.com/TermStore.ReadWrite.All" };
            this.fetchAccessToken = () => SpContextHelper.GetApplicationAuthenticatedClient(clientId, this.cert, this.scopes, tenantId);
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
            // Creat the termset Entry
            //      await this.EnureIncidentTerm(incidentId, ctx);
            if (count < 1)
            {
                // Create a new list and applies the content type.
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

        private async Task EnureIncidentTerm(string incidentId, ClientContext ctx)
        {
            var taxonomySession = TaxonomySession.GetTaxonomySession(ctx);
            var tStore = taxonomySession.GetDefaultKeywordsTermStore();
            var simsIds = tStore.GetTermSet(this.SimsIdTermSet);

            var tCollection = taxonomySession.GetTermSetsByTermLabel(new string[] { incidentId }, 1033);
            ctx.Load(tCollection);
            await ctx.ExecuteQueryAsync();
            var createNewTerm = true;
            if (tCollection.Count > 0)
            {
                foreach (var termSet in tCollection)
                {
                    if (termSet.Id == this.SimsIdTermSet)
                        createNewTerm = false;
                }
            }
            if (createNewTerm)
            {
                //var newTerm = simsIds.CreateTerm(incidentId, 1033, Guid.NewGuid());
                //ctx.Load(newTerm);
                //await ctx.ExecuteQueryAsync();
            }

        }

        public async Task<(string filename, string url)> AddAttachment(string filePath, string fileName, string incidentId)
        {
            var accessToken = await fetchAccessToken();
            using (var ctx = SpContextHelper.GetClientContextWithAccessToken(this.siteUrl, accessToken))
            {
                try
                {
                    // Ensure we have a library related to the incident.(It is created if not)
                    var uploadLib = await EnsureList(incidentId, ctx);

                    var fileSize = new FileInfo(filePath).Length;
                    var fileMb = (fileSize / 1024) / 1024;

                    Microsoft.SharePoint.Client.File uploadedFile = null;

                    if (fileMb < 10)
                        uploadedFile = await UploadMidSizeFile(ctx, uploadLib, filePath, Path.GetFileName(fileName));
                    else
                        uploadedFile = await UploadLargeSizeFile(ctx, uploadLib, filePath, Path.GetFileName(fileName), fileSize);
                    // set the content type correctly.
                    if (uploadedFile != null)
                    {
                        var fileItem = uploadLib.GetItemByUniqueId(uploadedFile.UniqueId);
                        ctx.Load(fileItem);
                        var fileFields = ctx.Web.GetFileByServerRelativeUrl(uploadedFile.ServerRelativeUrl);
                        ctx.Load(fileFields, f => f.ListItemAllFields["EncodedAbsUrl"]);
                        fileItem["ContentTypeId"] = this.contentTypeId;
                        fileItem["SIMSIncidentId"] = incidentId; // Custom Column
                        fileItem.Update();
                        await ctx.ExecuteQueryAsync();
                        return (uploadedFile.Name, String.IsNullOrEmpty(uploadedFile.LinkingUrl) ? fileFields.ListItemAllFields["EncodedAbsUrl"] as string : uploadedFile.LinkingUrl);
                    }

                    throw new ArgumentNullException("No file has been uploaded");
                }
                //may be manage the duplicates here
                catch (ServerException ex) when (ex.ServerErrorCode == -2130575257)
                {
                    throw ex;
                }
                catch (ServerException ex)
                {
                    throw new ArgumentException($"Microsoft 365 error : {ex.ServerErrorValue}"); ;
                }
            }
        }
        /// <summary>
        /// Based on docs
        /// https://docs.microsoft.com/en-us/sharepoint/dev/solution-guidance/upload-large-files-sample-app-for-sharepoint
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="uploadLib"></param>
        /// <param name="filePath"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private async Task<Microsoft.SharePoint.Client.File> UploadLargeSizeFile(ClientContext ctx, List uploadLib, string filePath, string fileName, long fileSizeMb)
        {
            // Each sliced upload requires a unique ID.
            Guid uploadId = Guid.NewGuid();
            // File object.
            Microsoft.SharePoint.Client.File uploadFile = null;
            // Calculate block size in bytes.
            int blockSize = 3 * 1024 * 1024;
            // Use large file upload approach.
            ClientResult<long> bytesUploaded = null;
            FileStream fs = null;

            try
            {
                fs = System.IO.File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using (BinaryReader br = new BinaryReader(fs))
                {
                    byte[] buffer = new byte[blockSize];
                    Byte[] lastBuffer = null;
                    long fileoffset = 0;
                    long totalBytesRead = 0;
                    int bytesRead;
                    bool first = true;
                    bool last = false;

                    // Read data from file system in blocks.
                    while ((bytesRead = br.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        totalBytesRead = totalBytesRead + bytesRead;

                        // You've reached the end of the file.
                        if (totalBytesRead == fileSizeMb)
                        {
                            last = true;
                            // Copy to a new buffer that has the correct size.
                            lastBuffer = new byte[bytesRead];
                            Array.Copy(buffer, 0, lastBuffer, 0, bytesRead);
                        }

                        if (first)
                        {
                            using (MemoryStream contentStream = new MemoryStream())
                            {
                                // Add an empty file.
                                FileCreationInformation fileInfo = new FileCreationInformation();
                                fileInfo.ContentStream = contentStream;
                                fileInfo.Url = fileName;
                                fileInfo.Overwrite = false;
                                uploadFile = uploadLib.RootFolder.Files.Add(fileInfo);

                                // Start upload by uploading the first slice.
                                using (MemoryStream s = new MemoryStream(buffer))
                                {
                                    // Call the start upload method on the first slice.
                                    bytesUploaded = uploadFile.StartUpload(uploadId, s);
                                    await ctx.ExecuteQueryAsync();
                                    // fileoffset is the pointer where the next slice will be added.
                                    fileoffset = bytesUploaded.Value;
                                }

                                // You can only start the upload once.
                                first = false;
                            }
                        }
                        else
                        {
                            if (last)
                            {
                                // Is this the last slice of data?
                                using (MemoryStream s = new MemoryStream(lastBuffer))
                                {
                                    // End sliced upload by calling FinishUpload.
                                    uploadFile = uploadFile.FinishUpload(uploadId, fileoffset, s);
                                    ctx.Load(uploadFile);
                                    await ctx.ExecuteQueryAsync();

                                    // Return the file object for the uploaded file.
                                    return uploadFile;
                                }
                            }
                            else
                            {
                                using (MemoryStream s = new MemoryStream(buffer))
                                {
                                    // Continue sliced upload.
                                    bytesUploaded = uploadFile.ContinueUpload(uploadId, fileoffset, s);
                                    await ctx.ExecuteQueryAsync();
                                    // Update fileoffset for the next slice.
                                    fileoffset = bytesUploaded.Value;
                                }
                            }
                        }
                    } // while ((bytesRead = br.Read(buffer, 0, buffer.Length)) > 0)
                }
            }
            finally
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }


            return null;
        }

        private async Task<Microsoft.SharePoint.Client.File> UploadMidSizeFile(ClientContext ctx, List docLib, string filePath, string fileName)
        {
            // The file has been committed to temp storage on the server.
            var folder = docLib.RootFolder;
            // get file size
            var fci = new FileCreationInformation
            {
                Content = System.IO.File.ReadAllBytes(filePath),
                Url = fileName,
                Overwrite = false,
            };
            Microsoft.SharePoint.Client.File newFile = folder.Files.Add(fci);
            ctx.Load(newFile);
            await ctx.ExecuteQueryAsync();
            return newFile;
        }

        public async Task<IEnumerable<(string filename, string url)>> FetchAllAttchmentsLinks(string incidentId)
        {
            var accessToken = await fetchAccessToken();
            using (var ctx = SpContextHelper.GetClientContextWithAccessToken(this.siteUrl, accessToken))
            {
                var theLib = await EnsureList(incidentId, ctx);
                var files = theLib.RootFolder.Files;
                ctx.Load(files);
                await ctx.ExecuteQueryAsync();

                return files.Select(p => new { p.Name, p.LinkingUrl }).ToList().Select(p => (p.Name, p.LinkingUrl));
            }
        }

        public async Task<IncidentAttachment> FetchAttachment(string url)
        {
            var accessToken = await fetchAccessToken();
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
            var accessToken = await fetchAccessToken();
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
            return ("", "");
        }

        public Task<bool> ReplaceAttachment(FileStream filem, string url)
        {
            throw new NotImplementedException();
        }

        public async Task<IncidentLibraryInfo> EnsureLibrary(string incidentId)
        {
            var accessToken = await fetchAccessToken();
            using (var ctx = SpContextHelper.GetClientContextWithAccessToken(this.siteUrl, accessToken))
            {
                var list = await this.EnsureList(incidentId, ctx);
                ctx.Load(list.RootFolder);
                ctx.Load(ctx.Web);
                await ctx.ExecuteQueryAsync();
                // need the full site collection url
                //https blah/sites/blah
                var webUrl = ctx.Web.Url;
                // /sites/blah/folder
                var rootFolderUrl = list.RootFolder.ServerRelativeUrl;
                //var startOverlap webUrl.Contains()
                return new IncidentLibraryInfo
                {
                    WebUrl = webUrl,
                    ServerRelativeFolderUrl = rootFolderUrl
                };
            }
        }
    }
}
