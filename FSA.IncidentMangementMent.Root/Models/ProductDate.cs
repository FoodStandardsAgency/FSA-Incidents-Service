using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class ProductDate
    {
        public int DateTypeId { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return Date.ToString();
        }
    }
}
