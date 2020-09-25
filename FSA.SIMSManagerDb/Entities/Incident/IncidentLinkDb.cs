using FSA.SIMSManagerDb.Entities.Core;

namespace FSA.SIMSManagerDb.Entities
{
    internal class IncidentLinkDb : BaseLinkDb    {
        public IncidentDb From { get; set; }
        public IncidentDb To { get; set; }
    }
}
