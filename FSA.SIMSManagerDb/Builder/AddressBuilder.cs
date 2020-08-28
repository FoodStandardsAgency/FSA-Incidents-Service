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

            builder.UseTemporalTable();

        }
    }

}
