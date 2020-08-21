using EntityFrameworkCore.TemporalTables.Extensions;
using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSA.IncidentsManagementDb.Builders
{
    internal class AddressContactBuilder : AuditInfoBuilderConfiguration<AddressContactDb>
    {
        public override void Configure(EntityTypeBuilder<AddressContactDb> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name).HasMaxLength(255).IsRequired();
            builder.UseTemporalTable();

        }
    }

}
