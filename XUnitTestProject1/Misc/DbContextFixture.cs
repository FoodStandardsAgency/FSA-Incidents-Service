using _UnitTests;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb;
using FSA.IncidentsManagementDb.Entities.Helpers;
using FSA.IncidentsManagementDb.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace FSA.UnitTests.Misc
{
    public class DbContextFixture : IDisposable
    {
        public ConfigFile Config { get; }

        private string[] titleList;
        private SqlConnection dbConn;
        private object _lock = new object();
        private bool _databaseInit;

        public DbContextFixture()
        {
            this.Config = System.Text.Json.JsonSerializer.Deserialize<ConfigFile>(File.OpenText("./config.json").ReadToEnd());
            this.titleList = File.ReadAllLines("./ListOfTitles.txt");
            this.dbConn = new SqlConnection(Config.dbConn);
            Seed();

            dbConn.Open();
        }
        // Called in our tests
        public FSADbContext CreateContext()
        {
            var ctx = new FSADbContext(new DbContextOptionsBuilder().UseSqlServer(this.dbConn).Options);
            return ctx;
        }

        private async Task CreateAddress(ISIMSManager sims)
        {
            var addresses = System.Text.Json.JsonSerializer.Deserialize<List<OrganisationAddress>>(File.OpenText("./orgs.json").ReadToEnd());
            await sims.Addresses.Add(addresses);
            await sims.Addresses.AssignNotifiers(NotifierTypes.LocalAuthority, Enumerable.Range(1, 407).ToList());


            await sims.Addresses.AssignFbo(FboTypes.Consignor | FboTypes.Exporter, 408);
            await sims.Addresses.AssignFbo(FboTypes.Exporter | FboTypes.Farmer, 409);
            await sims.Addresses.AssignFbo(FboTypes.Manufacturer | FboTypes.Exporter | FboTypes.Consignor, 410);
            await sims.Addresses.AssignFbo(FboTypes.E_platform_Market | FboTypes.Storage | FboTypes.Wholesaler, 411);

        }

        private async Task CreateIncidents(ISIMSManager sims, FSADbContext ctx, SeedIncidents seeder)
        {
            var iManager = new FSA.IncidentsManagementDb.Repositories.IncidentsManagement(ctx, Config.username);
            List<Task<BaseIncident>> TaskList = new List<Task<BaseIncident>>();
            await iManager.Add(seeder.GetNewIncidents());
            var coreIncident = seeder.GetNewIncidents().ElementAt(0);
            var newBatch = new List<BaseIncident>();
            for (var x = 0; x < 9000 / 20; ++x)
            {
                foreach (var title in this.titleList)
                {
                    var newIncident = coreIncident.WithTitle($"{title}-{x}")
                                                  .WithStatus((int)IncidentStatus.Unassigned)
                                                  .WithLeadOfficer("");
                    newBatch.Add(newIncident);
                }
            }

            await iManager.Add(newBatch);
        }
        private async Task CreateProducts(ISIMSManager sims, SeedIncidents seeder)
        {
            var products = seeder.GetNewProducts();
            var tasks = products.Select(p => sims.Products.Add(p.IncidentId,p ));
            await Task.WhenAll(tasks);
        }

        private void Seed()
        {
            lock (_lock)
            {
                if (!_databaseInit)
                {
                    using (var ctx = this.CreateContext())
                    {
                        ctx.Database.EnsureDeleted();
                        ctx.Database.Migrate();

                        var seeder = new SeedIncidents();
                        ISIMSManager SIMS = new SIMSDataManager(ctx, Config.username);
                        var t2 = CreateIncidents(SIMS, ctx, seeder);

                        try
                        {
                            t2.Wait();

                            //Task.WhenAll(TaskList.ToArray());

                        }
                        catch (AggregateException ex)
                        {
                            var res = ex.Flatten();
                            Debug.WriteLine(res);
                        }
                        var t3 = CreateAddress(SIMS);
                        try
                        {
                            t3.Wait();

                            //Task.WhenAll(TaskList.ToArray());

                        }
                        catch (AggregateException ex)
                        {
                            var res = ex.Flatten();
                            Debug.WriteLine(res);
                        }
                        var t4 = CreateProducts(SIMS, seeder);

                        try
                        {
                            t4.Wait();

                            //Task.WhenAll(TaskList.ToArray());

                        }
                        catch (AggregateException ex)
                        {
                            var res = ex.Flatten();
                            Debug.WriteLine(res);
                        }

                    }
                    _databaseInit = true;
                }
            }
        }

        public void Dispose() => this.dbConn.Dispose();
    }
}
