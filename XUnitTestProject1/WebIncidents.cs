using _UnitTests;
using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace FSA.UnitTests.WebApi
{
    public class IncidentT
    {
        public ConfigFile Config { get; }

        public IncidentT()
        {
            this.Config = System.Text.Json.JsonSerializer.Deserialize<ConfigFile>(File.OpenText("./config.json").ReadToEnd());
        }


        public async Task<string> GetAccessToken()
        {
            var httpClient = new HttpClient();
            var formData = new Dictionary<string, string>
            {
                {"client_id",this.Config.clientid },
                {"scope",".default"},
                { "username",this.Config.username},
                { "password", this.Config.password},
                {"client_secret", this.Config.secret },
                {"redirect_uri","https://login.microsoftonline.com/common/oauth2/nativeclient" },
                {"response_type","code"},
                {"response_mode","fragment"}
            };

            var url = $"https://login.microsoftonline.com/organizations/oauth2/v2.0/token";

            var formDataContent = new FormUrlEncodedContent(formData);
            var response = await httpClient.PostAsync(url, formDataContent);
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        [Fact]
        public async Task Test1()
        {
            var tken = await this.GetAccessToken();

            var s = new Incident("New Title", "New Description", 1, 4, 2, null, 1, 1, 1, 2, 4, 2, Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), null, false, 1, null, DateTime.Now, null, Guid.NewGuid().ToString(), DateTime.Now);
            var j = System.Text.Json.JsonSerializer.Serialize(s);
            Console.WriteLine(j);
        }
    }
}
