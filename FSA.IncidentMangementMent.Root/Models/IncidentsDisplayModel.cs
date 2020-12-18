using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class IncidentsDisplayModel : BaseIncident
    {
        public IncidentsDisplayModel(int id, Guid mostUniqueId, string incidentTitle, int incidentTypeId, int incidentSourceId, int contactMethodId, int statusId,
                                    int? signalStatusId, int? notifierId, int? principalFBOId, int priorityId, int classificationId, int dataSourceId, string signalUrl,
                                    int productTypeId, string leadOfficer, string leadOffice, int adminLeadId, string fieldOfficer, string oimtGroups, int? leadLocalAuthorityId,
                                    bool lAAdvised, int? deathIllnessId, DateTime? receivedOn, DateTime incidentCreated, DateTime? incidentClosed,
                                    string lastChangedBy, DateTime lastChangedDate, string incidentType, string signalStatus, string incidentStatus, string notifier,
                                    string priority, string classification, string dataSource, string productType, int? onlineFormId, string leadLocalAuthority, string deathIllness, string principalFBO, string fBOEmail, string fBOPhone, string fBOAddressLine1, string fBOAddressLine2, string fBOAddressTown, string fBOAddressPostcode, string adminLead, string incidentSource,  bool sensitiveInfo)
             : base(id, mostUniqueId, incidentTitle, incidentTypeId, incidentSourceId, contactMethodId, statusId, signalStatusId, notifierId, principalFBOId, priorityId, classificationId, dataSourceId, signalUrl, productTypeId, leadOfficer, leadOffice, adminLeadId, fieldOfficer, oimtGroups, onlineFormId, leadLocalAuthorityId, lAAdvised, deathIllnessId, sensitiveInfo, receivedOn, incidentCreated, incidentClosed, lastChangedBy, lastChangedDate)
        {
            IncidentType = incidentType;
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
            IncidentSource = incidentSource;

            FormattedOnlineFormid = this.OnlineFormId.HasValue ? GeneralExtensions.GenerateOnlineId(this.OnlineFormId.Value) : "";
        }

        public string IncidentType { get; }
        public string SignalStatus { get; }
        public string IncidentStatus { get; }
        public string Notifier { get; }

        public string PrincipalFBO { get; }
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
        public string IncidentSource { get; }
        public string FormattedOnlineFormid { get; }
    }
}
