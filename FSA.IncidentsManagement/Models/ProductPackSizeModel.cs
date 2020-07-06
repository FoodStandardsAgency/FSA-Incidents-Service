using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public class ProductPackSizeModel
    {
        public int? Id { get; set; }
        public string Size { get; set; }
        public int UnitId { get; set; }
        public int? ProductId { get; set; }
    }
}
