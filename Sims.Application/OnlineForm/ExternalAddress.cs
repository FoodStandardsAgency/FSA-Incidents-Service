using System;
using System.Collections.Generic;
using System.Text;

namespace Sims.Application.OnlineForm
{
    internal class ExternalAddress
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string TownCity { get; set; }
        public string County { get; set; }
        public int CountryId { get; set; }
    }
}
