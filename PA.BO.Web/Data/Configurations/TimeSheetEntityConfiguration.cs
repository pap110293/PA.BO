using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PA.BO.Web.Data.DataEntities;

namespace PA.BO.Web.Data.Configurations;

public class TimeSheetEntityConfiguration : EntityTypeConfiguration<TimeSheetEntity>
{
    protected override void ConfigureEntity(EntityTypeBuilder<TimeSheetEntity> builder)
    {
        builder.ToTable("TimeSheets");

        builder.Property(i => i.StartAt).IsRequired();
        builder.Property(i => i.EndAt).IsRequired();
        builder.HasMany(i => i.Employees)
            .WithMany(i => i.TimeSheets);
    }
}