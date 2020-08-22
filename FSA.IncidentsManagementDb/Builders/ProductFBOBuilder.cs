using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{
    internal class ProductFBOBuilder : AuditInfoBuilderConfiguration<ProductFBODb>
    {

        public override void Configure(EntityTypeBuilder<ProductFBODb> builder)
        {
            base.Configure(builder);
            builder.HasKey(o => new { o.ProductId, o.AddressId});

            // This field is a flags binary field so no relationship becaredul.
            builder.Property(o => o.FboTypes)
                .HasConversion(o => o, o => (FboTypes)o);

            builder.HasOne(o => o.Product)
                    .WithMany(p => p.RelatedFBOs)
                    .HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(o => o.Address)
                    .WithMany().OnDelete(DeleteBehavior.NoAction);
                    //.HasForeignKey(o => o.FBOId).OnDelete(DeleteBehavior.NoAction);


        }
    }
}
