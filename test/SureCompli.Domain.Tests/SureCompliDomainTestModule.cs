using SureCompli.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SureCompli
{
    [DependsOn(
        typeof(SureCompliEntityFrameworkCoreTestModule)
        )]
    public class SureCompliDomainTestModule : AbpModule
    {

    }
}