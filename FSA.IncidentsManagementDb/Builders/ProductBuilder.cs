using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSA.IncidentsManagementDb.Builders
{
    internal class ProductBuilder : AuditInfoBuilderConfiguration<ProductDb>
    {

        public override void Configure(EntityTypeBuilder<ProductDb> builder)
        {
            base.Configure(builder);

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
        }
    }
}