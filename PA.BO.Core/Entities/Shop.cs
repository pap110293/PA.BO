namespace PA.BO.Core.Entities;

public class Shop : _Entity
{
    public string Name { get; set; }
    public ICollection<Transaction> Transactions { get; set; }
    public ICollection<Employee> Employees { get; set; }
}