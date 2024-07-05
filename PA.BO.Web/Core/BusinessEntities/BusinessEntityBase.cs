using PA.BO.Web.Core.Interfaces;

namespace PA.BO.Web.Core.BusinessEntities;

public class BusinessEntityBase : ITrackable
{
    public string Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}