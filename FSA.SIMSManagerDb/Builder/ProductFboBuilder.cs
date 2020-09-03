using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities.Core.Product;
using FSA.SIMSManagerDbEntities.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSA.SIMSManagerDb.Builder
{
    internal class ProductFboBuilder<T> : AuditInfoBuilderConfiguration<T> where T : CoreProductFboDb
    {
        private string tableName;

        public ProductFboBuilder(string tableName)
        {
            this.tableName = tableName;
        }
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
            builder.ToTable(tableName);
            builder.HasKey(p => new { p.ProductId, p.AddressId });

            // This field is a flags binary field so no relationship becaredul.
            builder.Property(o => o.FboTypes)
                .HasConversion(o => o, o => (FboTypes)o);


            builder.HasOne(o => o.Address)
                    .WithMany().OnDelete(DeleteBehavior.NoAction);
        }
    }

}
