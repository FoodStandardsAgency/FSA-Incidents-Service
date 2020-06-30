using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{
    internal class NotifierBuilder : AuditInfoBuilderConfiguration<NotifierDb>
    {
        public override void Configure(EntityTypeBuilder<NotifierDb> builder)
        {
            base.Configure(builder);
            builder.HasKey(p => p.Id);

        }
    }
}
