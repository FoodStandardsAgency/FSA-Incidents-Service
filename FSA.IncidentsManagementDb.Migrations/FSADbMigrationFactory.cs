using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
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
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();
            var conString = configuration.GetConnectionString("migrate");
            return new FSADbContext(new DbContextOptionsBuilder().UseSqlServer(conString).Options);
        }
    }
}
