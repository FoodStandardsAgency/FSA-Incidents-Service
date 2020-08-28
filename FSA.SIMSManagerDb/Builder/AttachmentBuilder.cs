using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSA.SIMSManagerDb.Builder
{
    internal class AttachmentBuilder<T> : AuditInfoBuilderConfiguration<BaseAttachmentDb<T>> where T : BaseEntityDb, IDbId<int>
    {
        private string hostname;
        private string tableName;

        public AttachmentBuilder(string tableName, string hostname)
        {
            this.hostname = hostname;
            this.tableName = tableName;
        }
        public override void Configure(EntityTypeBuilder<BaseAttachmentDb<T>> builder)
        {
            base.Configure(builder);
            builder.ToTable(tableName);
            builder.HasKey(p => p.DocUrl);
            builder.Property(o => o.HostId).HasColumnName(hostname);
        }
    }
}
