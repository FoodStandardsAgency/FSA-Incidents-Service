using AutoMapper;
using AutoMapper.Configuration;
using EntityFrameworkCore.TemporalTables.Extensions;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Entities.Helpers;
using FSA.SIMSManagerDb;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.MapperProfile;
using FSA.SIMSManagerDb.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SIMS.TestProjects.Seeeds;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks; 

namespace SIMS.TestProjects.Setup
{
    public class DbSimsContextFixture : IDisposable
    {
        private IDictionary<string, object> Config;
        private string[] titleList;
        private SqlConnection dbConn;
        private ServiceCollection services;

        public string UserId { get; }

        private object _lock = new object();
        private bool _databaseInit;
        private ServiceProvider provider;

        public DbSimsContextFixture()
        {
            var seedInfo = new SeedingConfigData();

            this.Config = seedInfo.GetConfigData();
            var conn = ((JsonElement)Config["ConnectionStrings:FSADbConn"]).ToString();
            this.titleList = File.ReadAllLines("./Setup/ListOfTitles.txt");
            this.dbConn = new SqlConnection();
            this.services = new ServiceCollection();
            this.UserId = ((JsonElement)Config["username"]).ToString();
            SetUpDbContext(conn);
            Seed();
        }

        private void SetUpDbContext(string conn)
        {

            var dbContextBuilder = new DbContextOptionsBuilder<SimsDbContext>();

            services.AddDbContext<SimsDbContext>((provider, options) =>
            {
                options.UseSqlServer(conn);
                options.UseInternalServiceProvider(provider);
            });

            services.AddEntityFrameworkSqlServer();
            services.RegisterTemporalTablesForDatabase<SimsDbContext>();

            this.provider = services.BuildServiceProvider();

        }

        // Called in our tests
        public SimsDbContext CreateContext()
        {
            var dbContextBuilder = new DbContextOptionsBuilder<SimsDbContext>();
            dbContextBuilder.UseSqlServer(((JsonElement)Config["ConnectionStrings:FSADbConn"]).ToString());
            dbContextBuilder.UseInternalServiceProvider(provider);

            return new SimsDbContext(dbContextBuilder.Options);
        }

        private async Task CreateAddress(ISimsDbHost sims)
        {
            var viewAddressModels = System.Text.Json.JsonSerializer.Deserialize<List<SimsAddressViewModel>>(File.OpenText("./Setup/orgs.json").ReadToEnd());
            var addresses = viewAddressModels.ToSimsClient().ToList();
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


            //await sims.Addresses.AssignNotifiers(NotifierTypes.LocalAuthority, Enumerable.Range(1, 407).ToList());
            //await sims.Addresses.AssignNotifier(NotifierTypes.Retailer, Not1.Id);
            //await sims.Addresses.AssignNotifier(NotifierTypes.Manufacturer, Not2.Id);
            //await sims.Addresses.AssignNotifier(NotifierTypes.PublicIndividual, Not3.Id);

            //await sims.Addresses.AssignFbo(FboTypes.Consignor | FboTypes.Exporter, add1.Id);
            //await sims.Addresses.AssignFbo(FboTypes.Exporter | FboTypes.Farmer, add2.Id);
            //await sims.Addresses.AssignFbo(FboTypes.Manufacturer | FboTypes.Exporter | FboTypes.Consignor, add3.Id);
            //await sims.Addresses.AssignFbo(FboTypes.E_platform_Market | FboTypes.Storage | FboTypes.Wholesaler, add4.Id);
            //await sims.Addresses.AssignFbo(FboTypes.Processor | FboTypes.Wholesaler, add5.Id);
            //await sims.Addresses.AssignFbo(FboTypes.Supplier | FboTypes.Transporter | FboTypes.Retailer, add6.Id);

        }

        private async Task CreateIncidents(ISimsDbHost sims, SimsDbContext ctx, SeedingConfigData seeder)
        {
            var iManager = sims.Incidents;
            List<Task<BaseIncident>> TaskList = new List<Task<BaseIncident>>();
            await iManager.Add(seeder.GetNewIncidents());
            var coreIncident = seeder.GetNewIncidents().ElementAt(0);
            var newBatch = new List<BaseIncident>();
            for (var x = 0; x < 9000 / 20; ++x)
            {
                foreach (var title in this.titleList)
                {
                    var newIncident = coreIncident.WithTitle($"{title}-{x}")
                                                  .WithStatus((int)IncidentStatusTypes.Unassigned)
                                                  .WithLeadOfficer("");
                    newBatch.Add(newIncident);
                }
            }

            await iManager.Add(newBatch);
        }

        private async Task CreateIncidentProducts(ISimsDbHost sims, SeedingConfigData seeder)
        {
            var products = seeder.GetNewProducts();
            var tasks = products.Select(p => sims.Incidents.Products.Add(p.HostId, p));
            await Task.WhenAll(tasks);

            await sims.Incidents.Products.Fbos.Add(1, 1, FboTypes.Consignor | FboTypes.Exporter | FboTypes.Hospitality_service);
            await sims.Incidents.Products.Fbos.Add(1, 2, FboTypes.Unknown);
            await sims.Incidents.Products.Fbos.Add(1, 3, FboTypes.Importer | FboTypes.Manufacturer);

            await sims.Incidents.Products.Fbos.Add(2, 4, FboTypes.Retailer | FboTypes.Manufacturer);
            await sims.Incidents.Products.Fbos.Add(2, 5, FboTypes.Packer_filler | FboTypes.Storage);
            await sims.Incidents.Products.Fbos.Add(2, 6, FboTypes.Unknown);

        }

        private async Task CreateSignals(ISimsDbHost sims)
        {
            var signals = SignalSeed.Signals();
            await sims.Signals.AddBatch(signals.Take(400).ToList());
        }

        private async Task CreateIncidentStakeholders(ISimsDbHost sims, SeedingConfigData seeder)
        {
            var stakeholders = seeder.GetIncidentStakeholder.ToList();

            await sims.Incidents.Stakeholders.Add(stakeholders[0].HostId, stakeholders[0]);
            await sims.Incidents.Stakeholders.Add(stakeholders[1].HostId, stakeholders[1]);
            await sims.Incidents.Stakeholders.Add(stakeholders[2].HostId, stakeholders[2]);
            await sims.Incidents.Stakeholders.Add(stakeholders[3].HostId, stakeholders[3]);

        }

        private async Task CreateSignalStakeholders(ISimsDbHost sims, SeedingConfigData seeder)
        {
            var stakeholders = seeder.GetSignalStakeholder.ToList();

            await sims.Signals.Stakeholders.Add(stakeholders[0].HostId, stakeholders[0]);
            await sims.Signals.Stakeholders.Add(stakeholders[1].HostId, stakeholders[1]);
            await sims.Signals.Stakeholders.Add(stakeholders[2].HostId, stakeholders[2]);
            await sims.Signals.Stakeholders.Add(stakeholders[3].HostId, stakeholders[3]);
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
                        var cfg = new MapperConfigurationExpression();
                        cfg.AddProfile<SimsDbMappingProfile>();
                        var mapperConfig = new MapperConfiguration(cfg);
                        var mapper = new Mapper(mapperConfig);

                        var seeder = new SeedingConfigData();
                        var SIMS = SimsDbHost.CreateHost(ctx, mapper, ((JsonElement)Config["username"]).ToString());
                        var t2 = CreateIncidents(SIMS, ctx, seeder);

                        try
                        {
                            t2.Wait();

                        }
                        catch (AggregateException ex)
                        {
                            var res = ex.Flatten();
                            Debug.WriteLine(res);
                            throw (ex);

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
                            throw (ex);
                        }

                        var t5 = CreateSignals(SIMS);

                        try
                        {
                            t5.Wait();

                        }
                        catch (AggregateException ex)
                        {
                            var res = ex.Flatten();
                            Debug.WriteLine(res);
                            throw (ex);

                        }

                        var t7 = CreateIncidentStakeholders(SIMS, seeder);

                        try
                        {
                            t7.Wait();

                        }
                        catch (AggregateException ex)
                        {
                            var res = ex.Flatten();
                            Debug.WriteLine(res);
                            throw (ex);
                        }

                        var t8 = CreateSignalStakeholders(SIMS, seeder);
                        try
                        {
                            t8.Wait();

                        }
                        catch (AggregateException ex)
                        {
                            var res = ex.Flatten();
                            Debug.WriteLine(res);
                            throw (ex);

                        }
                        var t4 = CreateIncidentProducts(SIMS, seeder);

                        try
                        {
                            t4.Wait();

                            //Task.WhenAll(TaskList.ToArray());

                        }
                        catch (AggregateException ex)
                        {
                            var res = ex.Flatten();
                            Debug.WriteLine(res);
                            throw (ex);
                        }

                    }
                    _databaseInit = true;
                }
            }
        }

        public void Dispose() => this.dbConn.Dispose();
    }

}
