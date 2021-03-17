using FSA.SIMSManagerDb.Entities.Core;
using FSA.SIMSManagerDb.Entities.Incident;
using System.Collections.Generic;

namespace FSA.SIMSManagerDb.Entities.Lookups
{
    internal class IncidentCategoryDb : BaseEntityDb, IIDbLookup
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<IncidentCategoryJoinDb> CategoryIncidents { get; set; }
    }
}
