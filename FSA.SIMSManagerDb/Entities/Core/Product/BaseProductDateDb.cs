using FSA.SIMSManagerDb.Entities.Lookups;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.Entities.Core
{
    internal abstract class BaseProductDateDb<HostDb> : BaseEntityDb
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public HostDb Product { get; set; }
        public int DateTypeId { get; set; }
        public DateTypeDb DateType { get; set; }
        public DateTime Date { get; set; }
    }
}
