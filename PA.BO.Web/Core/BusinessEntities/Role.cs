namespace PA.BO.Web.Core.BusinessEntities;

public class Role : BusinessEntityBase
{
    public string Name { get; set; }
    public ICollection<Employee> Employees { get; set; }
    public ICollection<Permission> Permissions { get; set; }
}