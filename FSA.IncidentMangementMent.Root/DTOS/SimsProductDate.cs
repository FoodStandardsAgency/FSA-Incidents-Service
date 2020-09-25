using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.DTOS
{
    public class SimsProductDate
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int DateTypeId { get; set; }
        public DateTime Date { get; set; }
        public override string ToString()
        {
            return Date.ToString();
        }
    }
}
