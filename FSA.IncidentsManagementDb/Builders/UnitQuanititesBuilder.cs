﻿using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{
    internal class UnitQuanititesBuilder : BasicLookupsBuilder<UnitQuantityDb>
    {
        public override void Configure(EntityTypeBuilder<UnitQuantityDb> builder)
        {
            base.Configure(builder);

           
        }
    }
}
