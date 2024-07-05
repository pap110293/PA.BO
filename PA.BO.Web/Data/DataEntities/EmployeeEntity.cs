using PA.BO.Web.Core.Interfaces;

namespace PA.BO.Web.Data.DataEntities;

public class EmployeeEntity : SoftDeletedDataEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public bool IsActivated { get; set; }
    public string BranchId { get; set; }
    public BranchEntity Branch { get; set; }
    public string ApplicationUserId { get; set; }
    public ApplicationUser ApplicationUser { get; set; }
    public ICollection<CheckTimeEntity> CheckTimes { get; set; }
    public ICollection<TimeSheetEntity> TimeSheets { get; set; }
}