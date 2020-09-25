using FSA.SIMSManagerDb.Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.Entities.Signals
{
    internal class SignalIncidentLinkDb : BaseEntityDb
    {
        public int SignalId { get; set; }
        public SignalDb Signal { get; set; }
        public int IncidentId { get; set; }
        public IncidentDb Incident { get; set; }
    }
}

