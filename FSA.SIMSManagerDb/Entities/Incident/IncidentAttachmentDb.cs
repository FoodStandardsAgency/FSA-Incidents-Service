using FSA.SIMSManagerDb.Entities.Core;

namespace FSA.SIMSManagerDb.Entities
{
    class IncidentAttachmentDb : BaseAttachmentDb
    {
        public IncidentDb Incident { get; set; }
    }
}
