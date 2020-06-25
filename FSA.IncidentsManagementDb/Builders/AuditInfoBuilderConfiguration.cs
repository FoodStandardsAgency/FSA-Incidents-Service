using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Builders
{
    internal class AuditInfoBuilderConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntityDb
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(aud => aud.CreatedBy).HasMaxLength(70);
            builder.Property(aud => aud.ModifiedBy).HasMaxLength(70);
            builder.Property(aud => aud.Created).IsRequired()
                                                .HasDefaultValueSql("getutcdate()")
                                                .ValueGeneratedOnAddOrUpdate()
                                                .HasConversion(b => b, b => DateTime.SpecifyKind(b, DateTimeKind.Utc));
            builder.Property(aud => aud.CreatedBy).IsRequired();

            builder.Property(aud => aud.Modified).IsRequired()
                                                 .HasDefaultValueSql("getutcdate()")
                                                 .ValueGeneratedOnAddOrUpdate()
                                                 .HasConversion(b => b, b => DateTime.SpecifyKind(b, DateTimeKind.Utc));
            builder.Property(aud => aud.ModifiedBy).IsRequired();
        }
    }
}
