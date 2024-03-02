namespace PABo.Core.Entities;

public class Employee : _Entity
{
    public User User { get; set; }
    public ICollection<Shop> Shops { get; set; }
}