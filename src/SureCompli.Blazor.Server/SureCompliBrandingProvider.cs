using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SureCompli.Blazor.Server
{
    [Dependency(ReplaceServices = true)]
    public class SureCompliBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "SureCompli";
    }
}
