using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.ModelValidators
{
    public static class MappingExtensions
    {
        public static BaseIncident ToClient(this IncidentUpdateModel @this)
        {
            return new BaseIncident(
                id: @this.Id,
                incidentTitle: @this.IncidentTitle,
                incidentDescription: @this.IncidentDescription,
                incidentTypeId: @this.IncidentTypeId,
                contactMethodId: @this.ContactMethodId,
                statusId: @this.StatusId,
                signalStatusId: @this.SignalStatusId,
                notifierId: @this.NotifierId,
                priorityId: @this.PriorityId,
                principalFBOId: @this.PrincipalFBOId,
                classificationId: @this.ClassificationId,
                dataSourceId: @this.DataSourceId,
                productTypeId: @this.ProductTypeId,
                leadOfficer: @this.LeadOfficer,
                leadOffice: @this.LeadOffice,
                adminLeadId: @this.AdminLeadId,
                fieldOfficer: @this.FieldOfficer,
                leadLocalAuthorityId: @this.LeadLocalAuthorityId,
                lAAdvised: @this.LAAdvised,
                deathIllnessId: @this.DeathIllnessId,
                mostUniqueId:Guid.Empty,
                incidentClosed: null,
                lastChangedBy: null,
                lastChangedDate: DateTime.Now,
                receivedOn:null,
                incidentCreated: DateTime.Now
                );
        }

        public static BaseIncident ToClient(this IncidentCreateModel @this) => new BaseIncident(
            id: @this.Id,
                mostUniqueId: Guid.Empty,
                incidentTitle: @this.IncidentTitle,
                incidentDescription: @this.IncidentDescription,
                incidentTypeId: @this.IncidentTypeId,
                contactMethodId: @this.ContactMethodId,
                statusId: @this.StatusId,
                signalStatusId: @this.SignalStatusId,
                notifierId: @this.NotifierId,
                priorityId: @this.PriorityId,
                principalFBOId: @this.PrincipalFBOId,
                classificationId: @this.ClassificationId,
                dataSourceId: @this.DataSourceId,
                productTypeId: @this.ProductTypeId,
                leadOfficer: @this.LeadOfficer,
                leadOffice: @this.LeadOffice,
                adminLeadId: @this.AdminLeadId,
                fieldOfficer: @this.FieldOfficer,
                leadLocalAuthorityId: @this.LeadLocalAuthorityId,
                lAAdvised: @this.LAAdvised,
                deathIllnessId: @this.DeathIllnessId,
                receivedOn: @this.ReceivedOn,
                incidentCreated: @this.IncidentCreated,
                incidentClosed:null,
                lastChangedBy:null,
                lastChangedDate:DateTime.Now
            );
    }
}
