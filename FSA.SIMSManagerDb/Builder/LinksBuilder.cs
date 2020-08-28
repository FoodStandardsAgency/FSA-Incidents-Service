using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSA.SIMSManagerDb.Builder
{
    internal class LinksBuilder<T> : AuditInfoBuilderConfiguration<BaseLinkDb<T>> where T : BaseEntityDb, IDbId<int>
    {
        private string tableName;

        public LinksBuilder(string tableName) => this.tableName = tableName;

        public override void Configure(EntityTypeBuilder<BaseLinkDb<T>> builder)
        {

            // Required for audit
            base.Configure(builder);
            builder.ToTable(tableName);
            builder.HasKey(o => new { o.FromId, o.ToId });

        }
    }



}
