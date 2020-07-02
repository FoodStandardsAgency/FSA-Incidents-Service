using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class UpdatedIncident
    {
        public UpdatedIncident(int id, string incidentTitle, string incidentDescription, int incidentTypeId, int contactMethodId, int statusId, int? signalStatusId, int? notifierId, int? principalFBOId, int classificationId, int priorityId, int dataSourceId, int productTypeId, string leadOfficer, string leadOffice, int adminLeadId, string fieldOfficer, int leadLocalAuthorityId, bool lAAdvised, int deathIllnessId)
        {
            Id = id;
            IncidentTitle = incidentTitle;
            IncidentDescription = incidentDescription;
            IncidentTypeId = incidentTypeId;
            ContactMethodId = contactMethodId;
            StatusId = statusId;
            SignalStatusId = signalStatusId;
            NotifierId = notifierId;
            PrincipalFBOId = principalFBOId;
            ClassificationId = classificationId;
            PriorityId = priorityId;
            DataSourceId = dataSourceId;
            ProductTypeId = productTypeId;
            LeadOfficer = leadOfficer;
            LeadOffice = leadOffice;
            AdminLeadId = adminLeadId;
            FieldOfficer = fieldOfficer;
            LeadLocalAuthorityId = leadLocalAuthorityId;
            LAAdvised = lAAdvised;
            DeathIllnessId = deathIllnessId;
        }

        public int Id {get;}
        public string IncidentTitle {get;}
        public string IncidentDescription {get;}
        public int IncidentTypeId {get;}
        public int ContactMethodId {get;}
        public int StatusId {get;}   // Not signal status
        public int? SignalStatusId {get;}   // Not signal status
        public int? NotifierId {get;}     // organisations
        public int? PrincipalFBOId {get;} // Organisations
        public int ClassificationId {get;}
        public int PriorityId {get;}
        public int DataSourceId {get;}
        public int ProductTypeId {get;}
        public string LeadOfficer {get;}
        public string LeadOffice {get;}
        public int AdminLeadId {get;}
        public string FieldOfficer {get;}
        public int LeadLocalAuthorityId {get;} // organisations
        public bool LAAdvised {get;}
        public int DeathIllnessId {get;}
    }
}
