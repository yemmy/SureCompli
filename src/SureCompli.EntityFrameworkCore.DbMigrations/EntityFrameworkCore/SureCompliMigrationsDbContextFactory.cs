using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SureCompli.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class SureCompliMigrationsDbContextFactory : IDesignTimeDbContextFactory<SureCompliMigrationsDbContext>
    {
        public SureCompliMigrationsDbContext CreateDbContext(string[] args)
        {
            SureCompliEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<SureCompliMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new SureCompliMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SureCompli.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
