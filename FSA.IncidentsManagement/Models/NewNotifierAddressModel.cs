using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public class NewNotifierAddressModel
    {
        public NotifierTypes Notifier { get; set; }
        public OrganisationAddress Address { get; set; }
    }
}
