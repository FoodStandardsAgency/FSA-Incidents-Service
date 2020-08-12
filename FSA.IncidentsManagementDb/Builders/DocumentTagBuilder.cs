using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{
    class DocumentTagBuilder : AuditInfoBuilderConfiguration<DocumentTagDb>
    {
        public override void Configure(EntityTypeBuilder<DocumentTagDb> builder)
        {
            base.Configure(builder);
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).ValueGeneratedNever();
        }
    }
}
