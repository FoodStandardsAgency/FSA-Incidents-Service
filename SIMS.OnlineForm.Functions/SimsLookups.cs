using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using SIMS.OnlineForm.Functions.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;

namespace SIMS.OnlineForm.Functions
{
    public static class SimsLookups
    {
        private static HttpClient client = new HttpClient();

        [FunctionName("SimsLookups")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            try
            {
                log.LogInformation("Requesting Online form lookups.");
                var token = await TokenFetcherHelper.FetchToken(client, log);
                var lookups = await FetchLookups(client, token, log);
                return new OkObjectResult(lookups); // new { ClientId = Environment.GetEnvironmentVariable("ClientId"), ClientSecret = Environment.GetEnvironmentVariable("ClientSecret") });
            }
            catch (NullReferenceException)
            {
                return new BadRequestErrorMessageResult("Failed to fetch token");
            }

        }


        private static async Task<SimsLookupsHost> FetchLookups(HttpClient client, string token, ILogger log)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, Environment.GetEnvironmentVariable("LookupsEndpoint"));
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var result = await client.SendAsync(request);

            var lookups = await result.Content.ReadAsAsync<SimsLookupsHost>();

            return lookups;
        }

    }
}