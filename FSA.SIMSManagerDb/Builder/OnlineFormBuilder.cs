using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSA.SIMSManagerDb.Builder
{
    internal class OnlineFormBuilder : AuditInfoBuilderConfiguration<OnlineFormDb>
    {
        public override void Configure(EntityTypeBuilder<OnlineFormDb> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Title).HasMaxLength(250);
            builder.Property(p => p.ReferenceNo).IsRequired().HasMaxLength(200);

            builder.HasMany(p => p.Notes)
                    .WithOne(p => p.OnlineForm)
                    .HasForeignKey(k => k.HostId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.Stakeholders)
                    .WithOne(p => p.OnlineForm)
                    .HasForeignKey(k => k.HostId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(a => a.NotifierType)
                    .WithMany()
                    .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
