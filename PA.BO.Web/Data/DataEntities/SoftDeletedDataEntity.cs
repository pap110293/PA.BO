using PA.BO.Web.Core.Interfaces;

namespace PA.BO.Web.Data.DataEntities;

public class SoftDeletedDataEntity : DataEntityBase, ISoftDelete
{
    public bool IsDeleted { get; set; }
}