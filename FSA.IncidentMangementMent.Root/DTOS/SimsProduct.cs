using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.DTOS
{
    public class SimsProduct
    {
        public SimsProduct()
        {
            PackSizes = new List<SimsProductPackSize>();
            ProductDates = new List<SimsProductDate>();
        }

        public int Id { get; set; }
        public int HostId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int ProductTypeId { get; set; }
        public int CountryOfOriginId { get; set; }
        public string Amount { get; set; }
        public int AmountUnitTypeId { get; set; }
        public IEnumerable<SimsProductPackSize> PackSizes { get; set; }
        public IEnumerable<SimsProductDate> ProductDates { get; set; }
        //public int QuantityOfUnitsMade { get; set; }

        public string BatchCodes { get; set; }
        public string PackDescription { get; set; }
        public string AdditionalInfo { get; set; }

        public DateTime Added { get; set; }
        public DateTime LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}
