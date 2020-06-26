using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{
    class FBOTypesBuilder : AuditInfoBuilderConfiguration<FBOTypeDb>
    {
        public override void Configure(EntityTypeBuilder<FBOTypeDb> builder)
        {
            base.Configure(builder);
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).ValueGeneratedNever();
        }
    }
}
