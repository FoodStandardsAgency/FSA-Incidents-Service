using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public class FboAddressWebModel
    {
        public int Id { get; set; }
        public IEnumerable<FboTypes> FboTypes { get; set; }
        public Address Address { get; set; }
    }
}
