using FSA.SIMSManagerDb.Entities.Core;
using System;

namespace FSA.SIMSManagerDbEntities
{
    internal abstract class BaseNoteDb : BaseEntityDb
    {
        public int Id{ get; set; }
        public string Note { get; set; }
        public int HostId { get; set; }
    }
}
