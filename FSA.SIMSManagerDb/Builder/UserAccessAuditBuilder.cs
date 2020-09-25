using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.Builder
{
    internal class UserAccessAuditBuilder : AuditInfoBuilderConfiguration<UserAccessAuditDb>
    {
        public override void Configure(EntityTypeBuilder<UserAccessAuditDb> builder)
        {
            base.Configure(builder);

            builder.Property(a => a.UserId).HasMaxLength(70).IsRequired();
            builder.Property(a => a.Scope).HasMaxLength(70).IsRequired();
        }
    }
}
