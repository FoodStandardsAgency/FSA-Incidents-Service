using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class Product
    {
        public Product()
        {
            PackSizes = new List<ProductPackSize>();
            ProductDates = new List<ProductDate>();
        }

        public int Id { get; set; }
        public int HostId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int ProductTypeId { get; set; }
        public int CountryOfOriginId { get; set; }
        public string Amount { get; set; }
        public int AmountUnitTypeId { get; set; }
        public IEnumerable<ProductPackSize> PackSizes { get; set; }
        public IEnumerable<ProductDate> ProductDates { get; set; }
        //public int QuantityOfUnitsMade { get; set; }

        public string BatchCodes { get; set; }
        public string PackDescription { get; set; }
        public string AdditionalInfo { get; set; }
        
        public DateTime Added { get; set; }
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }

        //public ICollection<BatchCodeDb> BatchCodes { get; set; }
        //public IEnumerable<FBODetails> RelatedFBOs { get; set; }
    }
}
