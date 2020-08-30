using AutoMapper;
using AutoMapper.Configuration;
using FSA.SIMSManagerDb;
using FSA.SIMSManagerDb.MapperProfile;
using FSA.SIMSManagerDb.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FSA.IncidentsManagementDb.Migrations
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await newVersionRepo();
        }

        private static async Task newVersionRepo()
        {
            Microsoft.Extensions.Configuration.IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            var cfg = new MapperConfigurationExpression();
            cfg.AddProfile<SIMSMappingProfile>();
            var mapperConfig = new MapperConfiguration(cfg);
            var mapper = new Mapper(mapperConfig);

            var connection = configuration.GetConnectionString("migrateSims");
            var dbContextBuilder = new DbContextOptionsBuilder<SimsDbContext>()
                .UseSqlServer(connection);

            using (var ctx = new SimsDbContext(dbContextBuilder.Options))
            {
                var host = new SimsDbHost(ctx, mapper, "Paul Lawrence");

                var incidentLinks = new IncidentLinkedRecords(ctx, mapper);
                var signalLinks = new SignalsLinkedRecords(ctx, mapper);

                var Iitems = await incidentLinks.AddLinks(5, new int[] { 8, 10 }, "Money");
                var Sitems = await signalLinks.AddLinks(1, new int[] { 2 }, "");
            }

        }


        private static void GottaNumber(string srchTerms, Regex matcher)
        {
            var mc = matcher.Matches(srchTerms);

            if (mc.Count > 0)
            {
                var result = String.Join("", mc.Select(o => o.Groups["number"].Value));
                var finalForm = int.TryParse(result, out var num) ? num : 0;
                Console.WriteLine(finalForm);
            }
            else
            {

                Console.WriteLine($"No match : ${srchTerms}");
            }

        }
    }
}