using FSA.SIMSManagerDb.Entities.Helpers;
using FSA.SIMSManagerDb.Entities.Lookups;
using System.Collections.Generic;

namespace FSA.SIMSManagerDb.Entities.Core
{
    internal abstract class BaseProductDb<ProductPackSize, ProductDate, ProductFbo, ProductTypeDb> : BaseEntityDb 
                where ProductPackSize : BaseProductPackSizeDb<ProductTypeDb>
                where ProductDate : BaseProductDateDb<ProductTypeDb>
                where ProductFbo :BaseProductFboDb<ProductTypeDb>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int ProductTypeId { get; set; }
        public ProductTypeDb ProductType { get; set; }
        public int CountryOfOriginId { get; set; }
        public CountryDb CountryOfOrigin { get; set; }
        public string Amount { get; set; }
        public int AmountUnitTypeId { get; set; }
        public UnitQuantityDb AmountUnitType { get; set; }
        public ICollection<ProductPackSize> PackSizes { get; set; }
        public ICollection<ProductDate> ProductDates { get; set; }
        //public int QuantityOfUnitsMade { get; set; }

        public string BatchCodes { get; set; }
        public string PackDescription { get; set; }
        public string AdditionalInfo { get; set; }
        //public ICollection<BatchCodeDb> BatchCodes { get; set; }
        public ICollection<ProductFbo> RelatedFBOs { get; set; }
    }
}
