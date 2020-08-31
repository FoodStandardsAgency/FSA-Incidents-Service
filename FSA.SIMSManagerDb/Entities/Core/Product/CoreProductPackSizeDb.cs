using FSA.SIMSManagerDb.Entities.Lookups;

namespace FSA.SIMSManagerDb.Entities.Core.Product
{
    internal class CoreProductPackSizeDb : BaseEntityDb
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public int UnitId { get; set; }
        public UnitQuantityDb Unit { get; set; }
        public int ProductId { get; set; }
    }
}
