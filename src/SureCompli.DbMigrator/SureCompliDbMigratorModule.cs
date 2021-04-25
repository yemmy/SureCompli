using SureCompli.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace SureCompli.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(SureCompliEntityFrameworkCoreDbMigrationsModule),
        typeof(SureCompliApplicationContractsModule)
        )]
    public class SureCompliDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
