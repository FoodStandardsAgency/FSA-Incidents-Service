using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSA.SIMSManagerDb.Builder
{
    internal class SignalProductBuilder : AuditInfoBuilderConfiguration<SignalProductDb>
    {
        public override void Configure(EntityTypeBuilder<SignalProductDb> builder)
        {
            base.Configure(builder);

            builder.HasMany(o => o.RelatedFBOs)
                   .WithOne(o => o.Product)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.Property(p => p.Name).IsRequired();
            
            builder.HasOne(p => p.Host)
                   .WithMany(i => i.Products)
                   .OnDelete(DeleteBehavior.NoAction);

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
