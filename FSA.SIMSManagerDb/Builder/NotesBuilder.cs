using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities;
using FSA.SIMSManagerDbEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSA.SIMSManagerDb.Builder
{
    internal class NotesBuilder<T> : AuditInfoBuilderConfiguration<T> where T : BaseNoteDb
    {
        private string hostname;
        private string tableName;

        public NotesBuilder(string tableName, string hostname)
        {
            this.hostname = hostname;
            this.tableName = tableName;
        }
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
            builder.ToTable(tableName);
            builder.Property(o => o.HostId).HasColumnName(hostname);
        }
    }
  
}
