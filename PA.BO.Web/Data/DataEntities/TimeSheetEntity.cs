using PA.BO.Web.Core.Interfaces;

namespace PA.BO.Web.Data.DataEntities;

public class TimeSheetEntity : DataEntityBase, IActivatable
{
    public DateTime StartAt { get; set; }
    public DateTime EndAt { get; set; }
    public bool IsActivated { get; set; }
    public ICollection<EmployeeEntity> Employees { get; set; }
}