using FSA.SIMSManagerDb.Entities.Core;
using FSA.SIMSManagerDb.Entities.Lookups;

namespace FSA.SIMSManagerDb.Entities
{
    internal class CloseSignalNoIncidentDb : BaseEntityDb
    {
        public int SignalId { get; set; }
        public SignalDb Signal { get; set; }
        public int? TeamIds { get; set; }
        public int? ReasonId { get; set; }
        public CloseSignalReasonDb Reason { get; set; }
        public string UserReason { get; set; }
    }
}
