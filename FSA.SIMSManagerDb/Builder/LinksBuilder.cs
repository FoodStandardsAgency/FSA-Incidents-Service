using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FSA.SIMSManagerDb.Builder
{
    internal class LinksBuilder<T> : AuditInfoBuilderConfiguration<T> where T : BaseLinkDb
    {
        private string tableName;

        public LinksBuilder(string tableName) => this.tableName = tableName;

        public override void Configure(EntityTypeBuilder<T> builder)
        {

            // Required for audit
            base.Configure(builder);
            builder.ToTable(tableName);
            builder.HasKey(o => new { o.FromId, o.ToId });

        }
    }



}
