using FSA.SIMSManagerDb.Entities.Core;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSA.SIMSManagerDb.Builders
{
    /// <summary>
    /// ALl the lookups must use this to be configured.
    /// You can inherit seperate builders if required.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class BasicLookupsBuilder<T> : AuditInfoBuilderConfiguration<T> where T : BaseEntityDb, IIDbLookup
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Title).IsRequired(true);
        }
    }
}
