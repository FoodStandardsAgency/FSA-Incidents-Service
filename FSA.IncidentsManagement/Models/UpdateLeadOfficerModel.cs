using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public class UpdateLeadOfficerModel
    {
        [Required]
        public List<int> Ids { get; set; }
        [Required]
        public string Officer { get; set; }
    }
}
