using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{
    internal class ProductPackSizeBuilder : AuditInfoBuilderConfiguration<ProductPackSizeDb>
    {

        public override void Configure(EntityTypeBuilder<ProductPackSizeDb> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Size)
                  .IsRequired();
        }
    }
}