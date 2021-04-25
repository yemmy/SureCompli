using SureCompli.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SureCompli.Web.Pages
{
    public abstract class SureCompliPageModel : AbpPageModel
    {
        protected SureCompliPageModel()
        {
            LocalizationResourceType = typeof(SureCompliResource);
        }
    }
}