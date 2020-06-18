using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Entities;
using System.Collections.Generic;

namespace FSA.IncidentsManagementDb
{
    internal static class MappingExtensionsDb
    {
        public static Category ToClient(this CategoryDb @this)
        {
            return new Category
            {
                Id = @this.Id,
                Title = @this.Title
            };
        }

        public static Priority ToClient(this PriorityDb @this) => new Priority
        {
            Id = @this.Id,
            Title = @this.Title
        };

        public static Classification ToClient(this ClassificationDb @this) => new Classification
        {
            Id = @this.Id,
            Title = @this.Title
        };

        public static ContactMethod ToClient(this ContactMethodDb @this) => new ContactMethod
        {
            Id = @this.Id,
            Title = @this.Title
        };

        public static Country ToClient(this CountryDb @this) => new Country
        {
            Id = @this.Id,
            Title = @this.Title,
        };

        public static DataSource ToClient(this DataSourceDb @this) => new DataSource
        {
            Id = @this.Id,
            Title = @this.Title,
        };

        public static DeathIllness ToClient(this DeathIllnessDb @this) => new DeathIllness
        {
            Id = @this.Id,
            Title = @this.Title,
        };

        public static OMITGroup ToClient(this OMITGroupDb @this) => new OMITGroup
        {
            Id = @this.Id,
            Title = @this.Title,
        };

        public static OrganisationRole ToClient(this OrganisationRoleDb @this) => new OrganisationRole
        {
            Id = @this.Id,
            Title = @this.Title,
            CanBeFBO = @this.CanBeFBO,
            CanBeLocalAuthority = @this.CanBeLocalAuthority,
            CanBeNotifier = @this.CanBeNotifier
        };

        public static PersonaRole ToClient(this PersonaRoleDb @this) => new PersonaRole
        {
            Id = @this.Id,
            Title = @this.Title,
            CanBeAdminLead = @this.CanBeAdminLead,
            CanBeIncidentLead = @this.CanBeIncidentLead,
            CanBeFieldOfficer = @this.CanBeFieldOfficer
        };

        public static ProductType ToClient(this ProductTypeDb @this) => new ProductType
        {
            Id = @this.Id,
            Title = @this.Title,
        };

        public static UnitQuantity ToClient(this UnitQuantityDb @this) => new UnitQuantity
        {
            Id = @this.Id,
            Title = @this.Title,
        };

        public static SignalStatus ToClient(this SignalStatusDb @this) => new SignalStatus
        {
            Id = @this.Id,
            Title = @this.Title,
            ParentId = @this.ParentId,
            IsOpen = @this.IsOpen,
            IsUnassigned = @this.IsUnassigned
        };

        public static IncidentStatus ToClient(this IncidentStatusDb @this) => new IncidentStatus { Id = @this.Id, Title = @this.Title };

        public static IEnumerable<Incident> ToClient(this IEnumerable<IncidentDb> @this)
        {
            foreach (var itm in @this)
            {
                yield return itm.ToClient();
            }
        }

        public static Incident ToClient(this IncidentDb @this)
        {
            return new Incident(
                @this.Id,
                incidentTitle: @this.IncidentTitle,
                incidentDescription: @this.IncidentDescription,
                incidentTypeId: @this.IncidentTypeId,
                contactMethodId: @this.ContactMethodId,
                statusId: @this.IncidentStatusId,
                signalStatusId: @this.SignalStatusId,
                notifierId: @this.NotifierId,
                principalFBOId: @this.PrincipalFBOId,
                priorityId: @this.PriorityId,
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
                lastChangedBy: @this.ModifiedBy,
                lastChangedDate: @this.Modified
                );
        }

        public static IncidentsDisplayModel ToClient(this IncidentDb @this, Dictionary<int, OrganisationLookup> allOrgs, OrganisationDb fboOrg)
        {
            return new IncidentsDisplayModel(
                     @this.Id,
                incidentTitle: @this.IncidentTitle,
                incidentDescription: @this.IncidentDescription,
                incidentTypeId: @this.IncidentTypeId,
                contactMethodId: @this.ContactMethodId,
                statusId: @this.IncidentStatusId,
                signalStatusId: @this.SignalStatusId,
                notifierId: @this.NotifierId,
                principalFBOId: @this.PrincipalFBOId,
                priorityId: @this.PriorityId,
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
                lastChangedBy: @this.ModifiedBy,
                lastChangedDate: @this.Modified,
                category: @this.IncidentType.Title,
                signalStatus: @this.SignalStatus?.Title ?? "",
                incidentStatus: @this.IncidentStatus.Title,
                notifier: allOrgs.ContainsKey(@this.NotifierId ?? 0) ? allOrgs[@this.NotifierId ?? 0].Name : "",
                priority: @this.Priority?.Title ?? "",
                classification: @this.Classification?.Title ?? "",
                dataSource: @this.DataSource?.Title ?? "",
                productType: @this.ProductType?.Title ?? "",
                leadLocalAuthority: allOrgs.ContainsKey(@this.LeadLocalAuthorityId ?? 0) ? allOrgs[@this.LeadLocalAuthorityId ?? 0].Name : "",
                deathIllness: @this.DeathIllness?.Title ?? "",
                principalFBO: @this.PrincipalFBO?.Organisation ?? "",
                fBOEmail: @this.PrincipalFBO.EmailAddress,
                fBOPhone: @this.PrincipalFBO.TelephoneNumber,
                fBOAddressLine1: @this.PrincipalFBO.AddressLine1,
                fBOAddressLine2: @this.PrincipalFBO.AddressLine2,
                fBOAddressTown: @this.PrincipalFBO.TownCity,
                fBOAddressPostcode: @this.PrincipalFBO.PostCode
                );
        }

        public static IncidentDb ToDb(this Incident @this)
        {
            return new IncidentDb
            {
                Id = @this.CommonId,
                IncidentTitle = @this.IncidentTitle,
                IncidentDescription = @this.IncidentDescription,
                IncidentTypeId = @this.IncidentTypeId,
                ContactMethodId = @this.ContactMethodId,
                IncidentStatusId = @this.StatusId,
                PriorityId = @this.PriorityId,
                SignalStatusId = @this.SignalStatusId,
                NotifierId = @this.NotifierId,
                PrincipalFBOId = @this.PrincipalFBOId,
                ClassificationId = @this.ClassificationId,
                DataSourceId = @this.DataSourceId,
                ProductTypeId = @this.ProductTypeId,
                LeadOfficer = @this.LeadOfficer,
                AdminLead = @this.AdminLead,
                FieldOfficer = @this.FieldOfficer,
                LeadLocalAuthorityId = @this.LeadLocalAuthorityId,
                LAAdvised = @this.LAAdvised,
                DeathIllnessId = @this.DeathIllnessId,
                ReceivedOn = @this.ReceivedOn,
                IncidentCreated = @this.IncidentCreated,
                IncidentClosed = @this.IncidentClosed,
            };
        }



        public static OrganisationLookup ToLookup(this OrganisationDb @this) => new OrganisationLookup { Id = @this.Id, Name = @this.Organisation };

        public static OrganisationLookup ToLookup(this OrganisationLookupDb @this) => new OrganisationLookup { Id = @this.Id, Name = @this.Organisation };


    }
}
