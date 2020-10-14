using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public class SimsSignalCloseNoIncidentViewModel
    {
        public int SignalId { get; set; }
        // We can have multiple teams, so we use a flags type
        public int TeamId { get; set; }
        public int? ReasonId { get; set; }
        public int StatusCloseId { get; set; }
        public string UserReason { get; set; }
    }

}
