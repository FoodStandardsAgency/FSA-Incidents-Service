using FSA.SIMSManagerDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FSA.SIMSManagerDb.Builders
{
    internal class IncidentBuilder : AuditInfoBuilderConfiguration<IncidentDb>
    {
        public IncidentBuilder()
        {
        }

        public override void Configure(EntityTypeBuilder<IncidentDb> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.MostUniqueId).HasDefaultValueSql("newid()");
            builder.HasAlternateKey(o => o.MostUniqueId);
            builder.Property(o => o.IncidentCreated).IsRequired()
                                                 .HasDefaultValueSql("getutcdate()")
                                                .ValueGeneratedOnAdd()
                                                .HasConversion(b => b, b => DateTime.SpecifyKind(b, DateTimeKind.Utc));
            builder.Property(p => p.IncidentStatusId).HasDefaultValue(4);    // UNassigned
            builder.Property(p => p.PriorityId).HasDefaultValue(1);   // TBC
            
            builder.HasMany(p => p.FromLinks)
                   .WithOne(o => o.From)
                   .HasForeignKey(o => o.FromId).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(p => p.ToLinks)
                   .WithOne(o => o.To)
                    .HasForeignKey(o => o.ToId).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(p => p.Notes)
                    .WithOne(p => p.Incident)
                    .HasForeignKey(k => k.HostId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.Stakeholders)
                    .WithOne(p => p.Incident)
                    .HasForeignKey(k => k.HostId).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(p => p.Attachments)
                    .WithOne(p => p.Incident)
                    .HasForeignKey(k => k.HostId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
