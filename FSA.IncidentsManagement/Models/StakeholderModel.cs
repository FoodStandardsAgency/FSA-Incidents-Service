using System;

namespace FSA.IncidentsManagement.Models
{
    [Obsolete]
    public class StakeholderModel
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
        public string AddressTitle { get; set; }
    }
}
