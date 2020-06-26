using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{
    class IncidentCommentsBuilder : AuditInfoBuilderConfiguration<IncidentCommentDb>
    {
        public override void Configure(EntityTypeBuilder<IncidentCommentDb> builder)
        {
            base.Configure(builder);
        }
    }
}
