using FSA.SIMSManagerDb.Entities.Core;
using FSA.SIMSManagerDb.Entities.Lookups;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.Entities
{
    internal class CloseSignalNoIncident : BaseEntityDb
    {
        public int SignalId { get; set; }
        public int TeamId { get; set; }
        public CloseSignalTeamDb Team { get; set; }
        public int ReasonId { get; set; }
        public CloseSignalReasonDb Reason { get; set; }
        public string UserReason { get; set; }
    }
}
