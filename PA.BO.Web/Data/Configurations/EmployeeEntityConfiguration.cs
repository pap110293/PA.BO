using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PA.BO.Web.Data.DataEntities;

namespace PA.BO.Web.Data.Configurations;

public class EmployeeEntityConfiguration : EntityTypeConfiguration<EmployeeEntity>
{
    protected override void ConfigureEntity(EntityTypeBuilder<EmployeeEntity> builder)
    {
        builder.ToTable("Employees");

        builder.Property(i => i.PhoneNumber).HasMaxLength(DataConstant.SORT_TEXT_LENGTH).IsRequired();
        builder.Property(i => i.Email).HasMaxLength(DataConstant.SORT_TEXT_LENGTH);
        builder.Property(i => i.FirstName).HasMaxLength(DataConstant.SORT_TEXT_LENGTH);
        builder.Property(i => i.LastName).HasMaxLength(DataConstant.SORT_TEXT_LENGTH);

        builder.HasOne(i => i.ApplicationUser);
        
        builder.HasMany(i => i.TimeSheets)
            .WithMany(i => i.Employees);
        
        builder.HasOne(i => i.Branch)
            .WithMany(i => i.Employees)
            .HasForeignKey(i => i.BranchId);
        
        builder.HasQueryFilter(i => !i.IsDeleted);
    }
}