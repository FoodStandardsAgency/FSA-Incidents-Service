using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.Graph;
using Microsoft.Graph.Auth;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FSA.Attachments
{
    public class AttachmentTerms : IFSATermStore
    {
        private readonly HttpClient client;
        private readonly string incidentTermsSetId;
        private readonly string tagsTermSetId;

        public AttachmentTerms(HttpClient client,  string incidentTermsSetId, string TagsTermSetId)
        {
            //this.graphClient = new GraphServiceClient(authProvider);
            this.client = client;
            this.incidentTermsSetId = incidentTermsSetId;
            tagsTermSetId = TagsTermSetId;
        }

        public async Task EnsureIncidentIdExists(string incidentId, string tkn)
        {
            var newRequest = new HttpRequestMessage(HttpMethod.Post, $"https://graph.microsoft.com/beta/termStore/sets/{this.incidentTermsSetId}/children");
          
            var newTerm = "{\"labels\":[{\"name\":\"" + incidentId + "\",\"isDefault\":true,\"languageTag\":\"en-US\"}]}";
            
            newRequest.Content = new StringContent(newTerm, Encoding.UTF8, "application/json");
            newRequest.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tkn);
            var result = await client.SendAsync(newRequest);
            var bdy = await result.Content.ReadAsStringAsync();
        }

        

        //internal async Task<string> CreateList(string incidentId, string siteId)
        //{
        //    // Need to create the list
        //    var newList = new List
        //    {
        //        DisplayName = incidentId,
        //        ListInfo = new ListInfo { Template = "documentLibrary" }
        //    };


        //    var list = await graphClient.Sites[siteId].Lists
        //            .Request()
        //            .WithMaxRetry(TimeSpan.FromSeconds(45))
        //            .WithMaxRetry(4)
        //            .AddAsync(newList);

        //    return list.Id;
        //}

        //internal async Task<(string siteId, string listId)> EnsureList(string incidentId)
        //{

        //    var site = await graphClient.Sites[$"{hostSiteCol}:/{docSiteUrl}"]
        //        .Request()
        //        .WithMaxRetry(TimeSpan.FromSeconds(45))
        //        .WithMaxRetry(4)
        //        .GetAsync();
        //    var siteId = site.Id;
        //    try
        //    {


        //        var listInfo = await graphClient.Sites[siteId].Lists[incidentId]
        //                        .Request()
        //                        .WithMaxRetry(TimeSpan.FromSeconds(45))
        //                        .WithMaxRetry(4)
        //                        .GetAsync();
        //        return (siteId, listInfo.Id);
        //    } // 404
        //    catch (ServiceException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
        //    {
        //        return (siteId, await this.CreateList(incidentId, siteId));
        //    }
        //}
    }
}
