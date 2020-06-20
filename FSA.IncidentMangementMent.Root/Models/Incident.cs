using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class Incident
    {
        private readonly int _Id;

        public Incident(int id, string incidentTitle, string incidentDescription, int incidentTypeId, int contactMethodId, int statusId,  int? signalStatusId, int? notifierId, int? principalFBOId, int priorityId, int classificationId, int dataSourceId, int productTypeId, string leadOfficer, string leadOffice, string fieldOfficer, int? leadLocalAuthorityId, bool lAAdvised, int deathIllnessId, DateTime? receivedOn, DateTime incidentCreated, DateTime? incidentClosed, string lastChangedBy, DateTime lastChangedDate)
        {
            _Id = id;
            IncidentTitle = incidentTitle;
            IncidentDescription = incidentDescription;
            IncidentTypeId = incidentTypeId;
            ContactMethodId = contactMethodId;
            SignalStatusId = signalStatusId;
            StatusId = statusId;
            NotifierId = notifierId;
            PrincipalFBOId = principalFBOId;
            PriorityId = priorityId;
            ClassificationId = classificationId;
            DataSourceId = dataSourceId;
            ProductTypeId = productTypeId;
            LeadOfficer = leadOfficer;
            LeadOffice = leadOffice;
            FieldOfficer = fieldOfficer;
            LeadLocalAuthorityId = leadLocalAuthorityId;
            LAAdvised = lAAdvised;
            DeathIllnessId = deathIllnessId;
            ReceivedOn = receivedOn;
            IncidentCreated = incidentCreated;
            IncidentClosed = incidentClosed;
            LastChangedBy = lastChangedBy;
            LastChangedDate = lastChangedDate;
        }

        public Incident(string incidentTitle, string incidentDescription, int incidentTypeId, int contactMethodId, int statusId, int? signalStatusId, int? notifierId, int? principalFBOId, int priority, int classificationId, int dataSourceId, int productTypeId, string leadOfficer, string adminLead, string fieldOfficer, int? leadLocalAuthorityId, bool lAAdvised, int deathIllnessId, DateTime? receivedOn, DateTime incidentCreated, DateTime? incidentClosed, string lastChangedBy, DateTime lastChangedDate) : this(0, incidentTitle, incidentDescription, incidentTypeId, contactMethodId, statusId, signalStatusId, notifierId, principalFBOId, priority, classificationId, dataSourceId, productTypeId, leadOfficer, adminLead, fieldOfficer, leadLocalAuthorityId, lAAdvised, deathIllnessId, receivedOn, incidentCreated, incidentClosed, lastChangedBy, lastChangedDate)
        {

        }

        public string Id=>this.FormatId();
        public int CommonId => this._Id;

        public string IncidentTitle {get;}
        public string IncidentDescription {get;}
        public int IncidentTypeId {get;}
        public int ContactMethodId {get;}
        public int StatusId {get;}
        public int? SignalStatusId { get;}
        public int? NotifierId {get;}

        public int? PrincipalFBOId {get;}
        public int PriorityId { get; }
        public int ClassificationId {get;}
        public int DataSourceId {get;}
        public int ProductTypeId {get;}
        public string LeadOfficer {get;}
        public string LeadOffice {get;}
        public string FieldOfficer {get;}
        public int? LeadLocalAuthorityId {get;}
        public bool LAAdvised {get;}
        public int DeathIllnessId {get;}
        public DateTime? ReceivedOn {get;}
        public DateTime IncidentCreated {get;}
        public DateTime? IncidentClosed {get;}
        public string LastChangedBy {get;}
        public DateTime LastChangedDate {get;}

        private string FormatId()
        {
            return GeneralExtensions.GenerateIncidentId(this._Id);
        }

        //public ICollection<IncidentCommentDb> Comments {get;}

    }
}
