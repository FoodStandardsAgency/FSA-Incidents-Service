using FSA.SIMSManagerDb.Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.Entities
{
    internal class SignalDb : BaseEntityDb, IDbId<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
