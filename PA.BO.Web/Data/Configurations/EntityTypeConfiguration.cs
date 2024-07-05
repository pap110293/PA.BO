using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using PA.BO.Web.Common.Interfaces;
using PA.BO.Web.Core.Interfaces;
using PA.BO.Web.Data.DataEntities;

namespace PA.BO.Web.Data.Configurations;

public abstract class EntityTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : DataEntityBase
{
    public void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.Id).HasValueGenerator<SampleIDGenerator>();

        var entityType = typeof(TEntity);
        if (typeof(ITrackable).IsAssignableFrom(entityType))
        {
            builder.Property(i => i.CreatedAt).IsRequired();
            builder.Property(i => i.UpdatedAt);
        }

        if (typeof(IActivatable).IsAssignableFrom(entityType))
        {
            builder.Property(i => i.IsActivated).IsRequired();
        }
        
        ConfigureEntity(builder);
    }

    protected abstract void ConfigureEntity(EntityTypeBuilder<TEntity> builder);
}

public class SampleIDGenerator(IClock clock) : ValueGenerator
{
    public override bool GeneratesTemporaryValues => false;

    protected override object NextValue(EntityEntry entry)
    {
        return clock.Now.Ticks + Guid.NewGuid().ToString("N");
    }
}