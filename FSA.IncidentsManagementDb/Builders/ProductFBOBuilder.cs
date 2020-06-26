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
            builder.HasKey(o => new { o.ProductId, o.FBOId });
            builder.HasOne(o => o.Product)
                    .WithMany(p => p.RelatedFBOs)
                    .HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(o => o.FBO)
                    .WithMany(o => o.RelatedProducts)
                    .HasForeignKey(o => o.FBOId).OnDelete(DeleteBehavior.NoAction);


        }
    }
}
