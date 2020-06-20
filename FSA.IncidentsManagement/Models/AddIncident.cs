using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public class LinkIncidents
    {
        public int FromIncidentId { get; set; }
        public int ToIncidentId { get; set; }
        public string Comment{ get; set; }

    }
}
