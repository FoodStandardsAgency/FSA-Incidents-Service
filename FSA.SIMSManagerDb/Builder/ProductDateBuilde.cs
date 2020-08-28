using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FSA.SIMSManagerDb.Builder
{
    internal class ProductDateBuilder<T> : AuditInfoBuilderConfiguration<BaseProductDateDb<T>> where T : class
    {
        private string hostname;
        private string tableName;

        public ProductDateBuilder(string tableName, string hostname)
        {
            this.hostname = hostname;
            this.tableName = tableName;
        }

        public override void Configure(EntityTypeBuilder<BaseProductDateDb<T>> builder)
        {
            base.Configure(builder);
            builder.ToTable(tableName);
            builder.Property(o => o.ProductId).HasColumnName(hostname);
            builder.Property(p => p.Date).HasConversion(b => b, b => DateTime.SpecifyKind(b, DateTimeKind.Utc));
        }
    }
}
