using _UnitTests;
using EntityFrameworkCore.TemporalTables.Extensions;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb;
using FSA.IncidentsManagementDb.Entities.Helpers;
using FSA.IncidentsManagementDb.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.UnitTests.Misc
{
    public class DbContextFixture : IDisposable
    {
        public ConfigFile Config { get; }

        private string[] titleList;
        private SqlConnection dbConn;
        private ServiceCollection services;
        private object _lock = new object();
        private bool _databaseInit;
        private ServiceProvider provider;

        public DbContextFixture()
        {
            this.Config = System.Text.Json.JsonSerializer.Deserialize<ConfigFile>(File.OpenText("./config.json").ReadToEnd());
            this.titleList = File.ReadAllLines("./ListOfTitles.txt");
            this.dbConn = new SqlConnection(Config.dbConn);
            this.services = new ServiceCollection();

            SetUpDbContext(Config.dbConn);
            Seed();
        }

        private void SetUpDbContext(string conn)
        {

            var dbContextBuilder = new DbContextOptionsBuilder<FSADbContext>();

            services.AddDbContext<FSADbContext>((provider, options) =>
            {
                options.UseSqlServer(conn);
                options.UseInternalServiceProvider(provider);
            });

            services.AddEntityFrameworkSqlServer();
            services.RegisterTemporalTablesForDatabase<FSADbContext>();

            this.provider = services.BuildServiceProvider();

        }

        // Called in our tests
        public FSADbContext CreateContext()
        {
            var dbContextBuilder = new DbContextOptionsBuilder<FSADbContext>();
            dbContextBuilder.UseSqlServer(Config.dbConn);
            dbContextBuilder.UseInternalServiceProvider(provider);

            return new FSADbContext(dbContextBuilder.Options);
        }

        private async Task CreateAddress(ISIMSManager sims)
        {
            var addresses = System.Text.Json.JsonSerializer.Deserialize<List<SimsAddress>>(File.OpenText("./orgs.json").ReadToEnd());

            await sims.Addresses.Add(addresses.GetRange(0, addresses.Count - 9));

            var Not1 = await sims.Addresses.Add(addresses.ElementAt(addresses.Count - 9));
            var Not2 = await sims.Addresses.Add(addresses.ElementAt(addresses.Count - 8));
            var Not3 = await sims.Addresses.Add(addresses.ElementAt(addresses.Count - 7));

            var add1 = await sims.Addresses.Add(addresses.ElementAt(addresses.Count - 6));
            var add2 = await sims.Addresses.Add(addresses.ElementAt(addresses.Count - 5));
            var add3 = await sims.Addresses.Add(addresses.ElementAt(addresses.Count - 4));
            var add4 = await sims.Addresses.Add(addresses.ElementAt(addresses.Count - 3));
            var add5 = await sims.Addresses.Add(addresses.ElementAt(addresses.Count - 2));
            var add6 = await sims.Addresses.Add(addresses.ElementAt(addresses.Count - 1));


            await sims.Addresses.AssignNotifiers(NotifierTypes.LocalAuthority, Enumerable.Range(1, 407).ToList());
            await sims.Addresses.AssignNotifier(NotifierTypes.Retailer, Not1.Id);
            await sims.Addresses.AssignNotifier(NotifierTypes.Manufacturer, Not2.Id);
            await sims.Addresses.AssignNotifier(NotifierTypes.PublicIndividual, Not3.Id);

            await sims.Addresses.AssignFbo(FboTypes.Consignor | FboTypes.Exporter, add1.Id);
            await sims.Addresses.AssignFbo(FboTypes.Exporter | FboTypes.Farmer, add2.Id);
            await sims.Addresses.AssignFbo(FboTypes.Manufacturer | FboTypes.Exporter | FboTypes.Consignor, add3.Id);
            await sims.Addresses.AssignFbo(FboTypes.E_platform_Market | FboTypes.Storage | FboTypes.Wholesaler, add4.Id);
            await sims.Addresses.AssignFbo(FboTypes.Processor | FboTypes.Wholesaler, add5.Id);
            await sims.Addresses.AssignFbo(FboTypes.Supplier | FboTypes.Transporter | FboTypes.Retailer, add6.Id);

        }

        private async Task CreateIncidents(ISIMSManager sims, FSADbContext ctx, SeedIncidents seeder)
        {
            var iManager = new FSA.IncidentsManagementDb.Repositories.IncidentsManagement(ctx);
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
            var tasks = products.Select(p => sims.Products.Add(p.IncidentId, p));
            await Task.WhenAll(tasks);

            await sims.Products.AssignFbo(1, 1);
            await sims.Products.AssignFbo(1, 2);
            await sims.Products.AssignFbo(1, 3);

            await sims.Products.AssignFbo(2, 4);
            await sims.Products.AssignFbo(2, 5);
            await sims.Products.AssignFbo(2, 6);
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
