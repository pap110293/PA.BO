namespace PA.BO.Web.Core.BusinessEntities;

public class CheckTime : BusinessEntityBase
{
    public DateTime CheckAt { get; set; }
    public Employee Employee { get; set; }
}