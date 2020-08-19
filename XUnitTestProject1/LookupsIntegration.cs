using FSA.IncidentsManagement;
using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Root.Models;
using Microsoft.AspNetCore.Authorization.Policy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace FSA.IntegrationTesting
{
    public  class LookupsIntegration : IDisposable
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public LookupsIntegration()
        {
            _server = new TestServer(new WebHostBuilder()
                    .ConfigureAppConfiguration(c => {
                        c.AddJsonFile("appsettings.Development.json");
                    })
                   .ConfigureServices(i => i.AddSingleton<IPolicyEvaluator, FakeUserPolicy>())
                   .UseStartup<Startup>());
            _client = _server.CreateClient();
            _client.DefaultRequestHeaders
        .Accept
        .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        [Fact]
        public async Task GetClassifications()
        {
            var response = await _client.GetAsync("/api/lookups/Classifications");
            var allClass = await response.Content.ReadFromJsonAsync<IEnumerable<Classification>>();
            Assert.True(allClass.Count() > 0);
        }

        public void Dispose()
        {
            _server.Dispose();
            _client.Dispose();
        }
    }
}
