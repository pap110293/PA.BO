using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PA.BO.Web.Data.DataEntities;

namespace PA.BO.Web.Data.Configurations;

public class BranchEntityConfiguration : EntityTypeConfiguration<BranchEntity>
{
    protected override void ConfigureEntity(EntityTypeBuilder<BranchEntity> builder)
    {
        builder.ToTable("Branches");
        builder.Property(i => i.Name).HasMaxLength(DataConstant.SORT_TEXT_LENGTH).IsRequired();
        builder.Property(i => i.Address).HasMaxLength(DataConstant.LONG_TEXT_LENGTH);
        builder.HasMany(i => i.Employees)
            .WithOne(i => i.Branch)
            .HasForeignKey(i => i.BranchId);
        builder.HasQueryFilter(i => !i.IsDeleted);
    }
}