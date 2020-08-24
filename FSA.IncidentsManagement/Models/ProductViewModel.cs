using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            this.PackSizes = new List<ProductPackSizeModel>();
            this.ProductDates = new List<ProductDateModel>();
        }

        public int IncidentId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int ProductTypeId { get; set; }
        public int CountryOfOriginId { get; set; }
        public string Amount { get; set; }
        public int AmountUnitTypeId { get; set; }
        public IEnumerable<ProductPackSizeModel> PackSizes { get; set; }
        public IEnumerable<ProductDateModel> ProductDates { get; set; }
        //public int QuantityOfUnitsMade { get; set; }

        public string BatchCodes { get; set; }
        public string PackDescription { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
