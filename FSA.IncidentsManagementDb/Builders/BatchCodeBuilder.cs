﻿using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{

    internal class BatchCodeBuilderConfig : AuditInfoBuilderConfiguration<BatchCodeDb>
    {
        public BatchCodeBuilderConfig()
        {
        }

        public override void Configure(EntityTypeBuilder<BatchCodeDb> builder)
        {
            base.Configure(builder);
            //builder.Property()
        }
    }
}