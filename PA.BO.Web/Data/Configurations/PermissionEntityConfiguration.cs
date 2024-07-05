using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PA.BO.Web.Data.DataEntities;

namespace PA.BO.Web.Data.Configurations;

public class PermissionEntityConfiguration : EntityTypeConfiguration<PermissionEntity>
{
    protected override void ConfigureEntity(EntityTypeBuilder<PermissionEntity> builder)
    {
        builder.ToTable("Permissions");

        builder.Property(i => i.Name).HasMaxLength(DataConstant.SORT_TEXT_LENGTH);
        builder.Property(i => i.Description).HasMaxLength(DataConstant.LONG_TEXT_LENGTH);
        builder.HasMany(i => i.Roles).WithMany(i => i.Permissions);
    }
}