using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.DTOS
{
    public class SimsProductDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string PackDescription { get; set; }
        public string BatchCodes { get; set; }
        public int CountryOfOriginId { get; set; }
        public IEnumerable<SimsProductPackSize> PackSizes { get; set; }
        public IEnumerable<SimsProductDate> ProductDates { get; set; }
        public string SignalUrl { get; set; }
        public string Amount { get; set; }
        public string AdditionalInfo { get; set; }
        public int AmountTypeId { get; set; }
    }
}
