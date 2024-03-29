using PA.BO.Common;

namespace PA.BO.Core.Entities;

public class Document : _Entity
{
    public string Name { get; set; }
    public string Content { get; set; }
    public ICollection<File> Files { get; set; }
}