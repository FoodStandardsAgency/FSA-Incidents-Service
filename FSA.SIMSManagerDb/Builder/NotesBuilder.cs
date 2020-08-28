using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities.Core;
using FSA.SIMSManagerDbEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.Builder
{
    internal class NotesBuilder<T> : AuditInfoBuilderConfiguration<BaseNoteDb<T>> where T : class, IDbId<int>
    {
        private string hostname;
        private string tableName;

        public NotesBuilder(string tableName, string hostname)
        {
            this.hostname = hostname;
            this.tableName = tableName;
        }
        public override void Configure(EntityTypeBuilder<BaseNoteDb<T>> builder)
        {
            base.Configure(builder);
            builder.ToTable(tableName);
            builder.Property(o => o.HostId).HasColumnName(hostname);
        }
    }
}
