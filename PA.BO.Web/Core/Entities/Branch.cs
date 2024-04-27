namespace PA.BO.Web.Core.Entities;

public class Branch : TrackableEntity
{
    public string Name { get; set; }
    public string Address { get; set; }
    public bool Enable { get; set; }
}