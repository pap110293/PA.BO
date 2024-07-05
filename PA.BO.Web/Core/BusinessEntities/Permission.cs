using PA.BO.Web.Data.DataEntities;

namespace PA.BO.Web.Core.BusinessEntities;

public class Permission : DataEntityBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<Role> Roles { get; set; }
}