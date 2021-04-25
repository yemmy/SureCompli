using System;
using System.Collections.Generic;
using System.Text;
using SureCompli.Localization;
using Volo.Abp.Application.Services;

namespace SureCompli
{
    /* Inherit your application services from this class.
     */
    public abstract class SureCompliAppService : ApplicationService
    {
        protected SureCompliAppService()
        {
            LocalizationResource = typeof(SureCompliResource);
        }
    }
}
