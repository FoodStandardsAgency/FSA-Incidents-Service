using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities.Incident;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSA.SIMSManagerDb.Builder
{

    internal class IncidentCategoryJoinBuilder : AuditInfoBuilderConfiguration<IncidentCategoryJoinDb>
    {

        public IncidentCategoryJoinBuilder() { }

        public override void Configure(EntityTypeBuilder<IncidentCategoryJoinDb> builder)
        {
            // Required for audit
            base.Configure(builder);
            builder.HasKey(o => new { o.IncidentId, o.IncidentCategoryId});
            builder.HasOne(a => a.Incident)
                .WithMany(a => a.Categories).OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            builder.HasOne(a => a.IncidentCategory)
                .WithMany(a => a.CategoryIncidents).OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);
        }
    }
}
