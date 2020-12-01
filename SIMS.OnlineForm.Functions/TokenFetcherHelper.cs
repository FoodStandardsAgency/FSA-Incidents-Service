using Microsoft.Extensions.Logging;
using SIMS.OnlineForm.Functions.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SIMS.OnlineForm.Functions
{
    public static class TokenFetcherHelper
    {
        internal static async Task<string> FetchToken(HttpClient client, ILogger log)
        {
            var accessTokenUrl = $"https://login.microsoftonline.com/{GetVar("TenantId")}/oauth2/v2.0/token"; //?clientId={clientId}&scope={scope}&client_secret={clientSecret}&grant_type=client_credentials";

            var dict = new Dictionary<string, string>();
            dict.Add("Content-Type", "application/x-www-form-urlencoded");
            dict.Add("client_id", GetVar("ClientId"));
            dict.Add("client_secret", GetVar("ClientSecret"));
            dict.Add("tenantid", GetVar("TenantId"));
            dict.Add("scope", GetVar("Scope"));
            dict.Add("grant_type", "client_credentials");


            using (var response = await client.PostAsync(accessTokenUrl, new FormUrlEncodedContent(dict)))
            {

                if (response.IsSuccessStatusCode)
                {
                    var body = await response.Content.ReadAsAsync<TokenResult>();
                    return body.access_token;
                }
                else
                {
                    var body = await response.Content.ReadAsStringAsync();
                    log.LogError("Failed to retrieve token");
                    log.LogCritical(body);
                    throw new NullReferenceException("Failed to fetch token");
                }

            }


        }
        private static string GetVar(string varName)
        {
            return Environment.GetEnvironmentVariable(varName);

        }
    }
}
