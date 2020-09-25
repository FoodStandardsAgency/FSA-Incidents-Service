using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities.Signals;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSA.SIMSManagerDb.Builder
{
    internal class SignalIncidentLinkBuilder : AuditInfoBuilderConfiguration<SignalIncidentLinkDb>
    {
        public override void Configure(EntityTypeBuilder<SignalIncidentLinkDb> builder)
        {
            base.Configure(builder);

            builder.HasKey(o => new { o.SignalId, o.IncidentId });
        }
    }
}
