using EntityFrameworkCore.TemporalTables.Extensions;
using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSA.IncidentsManagementDb.Builders
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
