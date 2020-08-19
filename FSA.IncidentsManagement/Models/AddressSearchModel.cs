using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public enum SearchAddressType
    {
        FBO = 1,
        Unknown = 0,
        Notifiers = 2,
        LocalAuthority = 3,
        BasicAddress=4

    };

    public class AddressSearchModel
    {
        public string Search { get; set; }
        public SearchAddressType AddressType { get; set; }
    }
}

