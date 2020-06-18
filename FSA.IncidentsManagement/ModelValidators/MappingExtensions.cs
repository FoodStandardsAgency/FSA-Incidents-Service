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
        public static Incident ToClient(this IncidentApiModel @this)
        {
            return new Incident(
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
                adminLead: @this.AdminLead,
                fieldOfficer: @this.FieldOfficer,
                leadLocalAuthorityId: @this.LeadLocalAuthorityId,
                lAAdvised: @this.LAAdvised,
                deathIllnessId: @this.DeathIllnessId,
                receivedOn: @this.ReceivedOn,
                incidentCreated: @this.IncidentCreated,
                incidentClosed: @this.IncidentClosed,
                lastChangedBy: @this.LastChangedBy,
                lastChangedDate: @this.LastChangedDate
                );
        }
    }
}
