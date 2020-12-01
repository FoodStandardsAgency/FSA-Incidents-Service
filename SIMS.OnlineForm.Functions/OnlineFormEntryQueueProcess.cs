using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SIMS.OnlineForm.Functions
{
    public static class OnlineFormEntryQueueProcess
    {
        private static HttpClient _client = new HttpClient();
        [FunctionName("OnlineFormEntryQueueProcess")]
        public static async Task Run([QueueTrigger("%OnlineFormQueueName%", Connection = "ConnectionStrings:SIMSOnlineFormConnection")] string rawForm, ILogger log)
        {
            var doc = JsonDocument.Parse(rawForm);
            // Extract the recetly generated reference no.
            var refNo = doc.RootElement.GetProperty("ReferenceNo");
            log.LogInformation($"Online form entity recived: {refNo}");
            var token = await TokenFetcherHelper.FetchToken(_client, log);
            await SendForm(refNo.GetRawText(), rawForm, token, log);
        }

        private static async Task SendForm(string refId, string rawBody, string token, ILogger log)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, Environment.GetEnvironmentVariable("OnlineFormDestination"));
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            //request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Content = new StringContent(rawBody, Encoding.UTF8);//, "text/plain; charset=utf-8");
            //request.Content = new ByteArrayContent()
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
