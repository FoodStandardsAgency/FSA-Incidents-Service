using FSA.SIMSManagerDbEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.Entities
{
    internal class SignalNoteDb : BaseNoteDb
    {
        public SignalDb Signal { get; set; }
    }
}
