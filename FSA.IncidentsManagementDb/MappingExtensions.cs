using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FSA.IncidentsManagementDb
{
    internal static class MappingExtensions
    {
        public static Category ToClient(this CategoryDb @this)
        {
            return new Category
            {
                Id = @this.Id,
                IsIncidentsDefault = @this.IsIncidentsDefault,
                Title = @this.Title
            };
        }

        public static Classification ToClient(this ClassificationDb @this) => new Classification
        {
            Id = @this.Id,
            IsIncidentsDefault = @this.IsIncidentsDefault,
            Title = @this.Title
        };

        public static ContactMethod ToClient(this ContactMethodDb @this) => new ContactMethod
        {
            Id = @this.Id,
            IsIncidentsDefault = @this.IsIncidentsDefault,
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
            IsIncidentsDefault = @this.IsIncidentsDefault
        };

        public static DeathIllness ToClient(this DeathIllnessDb @this) => new DeathIllness
        {
            Id = @this.Id,
            Title = @this.Title,
            IsIncidentsDefault = @this.IsIncidentsDefault
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
            IsIncidentsDefault = @this.IsIncidentsDefault
        };

        public static UnitQuantity ToClient(this UnitQuantityDb @this) => new UnitQuantity
        {
            Id = @this.Id,
            Title = @this.Title,
        };

        public static Status ToClient(this StatusDb @this) => new Status
        {
            Id = @this.Id,
            Title = @this.Title,
            ParentId = @this.ParentId,
            IsIncidentsDefault = @this.IsIncidentsDefault,
            IsOpen = @this.IsOpen,
            IsUnassigned = @this.IsUnassigned
        };

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
                statusId: @this.StatusId,
                notifierId: @this.NotifierId,
                principalFBOId: @this.PrincipalFBOId,
                classificationId: @this.ClassificationId,
                dataSourceId: @this.DataSourceId,
                productTypeId: @this.ProductTypeId,
                leadOfficerId: @this.LeadOfficerId,
                adminLeadId: @this.AdminLeadId,
                fieldOfficerId: @this.FieldOfficerId,
                leadLocalAuthorityId: @this.LeadLocalAuthorityId,
                lAAdvised: @this.LAAdvised,
                deathIllnessId: @this.DeathIllnessId,
                receivedOn: @this.ReceivedOn,
                incidentCreated: @this.IncidentCreated,
                incidentClosed: @this.IncidentClosed,
                lastChangedById: @this.LastChangedById,
                lastChangedDate: @this.LastChangedDate
                );
        }

        public static IncidentDb ToDb(this Incident @this)
        {
            return new IncidentDb
            {
                Id = @this.CommonId,
                IncidentTitle= @this.IncidentTitle,
                IncidentDescription= @this.IncidentDescription,
                IncidentTypeId= @this.IncidentTypeId,
                ContactMethodId= @this.ContactMethodId,
                StatusId= @this.StatusId,
                NotifierId= @this.NotifierId,
                PrincipalFBOId= @this.PrincipalFBOId,
                ClassificationId= @this.ClassificationId,
                DataSourceId= @this.DataSourceId,
                ProductTypeId= @this.ProductTypeId,
                LeadOfficerId= @this.LeadOfficerId,
                AdminLeadId= @this.AdminLeadId,
                FieldOfficerId= @this.FieldOfficerId,
                LeadLocalAuthorityId= @this.LeadLocalAuthorityId,
                LAAdvised= @this.LAAdvised,
                DeathIllnessId= @this.DeathIllnessId,
                ReceivedOn= @this.ReceivedOn,
                IncidentCreated= @this.IncidentCreated,
                IncidentClosed= @this.IncidentClosed,
                LastChangedById= @this.LastChangedById,
                LastChangedDate= @this.LastChangedDate
            };
        }
    }
}
