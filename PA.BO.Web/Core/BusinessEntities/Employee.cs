using PA.BO.Web.Core.Interfaces;

namespace PA.BO.Web.Core.BusinessEntities;

public class Employee : IActivatable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public bool IsActivated { get; set; }
    public Branch Branch { get; set; }
    public ICollection<CheckTime> CheckTimes { get; set; }
    public ICollection<TimeSheet> TimeSheets { get; set; }
}