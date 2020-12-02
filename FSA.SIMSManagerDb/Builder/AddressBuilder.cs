using EntityFrameworkCore.TemporalTables.Extensions;
using FSA.SIMSManagerDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSA.SIMSManagerDb.Builders
{
    internal class AddressBuilder : AuditInfoBuilderConfiguration<AddressDb>
    {
        public override void Configure(EntityTypeBuilder<AddressDb> builder)
        {
            base.Configure(builder);

            builder.Property(a => a.AddressLine1).HasMaxLength(400);
            builder.Property(a => a.AddressLine2).HasMaxLength(400);
            builder.Property(a => a.County).HasMaxLength(80);
            builder.Property(a => a.PostCode).HasMaxLength(20);
            builder.UseTemporalTable();

        }
    }

}
