using PA.BO.Web.Core.Interfaces;

namespace PA.BO.Web.Core.Entities;

public class TrackableEntity : Entity, ITrackable
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}