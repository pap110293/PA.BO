using PA.BO.Web.Core.Interfaces;

namespace PA.BO.Web.Data.DataEntities;

public class DataEntityBase : ITrackable
{
    public string Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public bool IsActivated { get; set; }
}