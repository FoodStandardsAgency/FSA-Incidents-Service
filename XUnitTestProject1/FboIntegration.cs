using FluentValidation.Validators;
using FSA.IncidentsManagement;
using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
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
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FSA.IntegrationTesting 
{
    public class FboIntegration : IDisposable
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public FboIntegration()
        {
            _server = new TestServer(new WebHostBuilder()
                    .ConfigureAppConfiguration(c => {
                        c.AddJsonFile("appsettings.Development.json");
                    })
                   .ConfigureServices(i=>i.AddSingleton<IPolicyEvaluator, FakeUserPolicy>())
                   .UseStartup<Startup>());
            _client = _server.CreateClient();
            _client.DefaultRequestHeaders
        .Accept
        .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        [Fact]
        public async Task GetFboAddress()
        {
            var response = await _client.GetAsync("/api/Addresses/Fbo/1");
            var address = await response.Content.ReadFromJsonAsync<FboAddressModel>();
            Assert.True(address.Id == 1);
        }

        [Fact]
        public async Task GetProduct()
        {

            var response = await _client.GetAsync("/api/Products?productId=1");
            var product = await response.Content.ReadFromJsonAsync<Product>();
            Assert.True(product.Id == 1);

        }

        [Fact]
        public async Task AssignProductFbo()
        {
            var response = await _client.PostAsJsonAsync<AssignItemToFbo>("/api/Products/AssignFbo", new AssignItemToFbo { FboId = 6, Id = 3 });
            var product = await response.Content.ReadAsStringAsync();
            Assert.True(product!=null);
        }

        [Fact]
        public async Task RemoveProductFbo()
        {
            var response = await _client.PostAsJsonAsync<AssignItemToFbo>("/api/Products/RemoveFbo", new AssignItemToFbo { FboId = 6, Id = 3 });
            var product = await response.Content.ReadAsStringAsync();
            Assert.True(product != null);
        }

        public void Dispose()
        {
            _server.Dispose();
            _client.Dispose();
        }
    }
}
