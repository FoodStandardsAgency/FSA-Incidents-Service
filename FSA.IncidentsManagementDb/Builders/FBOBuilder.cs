﻿using EntityFrameworkCore.TemporalTables.Extensions;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{
    internal class FBOBuilder : AuditInfoBuilderConfiguration<FBODb>
    {
        public override void Configure(EntityTypeBuilder<FBODb> builder)
        {
            base.Configure(builder);
            
            builder.UseTemporalTable();
            // This field is a flags binary field so no relationship becaredul.
            builder.Property(o => o.FBOTypeId)
                .HasConversion(o => o, o=>(FboTypes)o);
        }
    }
}
