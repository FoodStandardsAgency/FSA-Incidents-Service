using System;
using System.Collections.Generic;

namespace FSA.IncidentsManagement.Models
{
    public class IncidentCreateModel
    {
        public int Id { get; set; }
        public string IncidentTitle { get; set; }
        public string IncidentDescription { get; set; }
        //public int IncidentTypeId { get; set; }
        public int ContactMethodId { get; set; }
        public int StatusId { get; set; }
        public int? SignalStatusId { get; set; }
        public int? NotifierId { get; set; }        // organisations // 0 for Powerapps is un assigned
        public int? PrincipalFBOId { get; set; }    // Organisations // 0 for Powerapps is un assigned
        public int ClassificationId { get; set; }
        public int PriorityId { get; set; }
        public int DataSourceId { get; set; }
        public string SignalUrl { get; set; }
        public int ProductTypeId { get; set; }
        public string LeadOfficer { get; set; }
        public string LeadOffice { get; set; }
        public int? AdminLeadId { get; set; }       // 0 for Powerapps is un assigned
        public string FieldOfficer { get; set; }
        public int? LeadLocalAuthorityId { get; set; } // organisations // 0 for Powerapps is un assigned
        public bool LAAdvised { get; set; }
        public int? DeathIllnessId { get; set; }
        //public Guid MostUniqueId { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public DateTime IncidentCreated { get; set; }
        public int IncidentSourceId { get; set; }
        public string OIMTGroups { get; set; }
        public bool SensitiveInfo { get; set; }
        public IEnumerable<int> Categories { get; set; }
        //public DateTime? IncidentClosed { get; set; }
        //public string LastChangedBy { get; set; }
        //public DateTime LastChangedDate { get; set; }
    }
}
