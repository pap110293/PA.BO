using Microsoft.AspNetCore.Identity;
using PA.BO.Web.Core.Interfaces;
using PA.BO.Web.Data.DataEntities;

namespace PA.BO.Web.Data;

public class ApplicationRole : IdentityRole, IActivatable
{
    public ICollection<PermissionEntity> Permissions { get; set; }
    public bool IsActivated { get; set; }
}