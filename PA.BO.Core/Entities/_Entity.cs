using PA.BO.Core.Entities.Interfaces;

namespace PA.BO.Core.Entities;

public class _Entity : ITrackable
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}