using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public class ProductDateModel
    {
        public int? Id { get; set; }
        public int? ProductId { get; set; }
        public int DateTypeId { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return Date.ToString();
        }
    }
}
