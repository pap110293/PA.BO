using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PA.BO.Web.Common.Interfaces;
using PA.BO.Web.Core.Interfaces;
using PA.BO.Web.Data.DataEntities;

namespace PA.BO.Web.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IClock clock)
    : IdentityDbContext<ApplicationUser, ApplicationRole, string>(options)
{
    public DbSet<BranchEntity> Branches { get; set; }
    public DbSet<CheckTimeEntity> CheckTimes { get; set; }
    public DbSet<EmployeeEntity> Employees { get; set; }
    public DbSet<PermissionEntity> Permissions { get; set; }
    public DbSet<TimeSheetEntity> TimeSheets { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.ApplyConfigurationsFromAssembly(
            Assembly.GetExecutingAssembly(), 
            t => t.GetInterfaces().Any(i => 
                i.IsGenericType &&
                i.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>) &&
                typeof(DataEntityBase).IsAssignableFrom(i.GenericTypeArguments[0]))
        );

        builder.Entity<ApplicationUser>().Property(i => i.IsActivated).HasDefaultValue(true);
        builder.Entity<ApplicationRole>().Property(i => i.IsActivated).HasDefaultValue(true);
    }
    
    public override EntityEntry Update(object entity)
    {
        TrackingUpdateAt(entity);
        return base.Update(entity);
    }
    
    public override EntityEntry<TEntity> Update<TEntity>(TEntity entity)
    {
        TrackingUpdateAt(entity);
        return base.Update(entity);
    }

    private void TrackingUpdateAt(object entity)
    {
        if (entity is ITrackable trackableEntity)
        {
            trackableEntity.UpdatedAt = clock.Now;
        }
    }

    public override EntityEntry Add(object entity)
    {
        TrackingCreated(entity);
        return base.Add(entity);
    }

    public override EntityEntry<TEntity> Add<TEntity>(TEntity entity)
    {
        TrackingCreated(entity);
        return base.Add(entity);
    }

    public override ValueTask<EntityEntry> AddAsync(object entity, CancellationToken cancellationToken = new CancellationToken())
    {
        TrackingCreated(entity);
        return base.AddAsync(entity, cancellationToken);
    }

    private void TrackingCreated(object entity)
    {
        if (entity is ITrackable trackableEntity)
        {
            trackableEntity.CreatedAt = clock.Now;
        }
    }
}