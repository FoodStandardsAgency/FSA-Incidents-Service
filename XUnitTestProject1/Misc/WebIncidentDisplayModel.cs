using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSA.UnitTests.Misc
{
    public class WebIncidentDisplayModel
    {
        public string Category { get; set; }
        public string SignalStatus { get; set; }
        public string IncidentStatus { get; set; }
        public string Notifier { get; set; }

        public string PrincipalFBO { get; set; }
        public string FBOEmail { get; set; }
        public string FBOPhone { get; set; }
        public string FBOAddressLine1 { get; set; }
        public string FBOAddressLine2 { get; set; }
        public string FBOAddressTown { get; set; }
        public string FBOAddressPostcode { get; set; }
        public string Priority { get; set; }
        public string Classification { get; set; }
        public string DataSource { get; set; }
        public string ProductType { get; set; }
        public string LeadLocalAuthority { get; set; }
        public string DeathIllness { get; set; }
        public string AdminLead { get; set; }
        public string Id { get; set; }
        public int CommonId { get; set; }

        public Guid MostUniqueId { get; set; }
        public string IncidentTitle { get; set; }
        public string IncidentDescription { get; set; }
        public int IncidentTypeId { get; set; }
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
        public int AdminLeadId { get; set; }
        public string FieldOfficer { get; set; }
        public int? LeadLocalAuthorityId { get; set; }
        public bool LAAdvised { get; set; }
        public int DeathIllnessId { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public DateTime IncidentCreated { get; set; }
        public DateTime? IncidentClosed { get; set; }
        public string LastChangedBy { get; set; }
        public DateTime LastChangedDate { get; set; }
    }
}
