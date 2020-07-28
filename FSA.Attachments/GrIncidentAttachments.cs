using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.Graph;
using Microsoft.Graph.Auth;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FSA.Attachments
{
    public class GrIncidentAttachments 
    {
        private readonly string hostSiteCol;
        private readonly string docSiteUrl;
        private readonly string cTypeId;
        private GraphServiceClient graphClient;
        private string[] scopes = new string[] { "https://graph.microsoft.com/Sites.ReadWrite.All" };
        public GrIncidentAttachments(string clientId, string clientSecret, string tenantId, string hostSiteCol, string docSiteUrl, string cTypeId)
        {
            var cd = ConfidentialClientApplicationBuilder
                        .Create(clientId)
                        .WithClientSecret(clientSecret)
                        .WithTenantId(tenantId)
                        .Build();
            var authProvider = new ClientCredentialProvider(cd);
            
            this.graphClient = new GraphServiceClient(authProvider);
            this.hostSiteCol = hostSiteCol;
            this.docSiteUrl = docSiteUrl;
            this.cTypeId = cTypeId;
        }

        internal async Task<string> CreateList(string incidentId, string siteId)
        {
            // Need to create the list
            var newList = new List
            {
                DisplayName = incidentId,
                ListInfo = new ListInfo { Template = "documentLibrary" }
            };


            var list = await graphClient.Sites[siteId].Lists
                    .Request()
                    .WithMaxRetry(TimeSpan.FromSeconds(45))
                    .WithMaxRetry(4)
                    .AddAsync(newList);

            return list.Id;
        }

        internal async Task<(string siteId, string listId)> EnsureList(string incidentId)
        {

            var site = await graphClient.Sites[$"{hostSiteCol}:/{docSiteUrl}"]
                .Request()
                .WithMaxRetry(TimeSpan.FromSeconds(45))
                .WithMaxRetry(4)
                .GetAsync();
            var siteId = site.Id;
            try
            {


                var listInfo = await graphClient.Sites[siteId].Lists[incidentId]
                                .Request()
                                .WithMaxRetry(TimeSpan.FromSeconds(45))
                                .WithMaxRetry(4)
                                .GetAsync();
                return (siteId, listInfo.Id);
            } // 404
            catch (ServiceException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return (siteId, await this.CreateList(incidentId, siteId));
            }
        }

        public async Task<(string filename, string url)> AddAttachment(string filePath, string fileName, string incidentId)
        {
            // Get the list info
          var listDetails =  await EnsureList(incidentId);

            using (var stream = new FileStream(filePath, FileMode.Open))
            {

                var newListItem = new ListItem
                {
                    Name = $"{incidentId}",
                    ContentType = new ContentTypeInfo { Id = this.cTypeId }
                };

            var newItem = await graphClient.Sites[listDetails.siteId]
                                       .Lists[listDetails.listId].Items.Request()
                                       .AddAsync(newListItem);
                //.GetAsync();

                // [listDetails.listId].Root.ItemWithPath(file).Content.Request().PutAsync<DriveItem>(stream);
            }


            return ("", "");
        }

        public Task<IEnumerable<(string filename, string url)>> FetchAllAttchmentsLinks(string incidentId)
        {
            throw new NotImplementedException();
        }

        public Task<IncidentAttachment> FetchAttachment(string url)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RenameAttachment(string fileName, string url)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ReplaceAttachment(FileStream filem, string url)
        {
            throw new NotImplementedException();
        }
    }
}
