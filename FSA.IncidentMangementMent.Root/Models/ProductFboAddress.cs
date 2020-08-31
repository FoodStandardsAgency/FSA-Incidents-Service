
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class ProductFboAddress : Address
    {

        public FboTypes FboTypes { get; set; }
        public int ProductId{get;set;}
    }
}
