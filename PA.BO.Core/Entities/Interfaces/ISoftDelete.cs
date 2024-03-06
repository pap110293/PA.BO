namespace PA.BO.Core.Entities.Interfaces;

public interface ISoftDelete
{
    public DateTime? DeletedAt { get; set; }
}