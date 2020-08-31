using FSA.SIMSManagerDb.Entities.Lookups;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.Entities.Core.Product
{
    internal abstract class CoreProductDateDb : BaseEntityDb
    {
        public int Id { get; set; }
        public int ProductId { get; set; }

        public int DateTypeId { get; set; }
        public DateTypeDb DateType { get; set; }
        public DateTime Date { get; set; }
    }
}
