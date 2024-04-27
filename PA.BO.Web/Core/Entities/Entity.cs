namespace PA.BO.Web.Core.Entities;

public class Entity
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
}