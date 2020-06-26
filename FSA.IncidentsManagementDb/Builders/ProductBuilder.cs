using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{
    internal class ProductBuilder : AuditInfoBuilderConfiguration<ProductDb>
    {

        public override void Configure(EntityTypeBuilder<ProductDb> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).IsRequired();
        }
    }
}