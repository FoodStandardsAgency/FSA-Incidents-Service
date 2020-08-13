using FSA.IncidentsManagement;
using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagementDb.Entities.Helpers;
using FSA.UnitTests.Misc;
using Microsoft.AspNetCore.Authorization.Policy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace FSA.IntegrationTesting
{
    public class FluentValidationIntegration
    {
        public string[] Users { get; }

        private readonly TestServer _server;
        private readonly HttpClient _client;
        public FluentValidationIntegration()
        {

            this.Users = new SeedIncidents().userIds; 
            _server = new TestServer(new WebHostBuilder()
                    .ConfigureAppConfiguration(c =>
                    {
                        c.AddJsonFile("appsettings.Development.json");
                    })
                   .ConfigureServices(i => i.AddSingleton<IPolicyEvaluator, FakeUserPolicy>())
                   .UseStartup<Startup>());

            _client = _server.CreateClient();
            _client.DefaultRequestHeaders
                                .Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        [Fact]
        public async Task SaveIncidentOpenNoLeadOfficer()
        {
            try
            {
                var response = await _client.GetAsync("/api/incidents?id=21");
                response.EnsureSuccessStatusCode();
                var mdl = await response.Content.ReadFromJsonAsync<WebIncidentDisplayModel>().ConfigureAwait(false);
                var incident = ConvertBaseIncident(mdl);
                // Remove the lead officer and make it open.
                // This should not save
                incident.LeadOfficer = "";
                incident.StatusId = (int)IncidentStatus.Open;
               
                var postedResponse = await _client.PutAsJsonAsync("api/Incidents?id=21", incident);
                postedResponse.EnsureSuccessStatusCode();
                if (!postedResponse.IsSuccessStatusCode)
                {
                    var errorContent = await postedResponse.Content.ReadAsStringAsync();
                    Debug.WriteLine(errorContent);
                }
                Assert.False(postedResponse.IsSuccessStatusCode);
            }
            catch (HttpRequestException ex) when (ex.StatusCode.Value != HttpStatusCode.NotFound)
            {
                Assert.True(ex.StatusCode == HttpStatusCode.BadRequest);
            }
        }

        [Fact]
        public async Task SaveIncidentOpenWithLeadOfficer()
        {
            try
            {
                var response = await _client.GetAsync("/api/incidents?id=21");
                response.EnsureSuccessStatusCode();
                var mdl = await response.Content.ReadFromJsonAsync<WebIncidentDisplayModel>().ConfigureAwait(false);
                var incident = ConvertBaseIncident(mdl);
                // Remove the lead officer and make it open.
                // This should not save
                incident.LeadOfficer = this.Users[0];
                incident.StatusId = (int)IncidentStatus.Open;

                var inci = System.Text.Json.JsonSerializer.Serialize(incident);
                var postedResponse = await _client.PutAsJsonAsync("api/Incidents?id=21", incident);
                postedResponse.EnsureSuccessStatusCode();
                Assert.True(postedResponse.IsSuccessStatusCode);
            }
            catch (HttpRequestException ex) when (ex.StatusCode.Value != HttpStatusCode.NotFound)
            {
                Assert.True(ex.StatusCode == HttpStatusCode.BadRequest);
            }
        }

        public void Dispose()
        {
            _server.Dispose();
            _client.Dispose();
        }

        IncidentUpdateModel ConvertBaseIncident(WebIncidentDisplayModel @this) => new IncidentUpdateModel
        {
            Id = @this.CommonId,
            AdminLeadId = @this.AdminLeadId,
            LAAdvised = @this.LAAdvised,
            ClassificationId = @this.ClassificationId,
            DataSourceId = @this.DataSourceId,
            DeathIllnessId = @this.DeathIllnessId,
            IncidentDescription = @this.IncidentDescription,
            ContactMethodId = @this.ContactMethodId,
            IncidentTitle = @this.IncidentTitle,
            LeadLocalAuthorityId = @this.LeadLocalAuthorityId,
            IncidentTypeId = @this.IncidentTypeId,
            PrincipalFBOId = @this.PrincipalFBOId,
            FieldOfficer = @this.FieldOfficer,
            LeadOffice = @this.LeadOffice,
            LeadOfficer = @this.LeadOfficer,
            NotifierId = @this.NotifierId,
            PriorityId = @this.PriorityId,
            ProductTypeId = @this.ProductTypeId,
            SignalStatusId = @this.SignalStatusId,
            SignalUrl = @this.SignalUrl,
            StatusId = @this.StatusId
        };
    }
}
