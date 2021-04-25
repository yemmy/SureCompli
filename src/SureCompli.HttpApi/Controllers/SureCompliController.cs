using SureCompli.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SureCompli.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class SureCompliController : AbpController
    {
        protected SureCompliController()
        {
            LocalizationResource = typeof(SureCompliResource);
        }
    }
}