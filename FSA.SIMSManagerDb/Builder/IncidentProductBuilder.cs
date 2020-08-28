using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSA.SIMSManagerDb.Builder
{
    internal class IncidentProductBuilder : AuditInfoBuilderConfiguration<IncidentProductDb>
    {
        public override void Configure(EntityTypeBuilder<IncidentProductDb> builder)
        {
            base.Configure(builder);

            builder.HasMany(o => o.RelatedFBOs)
                   .WithOne(o => o.Product);

            builder.Property(p => p.Name).IsRequired();
            builder.HasOne(p => p.Incident)
                   .WithMany(i => i.Products)
                   .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            builder.HasOne(i => i.ProductType)
                    .WithMany()
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(o => o.AmountUnitType)
                   .WithMany()
                   .OnDelete(DeleteBehavior.NoAction);
            builder.Property(o => o.Amount).HasDefaultValue("0.00");

        }
    }
}
