using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class IncidentsDisplayModel : Incident
    {
        public IncidentsDisplayModel(int id, string incidentTitle, string incidentDescription, int incidentTypeId, int contactMethodId, int statusId, 
                                    int? signalStatusId, int? notifierId, int? principalFBOId, int priorityId, int classificationId, int dataSourceId, 
                                    int productTypeId, string leadOfficer, string adminLead, string fieldOfficer, int? leadLocalAuthorityId, 
                                    bool lAAdvised, int deathIllnessId, DateTime? receivedOn, DateTime incidentCreated, DateTime? incidentClosed, 
                                    string lastChangedBy, DateTime lastChangedDate, string category, string signalStatus, string incidentStatus, string notifier, string principalFBO, 
                                    string priority, string classification, string datasource, string productType, string leadLocalAuthority, string deathIllness ) 
             : base(id, incidentTitle, incidentDescription, incidentTypeId, contactMethodId, statusId, signalStatusId, notifierId, principalFBOId, priorityId, classificationId, dataSourceId, productTypeId, leadOfficer, adminLead, fieldOfficer, leadLocalAuthorityId, lAAdvised, deathIllnessId, receivedOn, incidentCreated, incidentClosed, lastChangedBy, lastChangedDate)
        {
            Category = category;
            SignalStatus = signalStatus;
            IncidentStatus = incidentStatus;
            Notifier = notifier;
            PrincipalFBO = principalFBO;
            Priority = priority;
            Classification = classification;
            Datasource = datasource;
            ProductType = productType;
            LeadLocalAuthority = leadLocalAuthority;
            DeathIllness = deathIllness;
        }

        public string Category { get;  }
        public string SignalStatus { get;  }
        public string IncidentStatus { get;  }
        public string Notifier { get;  }
        
        public string PrincipalFBO { get;  }

        public string Priority { get; }
        public string Datasource { get; }
        public string Classification { get; }
        public string DataSource { get; }
        public string ProductType { get; }
        public string LeadLocalAuthority { get; }
        public string DeathIllness { get; }

    }
}
