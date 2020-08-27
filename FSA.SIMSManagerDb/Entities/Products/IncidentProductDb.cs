
using FSA.SIMSManagerDb.Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.Entities
{
    internal class IncidentProductDb : BaseProductDb<IncidentProductPackSize, IncidentProductDatesDb, IncidentProductFboDb, IncidentProductDb>
    {
        public int IncidentId { get; set; }
        public IncidentDb Incident {get;set;}
    }
}
