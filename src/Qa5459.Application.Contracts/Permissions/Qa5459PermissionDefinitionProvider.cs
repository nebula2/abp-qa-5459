using Qa5459.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Qa5459.Permissions;

public class Qa5459PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Qa5459Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Qa5459Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Qa5459Resource>(name);
    }
}
