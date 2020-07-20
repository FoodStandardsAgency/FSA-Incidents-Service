using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{
    internal class CountriesLookupBuilder : BasicLookupsBuilder<CountryDb>
    {
        public CountriesLookupBuilder()
        {
        }

        public override void Configure(EntityTypeBuilder<CountryDb> builder)
        {
            base.Configure(builder);
            builder.Property(o => o.KeyField).HasMaxLength(56).IsRequired(true);
            builder.HasIndex(o => o.KeyField);
        }
    }
}
