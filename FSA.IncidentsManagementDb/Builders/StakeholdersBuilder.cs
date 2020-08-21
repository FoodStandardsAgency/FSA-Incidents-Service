﻿using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{
    internal class StakeholdersBuilder : AuditInfoBuilderConfiguration<StakeholderDb>
    {
        public override void Configure(EntityTypeBuilder<StakeholderDb> builder)
        {
            base.Configure(builder);
            builder.Property(o => o.FirstNameDept).IsRequired().HasMaxLength(200);
            builder.Property(o => o.Surname).HasMaxLength(140);
        }
    }
}
