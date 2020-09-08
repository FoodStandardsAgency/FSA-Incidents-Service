using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSA.SIMSManagerDb.Builder
{
    internal class ProductPackSizeBuilder<T> : AuditInfoBuilderConfiguration<T> where T : BaseProductPackSizeDb
    {
        private string hostname;
        private string tableName;

        public ProductPackSizeBuilder(string tableName, string hostname)
        {
            this.hostname = hostname;
            this.tableName = tableName;
        }

        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
            builder.ToTable(tableName);
            builder.Property(o => o.ProductId).HasColumnName(hostname);

            builder.Property(p => p.Size)
                           .IsRequired();
        }
    }
}
