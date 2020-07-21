using EntityFrameworkCore.TemporalTables.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSA.IncidentsManagementDb.Migrations
{
    public class FSADbMigrationFactory : IDesignTimeDbContextFactory<FSADbContext>
    {
        public FSADbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            IServiceCollection services = new ServiceCollection();

            var dbContextBuilder = new DbContextOptionsBuilder<FSADbContext>();
            var connection= configuration.GetConnectionString("migrate");

            services.AddDbContext<FSADbContext>((provider, options) =>
            {
                options.UseSqlServer(configuration.GetConnectionString("migrate"));
                options.UseInternalServiceProvider(provider);
            });

            services.AddEntityFrameworkSqlServer();
            services.RegisterTemporalTablesForDatabase<FSADbContext>();

            var provider = services.BuildServiceProvider();
            
            dbContextBuilder.UseSqlServer(connection);
            dbContextBuilder.UseInternalServiceProvider(provider);
            return provider.GetService<FSADbContext>();
        }
    }
}
