using PABo.Core.Enums;

namespace PABo.Core.Entities;

public class File : _Entity
{
    public DataType DataType { get; set; }
    public string Data { get; set; }
}