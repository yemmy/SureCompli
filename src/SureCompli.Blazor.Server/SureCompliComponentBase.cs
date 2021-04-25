using SureCompli.Localization;
using Volo.Abp.AspNetCore.Components;

namespace SureCompli.Blazor.Server
{
    public abstract class SureCompliComponentBase : AbpComponentBase
    {
        protected SureCompliComponentBase()
        {
            LocalizationResource = typeof(SureCompliResource);
        }
    }
}
