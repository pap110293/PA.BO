namespace PABo.Core.Entities;

public class Transaction : _Entity
{
    public Shop Shop { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
}