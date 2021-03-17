using FSA.SIMSManagerDb.Entities.Core;
using FSA.SIMSManagerDb.Entities.Lookups;

namespace FSA.SIMSManagerDb.Entities.Incident
{
    internal class IncidentCategoryJoinDb : BaseEntityDb
    {
        public int IncidentId { get; set; }
        public IncidentDb Incident { get; set; }
        public int IncidentCategoryId { get; set; }
        public IncidentCategoryDb IncidentCategory { get; set; }
    }
}
