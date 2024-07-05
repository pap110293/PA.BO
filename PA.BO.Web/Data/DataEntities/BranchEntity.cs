using PA.BO.Web.Core.Interfaces;

namespace PA.BO.Web.Data.DataEntities;

public class BranchEntity : SoftDeletedDataEntity
{
    public string Name { get; set; }
    public string Address { get; set; }
    public bool IsActivated { get; set; }
    public ICollection<EmployeeEntity> Employees { get; set; }
}