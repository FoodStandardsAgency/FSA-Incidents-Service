using FSA.SIMSManagerDb.Entities.Lookups;
using System;

namespace FSA.SIMSManagerDb.Entities.Core
{
    internal abstract class BaseProductDateDb : BaseEntityDb
    {
        public int Id { get; set; }
        public int ProductId { get; set; }

        public int DateTypeId { get; set; }
        public DateTypeDb DateType { get; set; }
        public DateTime Date { get; set; }
    }
}
