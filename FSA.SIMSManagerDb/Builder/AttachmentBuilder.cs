﻿using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSA.SIMSManagerDb.Builder
{
    internal class AttachmentBuilder<T> : AuditInfoBuilderConfiguration<T> where T : BaseAttachmentDb
    {
        private string hostname;
        private string tableName;

        public AttachmentBuilder(string tableName, string hostname)
        {
            this.hostname = hostname;
            this.tableName = tableName;
        }
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
            builder.ToTable(tableName);
            builder.HasKey(p => p.DocUrl);
            builder.Property(o => o.HostId).HasColumnName(hostname);
        }
    }
}
