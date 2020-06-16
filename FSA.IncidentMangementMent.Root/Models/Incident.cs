using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class Incident
    {
        private int _Id;

        public Incident(int id, string incidentTitle, string incidentDescription, int incidentTypeId, int contactMethodId, int statusId, int? notifierId, int? principalFBOId, int classificationId, int dataSourceId, int productTypeId, int? leadOfficerId, int? adminLeadId, int? fieldOfficerId, int? leadLocalAuthorityId, bool lAAdvised, int deathIllnessId, DateTime? receivedOn, DateTime incidentCreated, DateTime? incidentClosed, int lastChangedById, DateTime lastChangedDate)
        {
            _Id = id;
            IncidentTitle = incidentTitle;
            IncidentDescription = incidentDescription;
            IncidentTypeId = incidentTypeId;
            ContactMethodId = contactMethodId;
            StatusId = statusId;
            NotifierId = notifierId;
            PrincipalFBOId = principalFBOId;
            ClassificationId = classificationId;
            DataSourceId = dataSourceId;
            ProductTypeId = productTypeId;
            LeadOfficerId = leadOfficerId;
            AdminLeadId = adminLeadId;
            FieldOfficerId = fieldOfficerId;
            LeadLocalAuthorityId = leadLocalAuthorityId;
            LAAdvised = lAAdvised;
            DeathIllnessId = deathIllnessId;
            ReceivedOn = receivedOn;
            IncidentCreated = incidentCreated;
            IncidentClosed = incidentClosed;
            LastChangedById = lastChangedById;
            LastChangedDate = lastChangedDate;
        }

        public Incident(string incidentTitle, string incidentDescription, int incidentTypeId, int contactMethodId, int statusId, int? notifierId, int? principalFBOId, int classificationId, int dataSourceId, int productTypeId, int? leadOfficerId, int? adminLeadId, int? fieldOfficerId, int? leadLocalAuthorityId, bool lAAdvised, int deathIllnessId, DateTime? receivedOn, DateTime incidentCreated, DateTime? incidentClosed, int lastChangedById, DateTime lastChangedDate) : this(0, incidentTitle, incidentDescription, incidentTypeId, contactMethodId, statusId, notifierId, principalFBOId, classificationId, dataSourceId, productTypeId, leadOfficerId, adminLeadId, fieldOfficerId, leadLocalAuthorityId, lAAdvised, deathIllnessId, receivedOn, incidentCreated, incidentClosed, lastChangedById, lastChangedDate)
        {

        }

        public string Id=>this.FormatId();
        public int CommonId => this._Id;

        public string IncidentTitle {get;}
        public string IncidentDescription {get;}
        public int IncidentTypeId {get;}
        public int ContactMethodId {get;}
        public int StatusId {get;}
        public int? NotifierId {get;}

        public int? PrincipalFBOId {get;}
        public int ClassificationId {get;}
        public int DataSourceId {get;}
        public int ProductTypeId {get;}
        public int? LeadOfficerId {get;}
        public int? AdminLeadId {get;}
        public int? FieldOfficerId {get;}
        public int? LeadLocalAuthorityId {get;}
        public bool LAAdvised {get;}
        public int DeathIllnessId {get;}
        public DateTime? ReceivedOn {get;}
        public DateTime IncidentCreated {get;}
        public DateTime? IncidentClosed {get;}
        public int LastChangedById {get;}
        public DateTime LastChangedDate {get;}

        private string FormatId()
        {
            var paddedNumber = _Id.ToString("D6");
            return $"I-{paddedNumber.Substring(0, 3)}-{paddedNumber.Substring(3, 3)}";
        }

        //public ICollection<IncidentCommentDb> Comments {get;}

    }
}
