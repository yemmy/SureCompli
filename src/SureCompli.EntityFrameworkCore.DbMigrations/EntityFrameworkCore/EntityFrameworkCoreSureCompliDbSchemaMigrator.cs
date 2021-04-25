using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SureCompli.Data;
using Volo.Abp.DependencyInjection;

namespace SureCompli.EntityFrameworkCore
{
    public class EntityFrameworkCoreSureCompliDbSchemaMigrator
        : ISureCompliDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreSureCompliDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the SureCompliMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<SureCompliMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}