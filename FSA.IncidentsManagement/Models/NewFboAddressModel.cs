using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    /// <summary>
    /// Used when creating an entirely new adddress assigned to an Fbo
    /// </summary>
    public class FboAddressModel
    {
        public int Id { get; set; }
        //public IEnumerable<int> FboTypes { get; set; }
        public SimsAddress Address {get;set;}
    }
}
