using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace SureCompli.Web
{
    [Dependency(ReplaceServices = true)]
    public class SureCompliBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "SureCompli";
    }
}
