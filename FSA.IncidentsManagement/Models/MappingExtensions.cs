using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public static class MappingExtensions
    {
        public static BaseIncident ToClient(this IncidentUpdateModel @this)
        {
            return new BaseIncident(
                id: @this.Id,
                incidentTitle: @this.IncidentTitle,
                incidentDescription: "", 
                incidentTypeId: @this.IncidentTypeId,
                contactMethodId: @this.ContactMethodId,
                statusId: @this.StatusId,
                signalStatusId: @this.SignalStatusId,
                notifierId: @this.NotifierId == 0 ? new Nullable<int>() : @this.NotifierId,
                priorityId: @this.PriorityId,
                principalFBOId: @this.PrincipalFBOId == 0 ? new Nullable<int>() : @this.PrincipalFBOId,
                classificationId: @this.ClassificationId,
                dataSourceId: @this.DataSourceId,
                productTypeId: @this.ProductTypeId,
                leadOfficer: @this.LeadOfficer,
                leadOffice: @this.LeadOffice,
                adminLeadId: @this.AdminLeadId,
                fieldOfficer: @this.FieldOfficer,
                leadLocalAuthorityId: @this.LeadLocalAuthorityId == 0? new Nullable<int>() : @this.LeadLocalAuthorityId,
                lAAdvised: @this.LAAdvised,
                deathIllnessId: @this.DeathIllnessId,
                mostUniqueId: Guid.Empty,
                incidentClosed: null,
                lastChangedBy: null,
                lastChangedDate: DateTime.Now,
                receivedOn: null,
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
                incidentClosed: null,
                lastChangedBy: null,
                lastChangedDate: DateTime.Now
            );

        public static Product ToClient(this NewProductModel @this) => new Product
        {
            Id = @this.Id,
            IncidentId = @this.IncidentId,
            AdditionalInfo = @this.AdditionalInfo ?? "",
            AmountUnitTypeId = @this.AmountUnitTypeId,
            Amount = @this.Amount,
            BatchCodes = @this.BatchCodes,
            Brand = @this.Brand,
            CountryOfOriginId = @this.CountryOfOriginId,
            DataSourceId = @this.DataSourceId,
            Name = @this.Name,
            PackDescription = @this.PackDescription,
            PackSizes = @this.PackSizes.ToClient().ToList(),
            ProductDates = @this.ProductDates.ToClient().ToList(),
            ProductTypeId = @this.ProductTypeId,
            SignalUrl = @this.SignalUrl
        };

        public static ProductDate ToClient(this ProductDateModel @this) => new ProductDate
        {
            Id = @this.Id ?? 0,
            ProductId = @this.ProductId ?? 0,
            DateTypeId = @this.DateTypeId,
            Date = @this.Date
        };

        public static ProductPackSize ToClient(this ProductPackSizeModel @this) => new ProductPackSize
        {
            Id = @this.Id ?? 0,
            ProductId = @this.ProductId ?? 0,
            Size = @this.Size,
            UnitId = @this.UnitId
        };



        public static IEnumerable<ProductPackSize> ToClient(this IEnumerable<ProductPackSizeModel> @this)
        {
            foreach (var item in @this)
            {
                yield return item.ToClient();
            }
        }

        public static IEnumerable<ProductDate> ToClient(this IEnumerable<ProductDateModel> @this)
        {
            foreach (var item in @this)
            {
                yield return item.ToClient();
            }
        }

    }
}
