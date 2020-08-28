using FSA.SIMSManagerDb.Entities.Core;

namespace FSA.SIMSManagerDb.Entities
{
    internal class IncidentProductDb : BaseProductDb<IncidentProductPackSizeDb, IncidentProductDateDb, IncidentProductFboDb, IncidentProductDb>
    {
        public int IncidentId { get; set; }
        public IncidentDb Incident {get;set;}
    }
}
