using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace SureCompli.EntityFrameworkCore
{
    [DependsOn(
        typeof(SureCompliEntityFrameworkCoreModule)
        )]
    public class SureCompliEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<SureCompliMigrationsDbContext>();
        }
    }
}
