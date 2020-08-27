using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class Stakeholder
    {
        public int Id { get; set; }
        public int HostId { get; set; }
        public string Name { get; set; }
        public string GovDept { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int DiscriminatorId { get; set; }
        public int? AddressId { get; set; }
    }
}
