using PA.BO.Web.Core.Interfaces;

namespace PA.BO.Web.Core.BusinessEntities;

public class TimeSheet : BusinessEntityBase, IActivatable
{
    public DateTime StartAt { get; set; }
    public DateTime EndAt { get; set; }
    public bool IsActivated { get; set; }
    public Employee Employee { get; set; }
}