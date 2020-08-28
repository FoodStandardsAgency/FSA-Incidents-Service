using EntityFrameworkCore.TemporalTables.Extensions;
using FSA.SIMSManagerDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace FSA.IncidentsManagementDb.Migrations
{
    public class SIMSdbMigrationFactory : IDesignTimeDbContextFactory<SimsDbContext>
    {
        public SimsDbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            IServiceCollection services = new ServiceCollection();

            var dbContextBuilder = new DbContextOptionsBuilder<SimsDbContext>();
            var connection = configuration.GetConnectionString("migrateSims");

            services.AddDbContext<SimsDbContext>((provider, options) =>
            {
                options.UseSqlServer(configuration.GetConnectionString("migrateSims"));
                options.UseInternalServiceProvider(provider);
            });

            services.AddEntityFrameworkSqlServer();
            services.RegisterTemporalTablesForDatabase<SimsDbContext>();

            var provider = services.BuildServiceProvider();

            dbContextBuilder.UseSqlServer(connection);
            dbContextBuilder.UseInternalServiceProvider(provider);
            return provider.GetService<SimsDbContext>();
        }
    }
}
