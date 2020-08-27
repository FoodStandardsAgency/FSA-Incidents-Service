using FSA.SIMSManagerDb.Entities.Helpers;
using FSA.SIMSManagerDb.Entities.Lookups;

namespace FSA.SIMSManagerDb.Entities.Core
{
    internal class BaseProductPackSizeDb<ProductDb> : BaseEntityDb
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public int UnitId { get; set; }
        public UnitQuantityDb Unit { get; set; }
        public int ProductId { get; set; }
        public ProductDb Product {get;set;}
}
}
 