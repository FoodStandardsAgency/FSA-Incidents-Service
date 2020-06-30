using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{
    internal class NotifierTypeBuilder : AuditInfoBuilderConfiguration<NotifierTypeDb>
    {
        public override void Configure(EntityTypeBuilder<NotifierTypeDb> builder)
        {
            base.Configure(builder);
            builder.Property(o => o.Title)
                .IsRequired().HasMaxLength(255);

        }
    }
}
