using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{
    internal class ProductDatesBuilder : AuditInfoBuilderConfiguration<ProductDateDb>
    {

        public override void Configure(EntityTypeBuilder<ProductDateDb> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Date)
                  .HasConversion(b => b, b => DateTime.SpecifyKind(b, DateTimeKind.Utc));
        }
    }
}