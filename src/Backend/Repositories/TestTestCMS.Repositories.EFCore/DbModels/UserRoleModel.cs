namespace TestTestCMS.Repositories.EFCore.DbModels;

[Table("UserRoles")]
public class UserRoleModel : SiteAssociatedEntityModel
{
    public Guid UserId { get; set; }
    public Guid RoleId { get; set; }
}
