using PA.BO.Web.Core.Interfaces;

namespace PA.BO.Web.Core.BusinessEntities;

public class Branch : BusinessEntityBase, IActivatable
{
    public string Name { get; set; }
    public string Address { get; set; }
    public bool IsActivated { get; set; }
    public ICollection<Employee> Employees { get; set; }
}