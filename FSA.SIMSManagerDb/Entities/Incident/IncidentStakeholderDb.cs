using FSA.SIMSManagerDb.Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.Entities
{
    internal class IncidentStakeholderDb : BaseStakeholderDb
    {
        public IncidentDb Incident { get; set; }

    }
}
