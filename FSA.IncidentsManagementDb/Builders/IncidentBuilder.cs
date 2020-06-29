using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
            builder.Property(p => p.IncidentStatusId).HasDefaultValue(4);    // UNassigned
            builder.Property(p => p.PriorityId).HasDefaultValue(1);   // TBC
        }
    }
}
