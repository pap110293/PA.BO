namespace PABo.Common;

public class Clock : IClock
{
    DateTime IClock.Now => DateTime.Now;
}