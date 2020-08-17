using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{
    class IncidentTaggedAttachmentBuilder : AuditInfoBuilderConfiguration<IncidentTaggedAttachmentDb>
    {

        public override void Configure(EntityTypeBuilder<IncidentTaggedAttachmentDb> builder)
        {
            base.Configure(builder);

            // This is actually overkill
            // But I don't like string indexes/keys
            builder.HasKey(td => new { td.IncidentId, td.DocUrl });
            builder.Property(td => td.DocUrl).IsRequired(true).HasMaxLength(500);
            builder.Property(td => td.TagFlags)
                        // Writing, Reading
                    .HasConversion(tf => tf, tf => (DocumentTagTypes)tf);

        }
    }
}