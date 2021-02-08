using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FSA.IncidentsManagement.Models
{
    public class UpdateSignalPriorityStatusModel
    {
        [Required]
        public List<int> Ids { get; set; }
        [Required]
        public string Priority { get; set; }
    }
}
