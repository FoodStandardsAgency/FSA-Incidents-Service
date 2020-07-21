using EntityFrameworkCore.TemporalTables.Extensions;
using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{
    internal class OrganisationBuilder : AuditInfoBuilderConfiguration<OrganisationDb>
    {
        public override void Configure(EntityTypeBuilder<OrganisationDb> builder)
        {
            base.Configure(builder);

            builder.UseTemporalTable();

        }
    }

}
