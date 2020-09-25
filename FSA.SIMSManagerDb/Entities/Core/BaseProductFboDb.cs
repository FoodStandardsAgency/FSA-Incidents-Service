using FSA.SIMSManagerDbEntities.Helpers;

namespace FSA.SIMSManagerDb.Entities.Core
{
    internal abstract class BaseProductFboDb : BaseEntityDb
    {
        public int ProductId { get; set; }
        public int AddressId { get; set; }
        public FboTypes FboTypes { get; set; }
        public AddressDb Address { get; set; }
    }
}
