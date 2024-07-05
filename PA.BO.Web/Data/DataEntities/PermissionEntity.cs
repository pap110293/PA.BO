namespace PA.BO.Web.Data.DataEntities;

public class PermissionEntity : DataEntityBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<ApplicationRole> Roles { get; set; }
}