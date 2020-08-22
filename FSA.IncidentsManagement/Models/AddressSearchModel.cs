using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public enum SearchAddressType
    {
        Unknown = 0,
        FBO = 1,
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

