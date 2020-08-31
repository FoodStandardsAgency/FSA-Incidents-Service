using FSA.SIMSManagerDb.Entities.Lookups;
using System.Collections.Generic;

namespace FSA.SIMSManagerDb.Entities.Core.Product
{
    internal abstract class CoreProductDb : BaseEntityDb
    {
        public int Id { get; set; }
        public int HostId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int ProductTypeId { get; set; }
        public ProductTypeDb ProductType { get; set; }
        public int CountryOfOriginId { get; set; }
        public CountryDb CountryOfOrigin { get; set; }
        public string Amount { get; set; }
        public int AmountUnitTypeId { get; set; }
        public UnitQuantityDb AmountUnitType { get; set; }
        //public int QuantityOfUnitsMade { get; set; }

        public string BatchCodes { get; set; }
        public string PackDescription { get; set; }
        public string AdditionalInfo { get; set; }

        //public ICollection<BatchCodeDb> BatchCodes { get; set; }
        //public ICollection<ProductFbo> RelatedFBOs { get; set; }
        //public ICollection<ProductPackSize> PackSizes { get; set; }
        //public ICollection<ProductDate> ProductDates { get; set; }
    }
}
