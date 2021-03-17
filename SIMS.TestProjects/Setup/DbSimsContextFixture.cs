using AutoMapper;
using EntityFrameworkCore.TemporalTables.Extensions;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Repositories;
using FSA.SIMSManagerDbEntities.Helpers;
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

        private async Task CreateAddress(ISimsDbHost sims, IMapper map)
        {
            var viewAddressModels = System.Text.Json.JsonSerializer.Deserialize<List<SimsAddressViewModel>>(File.OpenText("./Setup/orgs.json").ReadToEnd());
            var addresses = map.Map<List<SimsAddress>>(viewAddressModels);
            await sims.Addresses.Add(addresses);

            var cString = ((JsonElement)Config["ConnectionStrings:FSADbConn"]).ToString();
            var conn = new SqlConnection(cString);
            conn.Open();
            var sqlFile = File.ReadAllText("./Setup/LaFiles.sql");

            var sqlCmd = new SqlCommand(sqlFile, conn);
            sqlCmd.ExecuteNonQuery();
            conn.Close();
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
                                                  .WithStatus((int)SimsIncidentStatusTypes.Unassigned)
                                                  .WithLeadOfficer("");
                    newBatch.Add(newIncident);
                }
            }

           var numbersTest = coreIncident.WithTitle("Number Searching Test Incident 1234 1234.5678 RIM2021.123 RIM2021-123 (1234)")
                                                   .WithStatus((int)SimsIncidentStatusTypes.Unassigned)
                                                  .WithLeadOfficer("");

            newBatch.Add(numbersTest);
            await iManager.Add(newBatch);
        }

        private async Task CreateIncidentProducts(ISimsDbHost sims, SeedingConfigData seeder)
        {
            var products = seeder.GetNewProducts();
            var tasks = products.Select(p => sims.Incidents.Products.Add(p.HostId, p));
            await Task.WhenAll(tasks);

            await sims.Incidents.Products.Fbos.Add(1, 1, (int)(FboTypes.Consignor | FboTypes.Exporter | FboTypes.Hospitality_service));
            await sims.Incidents.Products.Fbos.Add(1, 2, (int)FboTypes.Unknown);
            await sims.Incidents.Products.Fbos.Add(1, 3, (int)(FboTypes.Importer | FboTypes.Manufacturer));

            await sims.Incidents.Products.Fbos.Add(2, 4, (int)(FboTypes.Retailer | FboTypes.Manufacturer));
            await sims.Incidents.Products.Fbos.Add(2, 5, (int)(FboTypes.Packer_filler | FboTypes.Storage));
            await sims.Incidents.Products.Fbos.Add(2, 6, (int)FboTypes.Unknown);

        }

        private async Task CreateSignals(ISimsDbHost sims)
        {
            var signals = SignalSeed.Signals();

            var signalCount = signals.Count;
            int lastRound = 0;
            while (signalCount > 0)
            {
                var thisRound = 400;

                if (thisRound >= signalCount)
                    thisRound = signalCount;
                await sims.Signals.AddBatch(signals.Skip(lastRound).Take(thisRound).ToList());
                signalCount = signalCount - thisRound;
                lastRound = thisRound;
            }

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

        private async Task CreateOnlineFormEntries(ISimsDbHost sims, SeedingConfigData seeder)
        {
            var forms = seeder.GetOnlineFormData.ToList();
            var stakeholders = seeder.GetOnlineFormStakeholders.ToList();
            var products = seeder.GetOnlineFormProducts.ToList();
            await sims.OnlineForms.AddBatch(forms);

            await sims.OnlineForms.Stakeholders.Add(1, stakeholders[0]);
            await sims.OnlineForms.Stakeholders.Add(2, stakeholders[1]);
            await sims.OnlineForms.Stakeholders.Add(3, stakeholders[2]);
            await sims.OnlineForms.Stakeholders.Add(4, stakeholders[3]);
            await sims.OnlineForms.Stakeholders.Add(5, stakeholders[4]);

            await sims.OnlineForms.Stakeholders.Add(6, stakeholders[5]);
            await sims.OnlineForms.Stakeholders.Add(7, stakeholders[6]);
            await sims.OnlineForms.Stakeholders.Add(8, stakeholders[7]);
            await sims.OnlineForms.Stakeholders.Add(9, stakeholders[8]);
            await sims.OnlineForms.Stakeholders.Add(10, stakeholders[9]);

            await sims.OnlineForms.Stakeholders.Add(11, stakeholders[10]);
            await sims.OnlineForms.Stakeholders.Add(12, stakeholders[11]);
            await sims.OnlineForms.Stakeholders.Add(13, stakeholders[12]);
            await sims.OnlineForms.Stakeholders.Add(14, stakeholders[13]);
            await sims.OnlineForms.Stakeholders.Add(15, stakeholders[14]);

            await sims.OnlineForms.Products.Add(1, products[0]);

            await sims.OnlineForms.Products.Add(2, products[1]);
            await sims.OnlineForms.Products.Add(2, products[2]);

            await sims.OnlineForms.Products.Add(3, products[3]);
            await sims.OnlineForms.Products.Add(3, products[2]);
            await sims.OnlineForms.Products.Add(3, products[4]);

            await sims.OnlineForms.Products.Add(4, products[2]);
            await sims.OnlineForms.Products.Add(4, products[0]);
            await sims.OnlineForms.Products.Add(4, products[1]);
            await sims.OnlineForms.Products.Add(4, products[4]);
            await sims.OnlineForms.Products.Add(4, products[3]);
            await sims.OnlineForms.Products.Add(5, products[4]);

            await sims.OnlineForms.Products.Add(6, products[1]);
            await sims.OnlineForms.Products.Add(7, products[2]);
            await sims.OnlineForms.Products.Add(8, products[3]);
            await sims.OnlineForms.Products.Add(9, products[4]);
            await sims.OnlineForms.Products.Add(10, products[0]);


            await sims.OnlineForms.Notes.Add(1,  @"Stakeholder Address
                        Sally Stakeholder
                        AddressLine1,
                        AddressLine2
                        Town
                        County
                        PostCode", 0);
            await sims.OnlineForms.Notes.Add(3, @"Stakeholder Address
                        Henry plate
                        AddressLine1,
                        AddressLine2
                        Town
                        County
                        PostCode",(32+128+256));
            await sims.OnlineForms.Notes.Add(4, @"Stakeholder Address
                        Mavis Coupe
                        AddressLine1,
                        AddressLine2
                        Town
                        County
                        PostCode",1);
            await sims.OnlineForms.Notes.Add(5, @"Stakeholder Address
                        Jame Flan
                        AddressLine1,
                        AddressLine2
                        Town
                        County
                        PostCode",(1+1024+4096));
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

                        var seeder = new SeedingConfigData();
                        var mapper = seeder.GetDbAutoMapper();

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

                        var t3 = CreateAddress(SIMS, mapper);
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
                        }
                        catch (AggregateException ex)
                        {
                            var res = ex.Flatten();
                            Debug.WriteLine(res);
                            throw (ex);
                        }
                        var t9 = CreateOnlineFormEntries(SIMS, seeder);
                        try
                        {
                            t9.Wait();
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
