using FSA.IncidentsManagement.Root.DTOS;
using System.Collections.Generic;

namespace FSA.IncidentsManagement.Models
{
    public class ProductFboAddressViewModel : SimsAddress
    {
        public int ProductId { get; set; }
        public IEnumerable<SimsFboTypes> FboTypes { get; set; }
        public string MainContact { get; set; }
        public string EmailAddress { get; set; }
    }
}
