using System;

namespace FSA.IncidentsManagement.Root.DTOS
{
    public class SIMSIncident
    {
        public string Id => this.FormatId();
        public int CommonId { get; set; }

        //public Guid MostUniqueId {get;set;}
        public string IncidentTitle { get; set; }
        public int IncidentTypeId { get; set; }
        public int IncidentSourceId { get; set; }
        public int ContactMethodId { get; set; }
        public int StatusId { get; set; }
        public int? SignalStatusId { get; set; }
        public int? NotifierId { get; set; }
        public int? PrincipalFBOId { get; set; }
        public int PriorityId { get; set; }
        public int ClassificationId { get; set; }
        public int DataSourceId { get; set; }
        public string SignalUrl { get; set; }
        public int ProductTypeId { get; set; }
        public string LeadOfficer { get; set; }
        public string LeadOffice { get; set; }
        public bool SensitiveInfo { get; set; }
        public int? OnlineFormId { get; set; }
        public int? AdminLeadId { get; set; }

        public string FieldOfficer { get; set; }
        public string OIMTGroups { get; set; }
        public int? LeadLocalAuthorityId { get; set; }
        public bool LAAdvised { get; set; }
        public int? DeathIllnessId { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public DateTime IncidentCreated { get; set; }
        public DateTime? IncidentClosed { get; set; }
        public string LastChangedBy { get; set; }
        public DateTime LastChangedDate { get; set; }

        private string FormatId()
        {
            return GeneralExtensions.GenerateIncidentId(this.CommonId);
        }
    }
}
