using System;
using System.Collections.Generic;
using System.Text;

namespace Sims.Application.OnlineForm
{
    internal class ExternalProduct
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int ProductTypeId { get; set; }
        public int CountryOfOriginId { get; set; }
        public string Amount { get; set; }
        public int AmountUnitTypeId { get; set; }
        //public int QuantityOfUnitsMade { get; set; }
        public ExternalProductDates IncidentProductDates { get; set; }
        public ExternalPackSize IncidentProductPackSizes { get; set; }
        public string[] BatchCodes { get; set; }
        public string PackDescription { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
