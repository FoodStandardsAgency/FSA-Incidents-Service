using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
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
        }
    }
}
