using FSA.IncidentsManagement;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FSA.UnitTests 
{
    public class WebIntegration : IDisposable
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public WebIntegration()
        {
            _server = new TestServer(new WebHostBuilder()
                   .UseStartup<Startup>());
            _client = _server.CreateClient();

        }

        [Fact]
        public async Task Test1()
        {
            //var tken = await this.GetAccessToken();

            //var s = new Incident("New Title", "New Description", 1, 4, 2, null, 1, 1, 1, 2, 4, 2, Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), null, false, 1, null, DateTime.Now, null, Guid.NewGuid().ToString(), DateTime.Now);
            //var j = System.Text.Json.JsonSerializer.Serialize(s);
            //Console.WriteLine(j);
        }

        public void Dispose()
        {
            _server.Dispose();
            _client.Dispose();
        }
    }
}
