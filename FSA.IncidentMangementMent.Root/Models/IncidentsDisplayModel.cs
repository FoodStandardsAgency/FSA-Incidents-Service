using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class IncidentsDisplayModel : BaseIncident
    {
        public IncidentsDisplayModel(int id, Guid mostUniqueId, string incidentTitle, string incidentDescription, int incidentTypeId, int contactMethodId, int statusId, 
                                    int? signalStatusId, int? notifierId, int? principalFBOId, int priorityId, int classificationId, int dataSourceId, 
                                    int productTypeId, string leadOfficer, string leadOffice, int adminLeadId, string fieldOfficer, int? leadLocalAuthorityId, 
                                    bool lAAdvised, int deathIllnessId, DateTime? receivedOn, DateTime incidentCreated, DateTime? incidentClosed, 
                                    string lastChangedBy, DateTime lastChangedDate, string category, string signalStatus, string incidentStatus, string notifier, 
                                    string priority, string classification, string dataSource, string productType, string leadLocalAuthority, string deathIllness, string principalFBO, string fBOEmail, string fBOPhone, string fBOAddressLine1, string fBOAddressLine2, string fBOAddressTown, string fBOAddressPostcode, string adminLead) 
             : base(id, mostUniqueId, incidentTitle, incidentDescription, incidentTypeId, contactMethodId, statusId, signalStatusId, notifierId, principalFBOId, priorityId, classificationId, dataSourceId, productTypeId, leadOfficer, leadOffice, adminLeadId, fieldOfficer, leadLocalAuthorityId, lAAdvised, deathIllnessId, receivedOn, incidentCreated, incidentClosed, lastChangedBy, lastChangedDate)
        {
            Category = category;
            SignalStatus = signalStatus;
            IncidentStatus = incidentStatus;
            Notifier = notifier;
            PrincipalFBO = principalFBO;
            FBOEmail = fBOEmail;
            FBOPhone = fBOPhone;
            FBOAddressLine1 = fBOAddressLine1;
            FBOAddressLine2 = fBOAddressLine2;
            FBOAddressTown = fBOAddressTown;
            FBOAddressPostcode = fBOAddressPostcode;
            Priority = priority;
            Classification = classification;
            DataSource = dataSource;
            ProductType = productType;
            LeadLocalAuthority = leadLocalAuthority;
            DeathIllness = deathIllness;
            AdminLead = adminLead;
        }

        public string Category { get;  }
        public string SignalStatus { get;  }
        public string IncidentStatus { get;  }
        public string Notifier { get;  }
        
        public string PrincipalFBO { get;  }
        public string FBOEmail { get; }
        public string FBOPhone { get; }
        public string FBOAddressLine1 { get; }
        public string FBOAddressLine2 { get; }
        public string FBOAddressTown { get; }
        public string FBOAddressPostcode { get; }
        public string Priority { get; }
        public string Classification { get; }
        public string DataSource { get; }
        public string ProductType { get; }
        public string LeadLocalAuthority { get; }
        public string DeathIllness { get; }
        public string AdminLead { get; }
    }
}
