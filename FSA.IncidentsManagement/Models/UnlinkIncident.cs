using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public class UnlinkIncident
    {
        [Required]
        public int FromIncidentId { get; set; }
        [Required]
        public int ToIncidentId{ get; set; }

    }
}
