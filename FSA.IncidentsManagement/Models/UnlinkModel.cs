using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public class UnlinkModel
    {
        [Required]
        public int FromId { get; set; }
        [Required]
        public int ToId{ get; set; }
    }
}
