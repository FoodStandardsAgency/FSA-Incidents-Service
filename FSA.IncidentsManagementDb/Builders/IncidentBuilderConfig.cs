using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{
    internal class IncidentBuilderConfig : AuditInfoBuilderConfiguration<IncidentDb>
    {
        public IncidentBuilderConfig()
        {
        }

        public override void Configure(EntityTypeBuilder<IncidentDb> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.MostUniqueId).HasDefaultValueSql("newid()");
            
        }
    }
}
