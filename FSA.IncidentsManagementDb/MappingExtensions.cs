using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Entities;
using System;
using System.Collections.Generic;
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
            CanBeFBO=@this.CanBeFBO,
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
            IsUnassigned= @this.IsUnassigned
        };
    }
}
