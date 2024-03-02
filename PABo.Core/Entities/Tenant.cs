namespace PABo.Core.Entities;

public class Tenant : _Entity
{
    public string Name { get; set; }
    public ICollection<Shop> Shops { get; set; }
    public User Owner { get; set; }
}