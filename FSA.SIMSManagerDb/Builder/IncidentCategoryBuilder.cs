using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities.Lookups;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSA.SIMSManagerDb.Builder
{
    internal class IncidentCategoryBuilder : BasicLookupsBuilder<IncidentCategoryDb>
    {
        public IncidentCategoryBuilder()
        {
        }
        public override void Configure(EntityTypeBuilder<IncidentCategoryDb> builder)
        {
            base.Configure(builder);
            //builder.HasMany(a => a.CategoryIncidents)
            //    .WithOne().OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

        }
    }
}
