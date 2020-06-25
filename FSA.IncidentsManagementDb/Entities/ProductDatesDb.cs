using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class ProductDateDb : BaseEntityDb
    {
        public int Id { get; set; }
        public int DateTypeId { get; set; }
        public DateTypeDb DateType { get; set; }
        public DateTime Date { get; set; }
    }
}

