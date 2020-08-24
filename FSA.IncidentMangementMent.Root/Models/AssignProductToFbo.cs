using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class ProductAddress
    {
        public int Id { get; set; }
        public int[] FboTypes { get; set; }
        public int FboId { get; set; }
    }
}
