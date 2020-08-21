using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public class StakeholderModel
    {
        public int Id { get; set; }
        public int IncidentId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string GovDept { get; set; }
        public int DiscriminatorId { get; set; }
        public int? AddressId { get; set; }
    }
}
