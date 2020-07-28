using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Azure.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Graph;

namespace FSA.IncidentsManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) =>
                {
                    string vaultDeets = Environment.GetEnvironmentVariable("VaultUri");
                    var keyVaultEndpoint = new Uri(vaultDeets);
                    if (context.HostingEnvironment.IsDevelopment())
                    {
                        Func<string, string> blarg = (v) => Environment.GetEnvironmentVariable(v);
                       config.AddUserSecrets<Startup>();
                       config.AddAzureKeyVault(vaultDeets,
                       Environment.GetEnvironmentVariable("SillyRabbit"),
                       Environment.GetEnvironmentVariable("SillyRabbitKey"));
                    }
                    else
                    {
                        config.AddAzureKeyVault(
                        keyVaultEndpoint,
                        new DefaultAzureCredential());

                    }

                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
