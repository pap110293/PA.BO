using Microsoft.AspNetCore.Identity;
using PA.BO.Web.Core.Interfaces;
using PA.BO.Web.Data.DataEntities;

namespace PA.BO.Web.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser, IActivatable
{
    public EmployeeEntity Employee { get; set; }
    public bool IsActivated { get; set; }
}