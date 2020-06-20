using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{
    class IncidentOMITGroupDbBuilder : AuditInfoBuilderConfiguration<IncidentOMITGroupDb>
    {

        public override void Configure(EntityTypeBuilder<IncidentOMITGroupDb> builder)
        {
            base.Configure(builder);
            //builder.HasKey(p => new { p.FromIncidentId, p.ToIncidentId });
        }
    }
}
