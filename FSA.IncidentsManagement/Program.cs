using Azure.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;

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
                       config.AddAzureKeyVault(vaultDeets,
                       Environment.GetEnvironmentVariable("SillyRabbit"),
                       Environment.GetEnvironmentVariable("SillyRabbitKey"));
                       config.AddUserSecrets<Startup>();
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
