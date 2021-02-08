using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Microsoft.WindowsAzure.Storage.Table;
using SIMS.OnlineForm.Functions.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SIMS.OnlineForm.Functions
{
    public static class OnlineFormEntryQueueProcess
    {
        private static HttpClient _client = new HttpClient();
        [FunctionName("OnlineFormEntryQueueProcess")]
        public static async Task Run([QueueTrigger("%OnlineFormQueueName%", Connection = "ConnectionStrings:SIMSOnlineFormConnection")] string rawForm, 
            
            [Table("OnlineFormSequester", "ConnectionStrings:SIMSOnlineFormConnection")] IAsyncCollector<TableEntity> tblClient,
            ILogger log)
        {
            try
            {
                var doc = JsonDocument.Parse(rawForm);
                // Extract the recetly generated reference no.
                var refNo = doc.RootElement.GetProperty("Incidents").GetProperty("IncidentTitle").GetString();
#if DEBUG
                try
                {
                    log.LogInformation($"Addding to table storage: {refNo}");
                    var partiionKey = DateTime.Now.Date.ToShortDateString().Replace("/", "-");
                    await tblClient.AddAsync(new FormProcessingEntity(partiionKey, refNo) { FormData = doc.RootElement.GetRawText() });
                }
                catch (Exception ex)
                {
                    log.LogCritical("Could now squestor online-form data", ex);
                }

#endif

                log.LogInformation($"Online form entity received: {refNo}");
                // Get the token
                var token = await TokenFetcherHelper.FetchToken(_client, log);
                await SendForm(refNo, rawForm, token, log);
            }
            catch(KeyNotFoundException ex)
            {
                log.LogCritical("Reference number not found.",ex);
            }
        }

        private static async Task SendForm(string refId, string rawBody, string token, ILogger log)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, Environment.GetEnvironmentVariable("OnlineFormDestination"));
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            request.Content = new StringContent(rawBody, Encoding.UTF8);
            var result = await _client.SendAsync(request);
            if(!result.IsSuccessStatusCode)
            {
                var msg = $"Failed to send : {refId} : Status {result.StatusCode}";
                log.LogCritical(msg);
                var errorBody = await result.Content.ReadAsStringAsync();
                log.LogCritical(errorBody,refId);
                throw new ArgumentOutOfRangeException(msg);
            }
        }
    }
}
