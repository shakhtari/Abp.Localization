using ML.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ML.Permissions;

public class MLPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MLPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MLPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MLResource>(name);
    }
}
