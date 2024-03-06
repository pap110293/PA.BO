namespace PA.BO.Core.Entities;

public class User : _Entity
{
    public Tenant Tenant { get; set; }
}