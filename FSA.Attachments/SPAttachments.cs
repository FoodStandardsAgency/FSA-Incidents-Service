using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.Graph;
using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using List = Microsoft.SharePoint.Client.List;

namespace FSA.Attachments
{
    /// <summary>
    /// Manage the attachments to a particular incident
    /// </summary>
    public class SPAttachments : ISPAttachmentManagement
    {

        private readonly X509Certificate2 cert;
        private readonly string siteUrl;
        private readonly string contentTypeId;

        private readonly Func<Task<string>> fetchAccessToken;

        private readonly string[] scopes;
        public SPAttachments(string clientId, string tenantId, X509Certificate2 cert, string hostUrl, string siteUrl, string contentTypeId)
        {
            //this.clientId = clientId;
            this.cert = cert;
            this.siteUrl = siteUrl;
            this.contentTypeId = contentTypeId;

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
            var docType = newList.ContentTypes.AddExistingContentType(ctype);
            ctx.Load(docType);
            newList.Update();
            await ctx.ExecuteQueryAsync();

            newList.RootFolder.UniqueContentTypeOrder = new List<ContentTypeId> { docType.Id, };
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

        public async Task<(string filename, string url)> AddAttachment(string filePath, string fileName, string hostIdentifier)
        {
            var accessToken = await fetchAccessToken();
            using (var ctx = SpContextHelper.GetClientContextWithAccessToken(this.siteUrl, accessToken))
            {
                try
                {
                    // Ensure we have a library related to the incident.(It is created if not)
                    var uploadLib = await EnsureList(hostIdentifier, ctx);

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
                        fileItem["SIMSIncidentId"] = hostIdentifier; // Custom Column
                        fileItem.Update();
                        await ctx.ExecuteQueryAsync();
                        return (uploadedFile.Name, String.IsNullOrEmpty(uploadedFile.LinkingUrl) ? Uri.EscapeUriString(fileFields.ListItemAllFields["EncodedAbsUrl"] as string) : Uri.EscapeUriString(uploadedFile.LinkingUrl));
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

        public async Task<IEnumerable<SimsAttachmentFileInfo>> FetchAllAttchmentsLinks(string listName)
        {
            var accessToken = await fetchAccessToken();
            using (var ctx = SpContextHelper.GetClientContextWithAccessToken(this.siteUrl, accessToken))
            {
                var theLib = await EnsureList(listName, ctx);
                var files = theLib.RootFolder.Files;
                ctx.Load(files, o => o.Include(p => p.ListItemAllFields["EncodedAbsUrl"], p => p.Name));
                await ctx.ExecuteQueryAsync();
                return files.Select(p => new SimsAttachmentFileInfo { FileName = p.Name, Url = p.ListItemAllFields["EncodedAbsUrl"] as string }).ToList();
            }
        }

        public async Task<(string fileName, string url)> RenameAttachment(string fileName, string url)
        {
            var accessToken = await fetchAccessToken();
            using (var ctx = SpContextHelper.GetClientContextWithAccessToken(this.siteUrl, accessToken))
            {
                // Load the file, but then we need to check to make sure the new file name does not already exist.
                var file = ctx.Web.GetFileByUrl(url);
                ctx.Load(file, f => f.ListItemAllFields["FileDirRef"], f => f.ListItemAllFields["EncodedAbsUrl"]);
                await ctx.ExecuteQueryAsync();
                if (file != null)
                {
                    // Check to see if there is already a file with the new file file.
                    var newFilename = file.ListItemAllFields["FileDirRef"] + "/" + fileName;
                    try
                    {
                        var existingFile = ctx.Web.GetFileByServerRelativeUrl(newFilename);
                        ctx.Load(existingFile);
                        await ctx.ExecuteQueryAsync();
                        if (existingFile.ServerObjectIsNull.HasValue ? !existingFile.ServerObjectIsNull.Value : false)
                        { throw new ArgumentOutOfRangeException("File already exists"); };
                    }
                    catch (ServerException e) when (e.Message.Contains("File Not Found."))
                    {
                        file.MoveTo(newFilename, MoveOperations.RetainEditorAndModifiedOnMove);
                        ctx.Load(file, f => f.ListItemAllFields["EncodedAbsUrl"]);
                        await ctx.ExecuteQueryAsync();
                        return (fileName, file.ListItemAllFields["EncodedAbsUrl"] as string);
                    }
                }
            }
            return ("", "");
        }

        public async Task<SimsAttachmentLibraryInfo> EnsureLibrary(string incidentId)
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
                return new SimsAttachmentLibraryInfo
                {
                    WebUrl = webUrl,
                    ServerRelativeFolderUrl = rootFolderUrl
                };
            }
        }

        public async Task<IEnumerable<SimsSignalIncidentMigratedFile>> MigrateToLibrary(string incidentId, string signalId)
        {
            var accessToken = await fetchAccessToken();
            using (var ctx = SpContextHelper.GetClientContextWithAccessToken(this.siteUrl, accessToken))
            {
                // ensure we actually have a signals library
                List signalLib = null;
                try
                {
                signalLib = ctx.Web.Lists.GetByTitle(signalId);
                ctx.Load(signalLib, a => a.RootFolder, a=>a.RootFolder.Files);
                    await ctx.ExecuteQueryAsync();

                }
                catch(ServerException ex)
                {
                    return Enumerable.Empty<SimsSignalIncidentMigratedFile>();
                }
                
                // If we actually have no files, then we can return
                if(signalLib.RootFolder.Files.Count==0) return Enumerable.Empty<SimsSignalIncidentMigratedFile>(); 

                // othewise continue with the incident
                var incidentLib = ctx.Web.Lists.GetByTitle(incidentId);
                ctx.Load(incidentLib, a => a.RootFolder);
                await ctx.ExecuteQueryAsync();
                
                // Get all the signal files and their names
                var signalDictionary = new Dictionary<string, string>();
                foreach(var file in signalLib.RootFolder.Files)
                {
                    signalDictionary.Add(file.Name, file.ServerRelativeUrl);
                }

                // Moves the files over to incidents
                foreach(var file in signalLib.RootFolder.Files)
                {
                    file.MoveTo(Path.Combine(incidentLib.RootFolder.ServerRelativeUrl, file.Name), MoveOperations.Overwrite | MoveOperations.RetainEditorAndModifiedOnMove);
                    file.Update();
                }
                
                await ctx.ExecuteQueryAsync();

                // Once all the files have been moved, we need to update all the files to have the incident id
                ctx.Load(incidentLib, a => a.RootFolder,a=>a.RootFolder.Files,  a => a.RootFolder.Files.Include(o => o.ListItemAllFields));
                await ctx.ExecuteQueryAsync();
                var incidentDictionary = new Dictionary<string, string>();
                foreach(var file in incidentLib.RootFolder.Files)
                {
                    ctx.Load(file, a => a.ListItemAllFields);
                    var fileItem = file.ListItemAllFields;
                    fileItem["ContentTypeId"] = this.contentTypeId;
                    fileItem["SIMSIncidentId"] = incidentId;
                    fileItem.Update();

                    incidentDictionary.Add(file.Name, file.ServerRelativeUrl);
                }

                await ctx.ExecuteQueryAsync();

                return incidentDictionary.Select(a => new SimsSignalIncidentMigratedFile
                {
                    SignalUrl = signalDictionary[a.Key],
                    IncidentUrl = a.Value,
                    FileName= a.Key
                }).ToList();
            }
        }
    }
}
