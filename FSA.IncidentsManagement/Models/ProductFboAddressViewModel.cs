using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public class ProductFboAddressViewModel : SimsAddress
    {
        public int ProductId { get; set; }
        public IEnumerable<FboTypes> FboTypes { get; set; }
        public string MainContact { get; set; }
        public string EmailAddress { get; set; }
    }
}
