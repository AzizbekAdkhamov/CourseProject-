namespace PersonalCollection.Domain.Entities.User;
public static  class RolePermission
{
    public static Dictionary<Roles, Permissions> RolePermissions = new Dictionary<Roles, Permissions>
    {
        {Roles.Guest, Permissions.CanRead },
        {Roles.User, Permissions.CanRead | Permissions.CanLike | Permissions.CanUpdate | Permissions.CanComment |  Permissions.CanCreate |Permissions.CanDelete },
        {Roles.Admin , Permissions.CanRead | Permissions.CanLike | Permissions.CanUpdate| Permissions.CanComment| Permissions.CanCreate | Permissions.CanDelete | Permissions.CanBlock | Permissions.CanUnblock},
        {Roles.SuperAdmin , Permissions.CanRead | Permissions.CanLike | Permissions.CanUpdate | Permissions.CanComment | Permissions.CanCreate | Permissions.CanDelete | Permissions.CanBlock | Permissions.CanUnblock | Permissions.AddAdmin}
    };
}
