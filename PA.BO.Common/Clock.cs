namespace PA.BO.Common;

public class Clock : IClock
{
    DateTime IClock.Now => DateTime.Now;
}