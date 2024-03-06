namespace PA.BO.Core.Entities.Interfaces;

public interface ITrackable
{
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}