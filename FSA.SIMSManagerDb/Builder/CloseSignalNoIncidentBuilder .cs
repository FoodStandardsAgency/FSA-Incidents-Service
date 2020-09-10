using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

namespace FSA.SIMSManagerDb.Builder
{
    internal class CloseSignalNoIncidentBuilder : AuditInfoBuilderConfiguration<CloseSignalNoIncident>
    {
        public override void Configure(EntityTypeBuilder<CloseSignalNoIncident> builder)
        {
            base.Configure(builder);
            builder.HasKey(a => a.SignalId);

            builder.HasOne(a => a.Team).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(a => a.Reason).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Property(a => a.UserReason).IsRequired();

        }
    }
}
