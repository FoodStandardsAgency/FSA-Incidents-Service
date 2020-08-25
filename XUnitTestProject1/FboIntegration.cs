﻿using FSA.IncidentsManagement;
using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Models;
using FSA.UnitTests.Misc;
using Microsoft.AspNetCore.Authorization.Policy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
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
                    .ConfigureAppConfiguration(c =>
                    {
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
        public async Task GetProduct()
        {

            var response = await _client.GetAsync("/api/Products?productId=1");
            var product = await response.Content.ReadFromJsonAsync<Product>();
            Assert.True(product.Id == 1);

        }

        [Fact]
        public async Task AddAddress()
        {
            var newAddress = new SimsAddressViewModel
            {
                Title = "Integration Address",
                AddressLine1 = "Addr 1",
                AddressLine2 = "Addr 2",
                CountryId = 118,
                County = "Cleethrpes",
                PostCode = "Cn1 PP2",
                EmailAddress = "integration@emailAddress.com",
                MainContact = "Sally Ride",
                TelephoneNumber = "01234 567890",
                ContactMethodId =1
            };
            var addedResponse = await _client.PostAsJsonAsync("/api/Addresses", newAddress);
            var addedAddress = await addedResponse.Content.ReadFromJsonAsync<SimsAddressViewModel>();
            Assert.True(addedAddress.Title == "Integration Address");
        }

        [Fact]
        public async Task AssignProductFbo()
        {
            var response = await _client.PostAsJsonAsync<ProductAddress>("/api/Products/AssignFbo", new ProductAddress { AddressId = 6, Id = 3 });
            var product = await response.Content.ReadAsStringAsync();
            Assert.True(product != null);
        }

        [Fact]
        public async Task RemoveProductFbo()
        {
            var response = await _client.PostAsJsonAsync<ProductAddress>("/api/Products/RemoveFbo", new ProductAddress { AddressId = 6, Id = 3 });
            var product = await response.Content.ReadAsStringAsync();
            Assert.True(product != null);
        }

        [Fact]
        public async Task GetIncidentMissingId()
        {
            try
            {
                var response = await _client.GetFromJsonAsync<WebIncidentDisplayModel>("/api/incidents?incidentId=21");
                //Assert.IsType<IncidentsDisplayModel>(response);
            }
            catch (Exception ex)
            {
                Assert.IsType<HttpRequestException>(ex);

            }
        }

        [Fact]
        public async Task GetIncident()
        {
            var response = await _client.GetFromJsonAsync<WebIncidentDisplayModel>("/api/incidents?id=21");
            Assert.IsType<WebIncidentDisplayModel>(response);
        }

        public void Dispose()
        {
            _server.Dispose();
            _client.Dispose();
        }
    }
}
