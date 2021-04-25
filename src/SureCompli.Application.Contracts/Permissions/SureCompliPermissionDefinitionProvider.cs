using SureCompli.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SureCompli.Permissions
{
    public class SureCompliPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(SureCompliPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(SureCompliPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SureCompliResource>(name);
        }
    }
}
