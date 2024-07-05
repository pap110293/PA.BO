namespace PA.BO.Web.Core.Interfaces;

public interface ITrackable
{
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}