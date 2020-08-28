using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities;
using FSA.SIMSManagerDb.Entities.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSA.SIMSManagerDb.Builder
{
    internal class FboProductBuilder<T> : AuditInfoBuilderConfiguration<BaseProductFboDb<T>> where T : class, new()
    {
        private string hostname;
        private string tableName;

        public FboProductBuilder(string tableName, string hostname)
        {
            this.hostname = hostname;
            this.tableName = tableName;
        }
        public override void Configure(EntityTypeBuilder<BaseProductFboDb<T>> builder)
        {
            base.Configure(builder);
            builder.ToTable(tableName);
            builder.HasKey(p => new { p.ProductId, p.AddressId });
            builder.Property(o => o.ProductId).HasColumnName(hostname);

            // This field is a flags binary field so no relationship becaredul.
            builder.Property(o => o.FboTypes)
                .HasConversion(o => o, o => (FboTypes)o);


            builder.HasOne(o => o.Address)
                    .WithMany().OnDelete(DeleteBehavior.NoAction);
        }
    }

}
