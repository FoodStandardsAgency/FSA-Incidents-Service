using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class ProductPackSize
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public int UnitId { get; set; }
        public int ProductId { get; set; }
    }
}
