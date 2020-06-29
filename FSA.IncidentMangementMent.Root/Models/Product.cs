using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int IncidentId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int ProductTypeId { get; set; }
        public int CountryOfOriginId { get; set; }
        public int Amount { get; set; }
        public int AmountUnitTypeId { get; set; }
        public IEnumerable<ProductPackSize> PackSizes { get; set; }
        public IEnumerable<ProductDate> ProductDates { get; set; }
        //public int QuantityOfUnitsMade { get; set; }

        public string BatchCodes { get; set; }
        public string PackDescription { get; set; }
        public string AdditionalInfo { get; set; }
        //public ICollection<BatchCodeDb> BatchCodes { get; set; }
        public int? DataSourceId { get; set; }

        public string SignalUrl { get; set; }
        //public IEnumerable<FBODetails> RelatedFBOs { get; set; }
    }
}
