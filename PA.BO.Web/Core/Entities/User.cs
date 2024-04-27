using Microsoft.AspNetCore.Identity;

namespace PA.BO.Web.Core.Entities;

public class User : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Branch Branch { get; set; }
}