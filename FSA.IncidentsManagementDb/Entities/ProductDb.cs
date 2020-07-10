using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class ProductDb : BaseEntityDb
    {
        public int Id { get; set; }
        public int IncidentId { get; set; }
        public IncidentDb Incident {get;set;}
        public string Name { get; set; }
        public string Brand { get; set; }
        public int ProductTypeId { get; set; }
        public ProductTypeDb ProductType { get; set; }
        public int CountryOfOriginId { get; set; }
        public CountryDb CountryOfOrigin { get; set; }
        public string Amount { get; set; }
        public int AmountUnitTypeId { get; set; }
        public UnitQuantityDb AmountUnitType { get; set; }
        public ICollection<ProductPackSizeDb> PackSizes { get; set; }
        public ICollection<ProductDateDb> ProductDates { get; set; }
        //public int QuantityOfUnitsMade { get; set; }

        public string BatchCodes { get; set; }
        public string PackDescription { get; set; }
        public string AdditionalInfo { get; set; }
        //public ICollection<BatchCodeDb> BatchCodes { get; set; }
        public ICollection<ProductFBODb> RelatedFBOs { get; set; }
    }
}
