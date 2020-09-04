using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
