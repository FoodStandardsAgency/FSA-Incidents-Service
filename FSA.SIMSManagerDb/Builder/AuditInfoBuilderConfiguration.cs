using FSA.SIMSManagerDb.Entities.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FSA.SIMSManagerDb.Builders
{
    /// <summary>
    /// configures all the auditing information
    /// Base builder class for all entities.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class AuditInfoBuilderConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntityDb
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(aud => aud.CreatedBy).HasMaxLength(70);
            builder.Property(aud => aud.ModifiedBy).HasMaxLength(70);
            builder.Property(aud => aud.Created).IsRequired()
                                                .HasDefaultValueSql("getutcdate()")
                                                .ValueGeneratedOnAdd()
                                                .HasConversion(b => b, b => DateTime.SpecifyKind(b, DateTimeKind.Utc));
            builder.Property(aud => aud.CreatedBy).IsRequired();

            builder.Property(aud => aud.Modified).IsRequired()
                                                 .HasDefaultValueSql("getutcdate()")
                                                 .ValueGeneratedOnAdd()
                                                 .HasConversion(b => b, b => DateTime.SpecifyKind(b, DateTimeKind.Utc));
            builder.Property(aud => aud.ModifiedBy).IsRequired();
            builder.Property(aud => aud.Timestamp).IsRowVersion();
        }
    }
}
