using FSA.SIMSManagerDb.Entities.Core;
using System;

namespace FSA.SIMSManagerDbEntities
{
    internal abstract class BaseNoteDb<HostDb> : BaseEntityDb where HostDb : class, IDbId<int>
    {
        public int Id{ get; set; }
        public string Note { get; set; }
        public int HostId { get; set; }
        public HostDb Host { get; set; }
    }
}
