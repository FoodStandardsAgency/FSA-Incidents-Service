using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class FboAddress : OrganisationAddress
    {
        public FboTypes FboTypes { get; set; }
        public int FboId{get;set;}
    }
}
