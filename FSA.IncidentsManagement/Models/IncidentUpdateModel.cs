using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public class IncidentUpdateModel
    {
        public int Id { get; set; }
        public string IncidentTitle { get; set; }
        public string IncidentDescription { get; set; }
        public int IncidentTypeId { get; set; }
        public int ContactMethodId { get; set; }
        public int StatusId { get; set; }   // Not signal status
        public int PriorityId { get; set; }
        public int? SignalStatusId { get; set; }   // Not signal status
        public int? NotifierId { get; set; }     // organisations
        public int? PrincipalFBOId { get; set; } // Organisations
        public int? LeadLocalAuthorityId { get; set; } // organisations
        public int ClassificationId { get; set; }
        public int DataSourceId { get; set; }
        public string SignalUrl { get; set; }
        public int ProductTypeId { get; set; }
        public string LeadOfficer { get; set; }
        public string LeadOffice { get; set; }
        public int? AdminLeadId { get; set; }
        public string FieldOfficer { get; set; }
        public bool LAAdvised { get; set; }
        public int DeathIllnessId { get; set; }
        //public Guid MostUniqueId { get; set; }
        //public DateTime? ReceivedOn { get; set; }
        //public DateTime IncidentCreated { get; set; }
        //public DateTime? IncidentClosed { get; set; }
        //public string LastChangedBy { get; set; }
        //public DateTime LastChangedDate { get; set; }
    }
}
