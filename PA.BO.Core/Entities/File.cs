using PA.BO.Core.Enums;

namespace PA.BO.Core.Entities;

public class File : _Entity
{
    public DataType DataType { get; set; }
    public string Data { get; set; }
}