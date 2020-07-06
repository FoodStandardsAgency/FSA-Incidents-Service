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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
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
            List<Task<int>> vs = new List<Task<int>>();
            await sims.Addresses.AssignNotifiers(NotifierTypes.LocalAuthority, Enumerable.Range(1, 407));
            

            await sims.Addresses.AssignFbo(FboTypes.Consignor | FboTypes.Exporter, 408);
            await sims.Addresses.AssignFbo(FboTypes.Exporter | FboTypes.Farmer, 409);
            await sims.Addresses.AssignFbo(FboTypes.Manufacturer | FboTypes.Exporter | FboTypes.Consignor, 410);
            await sims.Addresses.AssignFbo(FboTypes.E_platform_Market | FboTypes.Storage | FboTypes.Wholesaler , 411);

        }

        private void Seed()
        {
            lock (_lock)
            {
                if (!_databaseInit)
                {
                    using(var ctx = this.CreateContext())
                    {
                        ctx.Database.EnsureDeleted();
                        ctx.Database.Migrate();


                        var seeder = new SeedIncidents();
                        ISIMSManager SIMS = new SIMSDataManager(ctx, "00000000-0000-0000-0000-000000000001");
                        var iManager = new FSA.IncidentsManagementDb.Repositories.IncidentsManagement(ctx, "00000000-0000-0000-0000-000000000001");
                        List<Task<BaseIncident>> TaskList = new List<Task<BaseIncident>>();
                        var task = iManager.Add(seeder.GetNewIncidents());
                        //TaskList.AddRange(seeder.GetNewIncidents().Select(a => SIMS.Incidents.Add(a)).ToList());
                        var coreIncident = seeder.GetNewIncidents().ElementAt(0);
                        var newBatch = new List<BaseIncident>();
                        for (var x=0;x<9000/20;++x)
                        {
                            foreach(var title in this.titleList )
                            {
                                var newIncident = coreIncident.WithTitle($"{title}-{x}")
                                                              .WithStatus((int)IncidentStatus.Open)
                                                              .WithLeadOfficer("");
                                newBatch.Add(newIncident);
                            }
                        }

                        var t2 = iManager.Add(newBatch);
                        try
                        {
                            task.Wait();
                            t2.Wait();
                            //Task.WhenAll(TaskList.ToArray());

                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex);
                        }
                        var t3 = CreateAddress(SIMS);
                        try
                        {
                            t3.Wait();
                            //Task.WhenAll(TaskList.ToArray());

                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex);
                        }

                    }
                    _databaseInit = true;
                }
            }
        }

        public void Dispose() => this.dbConn.Dispose();
    }
}
