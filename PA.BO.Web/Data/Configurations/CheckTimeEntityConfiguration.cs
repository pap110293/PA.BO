using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PA.BO.Web.Data.DataEntities;

namespace PA.BO.Web.Data.Configurations;

public class CheckTimeEntityConfiguration : EntityTypeConfiguration<CheckTimeEntity>
{
    protected override void ConfigureEntity(EntityTypeBuilder<CheckTimeEntity> builder)
    {
        builder.ToTable("CheckTimes");

        builder.Property(i => i.CheckAt).IsRequired();
        builder.HasOne(i => i.Employee)
            .WithMany(i => i.CheckTimes)
            .HasForeignKey(i => i.EmployeeId);
    }
}