using FSA.SIMSManagerDbEntities.Helpers;

namespace FSA.SIMSManagerDb.Entities.Core.Product
{
    internal abstract class CoreProductFboDb : BaseEntityDb
    {
        public int ProductId { get; set; }
        public int AddressId { get; set; }
        public FboTypes FboTypes { get; set; }
        public AddressDb Address { get; set; }
    }
}
