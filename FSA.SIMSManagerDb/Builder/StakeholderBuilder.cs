using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.Builder
{
    internal class StakeholderBuilder<T> : AuditInfoBuilderConfiguration<T>  where T : BaseStakeholderDb
    {
        private string hostcolumnName;

        public StakeholderBuilder(string hostcolumnName) => this.hostcolumnName = hostcolumnName;
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
            builder.Property(o => o.HostId).HasColumnName(hostcolumnName);
        }
    }
}
