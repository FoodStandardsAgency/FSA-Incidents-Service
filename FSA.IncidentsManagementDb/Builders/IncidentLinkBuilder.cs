using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{
    class IncidentLinkBuilder : AuditInfoBuilderConfiguration<IncidentLinkDb>
    {

        public override void Configure(EntityTypeBuilder<IncidentLinkDb> builder)
        {
            base.Configure(builder);
            builder.HasKey(p => new { p.FromIncidentId, p.ToIncidentId });
            builder.HasOne(p => p.FromIncident).WithMany(b => b.FromLinks)
                    .HasForeignKey(o => o.FromIncidentId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(p => p.ToIncident).WithMany(b => b.ToLinks)
                    .HasForeignKey(o => o.ToIncidentId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
