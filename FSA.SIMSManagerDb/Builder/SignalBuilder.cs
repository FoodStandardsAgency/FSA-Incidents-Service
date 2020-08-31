using FSA.SIMSManagerDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FSA.SIMSManagerDb.Builders
{
    internal class SignalBuilder : AuditInfoBuilderConfiguration<SignalDb>
    {

        public override void Configure(EntityTypeBuilder<SignalDb> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.PublishedDate).HasConversion(b => b, b => DateTime.SpecifyKind(b, DateTimeKind.Utc));
            builder.Property(p => p.InsertedDate).HasConversion(b => b, b => DateTime.SpecifyKind(b, DateTimeKind.Utc));

            builder.Property(p => p.Title).HasMaxLength(500);
            builder.Property(p => p.DataSource).IsRequired(true);

            builder.Property(p => p.FoodOrFeed).HasMaxLength(500);
            builder.Property(p => p.BaseProduct).HasMaxLength(500);
            builder.Property(p => p.CountryOfOrigin).HasMaxLength(500).IsRequired(false);
            builder.Property(p => p.NotifyingCountry).HasMaxLength(500).IsRequired(false);

            
            builder.HasMany(p => p.FromLinks)
                   .WithOne(o => o.From)
                   .HasForeignKey(o => o.FromId).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(p => p.ToLinks)
                   .WithOne(o => o.To)
                    .HasForeignKey(o => o.ToId).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(p => p.Notes)
                .WithOne(p => p.Signal)
                .HasForeignKey(k => k.HostId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.Stakeholders)
                .WithOne(p => p.Signal)
                .HasForeignKey(k => k.HostId).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(p => p.Attachments)
                .WithOne(p => p.Signal)
                .HasForeignKey(k => k.HostId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
