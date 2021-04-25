using Volo.Abp.Modularity;

namespace SureCompli
{
    [DependsOn(
        typeof(SureCompliApplicationModule),
        typeof(SureCompliDomainTestModule)
        )]
    public class SureCompliApplicationTestModule : AbpModule
    {

    }
}