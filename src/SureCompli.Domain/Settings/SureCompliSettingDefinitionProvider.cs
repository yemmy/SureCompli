using Volo.Abp.Settings;

namespace SureCompli.Settings
{
    public class SureCompliSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(SureCompliSettings.MySetting1));
        }
    }
}
