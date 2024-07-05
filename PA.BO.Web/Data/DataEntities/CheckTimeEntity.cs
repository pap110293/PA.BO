namespace PA.BO.Web.Data.DataEntities;

public class CheckTimeEntity : DataEntityBase
{
    public DateTime CheckAt { get; set; }
    public string EmployeeId { get; set; }
    public EmployeeEntity Employee { get; set; }
}