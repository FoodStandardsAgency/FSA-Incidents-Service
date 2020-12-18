using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using SIMS.OnlineForm.Functions.Models;
using StackExchange.Redis;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;

namespace SIMS.OnlineForm.Functions
{
    public static class SimsLookups
    {
        private static HttpClient client = new HttpClient();
        private static string KeyName = "simslookups";
        private static ConnectionMultiplexer RedisConn;

        [FunctionName("SimsLookups")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,

            ILogger log)
        {
            var cacheConn = Environment.GetEnvironmentVariable("CacheConnection") ?? Environment.GetEnvironmentVariable("ConnectionStrings:CacheConnection");

            RedisConn =  ConnectionMultiplexer.Connect(cacheConn);
 
            try
            {
                var redisDb = RedisConn.GetDatabase();
                var lookupData = redisDb.StringGet(SimsLookups.KeyName);
                var lookupTimeoutMins = int.Parse(Environment.GetEnvironmentVariable("LookupTimeout"));
                if (lookupData == RedisValue.Null)
                {
                    log.LogInformation("Requesting Online form lookups.");
                    var token = await TokenFetcherHelper.FetchToken(client, log);
                    var lookups = await FetchLookups(client, token, log);
                    redisDb.StringSet(KeyName, System.Text.Json.JsonSerializer.Serialize(lookups));
                    redisDb.KeyExpire(KeyName, TimeSpan.FromMinutes(lookupTimeoutMins));
                    return new OkObjectResult(lookups);
                }
                else
                {
                    log.LogInformation("Fetching from cache.");
                    return new OkObjectResult(System.Text.Json.JsonSerializer.Deserialize<SimsLookupsHost>(lookupData));
                }

            }
            catch(RedisException ex)
            {
                log.LogCritical("Redis Error", ex);
                return new BadRequestErrorMessageResult("Failed to fetch lookups.");

            }
            catch (NullReferenceException ex)
            {
                log.LogCritical("Token error", ex);
                return new BadRequestErrorMessageResult("Failed to fetch lookups.");
            }

        }


        private static async Task<SimsLookupsHost> FetchLookups(HttpClient client, string token, ILogger log)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, Environment.GetEnvironmentVariable("LookupsEndpoint"));
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var result = await client.SendAsync(request);

            var lookups = await result.Content.ReadAsAsync<SimsLookupsHost>();
            if (lookups == null)
                lookups = new SimsLookupsHost();
            return lookups;
        }

    }
}