﻿namespace PA.BO.Web.Common;

public class Clock : IClock
{
    public DateTime Now => DateTime.UtcNow;
}