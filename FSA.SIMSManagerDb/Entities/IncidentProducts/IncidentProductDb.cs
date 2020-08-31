using FSA.SIMSManagerDb.Entities.Core.Product;
using System.Collections.Generic;

namespace FSA.SIMSManagerDb.Entities
{
    internal class IncidentProductDb : CoreProductDb, ICoreProduct<IncidentProductFboDb, IncidentProductPackSizeDb, IncidentProductDateDb>
    {
        public IncidentDb Host {get;set;}
        public ICollection<IncidentProductFboDb> RelatedFBOs { get; set; }
        public ICollection<IncidentProductPackSizeDb> PackSizes { get; set; }
        public ICollection<IncidentProductDateDb> ProductDates { get; set; }
    }
}
