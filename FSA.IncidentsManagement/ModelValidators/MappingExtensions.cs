﻿using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.DTOS;
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
                incidentTypeId: @this.IncidentTypeId,
                contactMethodId: @this.ContactMethodId,
                statusId: @this.StatusId,
                signalStatusId: @this.SignalStatusId,
                notifierId: @this.NotifierId == 0 ? new Nullable<int>() : @this.NotifierId,
                priorityId: @this.PriorityId,
                principalFBOId: @this.PrincipalFBOId == 0 ? new Nullable<int>() : @this.PrincipalFBOId,
                classificationId: @this.ClassificationId,
                dataSourceId: @this.DataSourceId,
                signalUrl: @this.SignalUrl,
                productTypeId: @this.ProductTypeId,
                leadOfficer: @this.LeadOfficer,
                leadOffice: @this.LeadOffice,
                adminLeadId: @this.AdminLeadId == 0 ? new Nullable<int>() :@this.AdminLeadId,
                fieldOfficer: @this.FieldOfficer,
                leadLocalAuthorityId: @this.LeadLocalAuthorityId == 0 ? new Nullable<int>() : @this.LeadLocalAuthorityId,
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
                incidentTypeId: @this.IncidentTypeId,
                contactMethodId: @this.ContactMethodId,
                statusId: @this.StatusId,
                signalStatusId: @this.SignalStatusId,
                notifierId: @this.NotifierId.HasValue && @this.NotifierId != 0 ? @this.NotifierId : null, // 0 used as an ordinal due to powerapp limitiaion
                priorityId: @this.PriorityId,
                principalFBOId: @this.PrincipalFBOId.HasValue && @this.PrincipalFBOId != 0 ? @this.PrincipalFBOId : null, // 0 used as an ordinal due to powerapp limitiaion
                classificationId: @this.ClassificationId,
                dataSourceId: @this.DataSourceId,
                signalUrl: @this.SignalUrl,
                productTypeId: @this.ProductTypeId,
                leadOfficer: @this.LeadOfficer,
                leadOffice: @this.LeadOffice,
                adminLeadId: @this.AdminLeadId.HasValue && @this.AdminLeadId.Value != 0 ? @this.AdminLeadId : null, // 0 used as an ordinal due to powerapp limitiaion
                fieldOfficer: @this.FieldOfficer,
                leadLocalAuthorityId: @this.LeadLocalAuthorityId.HasValue && @this.LeadLocalAuthorityId.Value != 0 ? @this.LeadLocalAuthorityId : null, // 0 used as an ordinal due to powerapp limitiaion
                lAAdvised: @this.LAAdvised,
                deathIllnessId: @this.DeathIllnessId,
                receivedOn: @this.ReceivedOn,
                incidentCreated: @this.IncidentCreated,
                incidentClosed: null,
                lastChangedBy: null,
                lastChangedDate: DateTime.Now
            );

        public static Product ToClient(this ProductViewModel @this) => new Product
        {
            Id = @this.Id,
            HostId = @this.HostId,
            AdditionalInfo = @this.AdditionalInfo ?? "",
            AmountUnitTypeId = @this.AmountUnitTypeId,
            Amount = @this.Amount,
            BatchCodes = @this.BatchCodes,
            Brand = @this.Brand,
            CountryOfOriginId = @this.CountryOfOriginId,
            Name = @this.Name,
            PackDescription = @this.PackDescription,
            PackSizes = @this.PackSizes.ToClient().ToList(),
            ProductDates = @this.ProductDates.ToClient().ToList(),
            ProductTypeId = @this.ProductTypeId
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

        public static FboAddress ToClient(this FboAddressModel @this) => new FboAddress
        {
            Id = @this.Address.Id,
            AddressLine1 = @this.Address.AddressLine1,
            AddressLine2 = @this.Address.AddressLine2,
            TownCity = @this.Address.TownCity,
            PostCode = @this.Address.PostCode,
            CountryId = @this.Address.CountryId,
            County = @this.Address.County,
            //MainContact = @this.Address.MainContact,
            TelephoneNumber = @this.Address.TelephoneNumber,
            ContactMethodId = @this.Address.ContactMethodId,
            //OrganisationRoleId = @this.Address.OrganisationRoleId ?? 0,
            Title = @this.Address.Title,

            FboId = @this.Id,
            // FboTypes = (FboTypes)@this.FboTypes.ToList().Sum()
        };

        public static FboAddressWebModel ToWeb(this FboAddress @this) => new FboAddressWebModel
        {
            Address = new Address
            {
                AddressLine1 = @this.AddressLine1,
                AddressLine2 = @this.AddressLine2,
                TownCity = @this.TownCity,
                PostCode = @this.PostCode,
                CountryId = @this.CountryId,
                County = @this.County,
                //MainContact = @this.MainContact,
                TelephoneNumber = @this.TelephoneNumber,
                ContactMethodId = @this.ContactMethodId,
                //OrganisationRoleId = @this.OrganisationRoleId ?? 0,
                Title = @this.Title,
            },
            //  FboTypes = Utilities.SelectedFlags(@this.FboTypes),
            Id = @this.FboId
        };

        public static ProductFboAddressViewModel ToWeb(this ProductFboAddress @this) => new ProductFboAddressViewModel
        {
            Id=@this.Id,
            AddressLine1 = @this.AddressLine1,
            AddressLine2 = @this.AddressLine2,
            TownCity = @this.TownCity,
            PostCode = @this.PostCode,
            CountryId = @this.CountryId,
            County = @this.County,
            MainContact = @this.Contacts.Count()>0?@this.Contacts.First().Name: "",
            TelephoneNumber = @this.TelephoneNumber,
            ContactMethodId = @this.ContactMethodId,
            EmailAddress = @this.Contacts.Count() > 0 ? @this.Contacts.First().EmailAddress : "",
            Title = @this.Title,
            Contacts = new List<AddressContact>(),
            ProductId = @this.ProductId,
            FboTypes = Utilities.SelectedFlags(@this.FboTypes)
        };

        public static IEnumerable<ProductFboAddressViewModel> ToWeb(this IEnumerable<ProductFboAddress> @this)
        {
            foreach (var item in @this)
                yield return item.ToWeb();
        }

        public static IEnumerable<FboAddressWebModel> ToWeb(this IEnumerable<FboAddress> @this)
        {
            foreach (var item in @this)
                yield return item.ToWeb();
        }

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

        public static Stakeholder ToClient(this StakeholderModel @this) => new Stakeholder
        {
            Id = @this.Id,
            HostId = @this.HostId,
            DiscriminatorId = @this.DiscriminatorId,
            Name= @this.Name,
            GovDept = @this.GovDept,
            Role = @this.Role,
            Email = @this.Email,
            Phone = @this.Phone,
            AddressId = @this.AddressId == 0 ? new Nullable<int>() : @this.AddressId
        };

        public static Address ToClient(this SimsAddressViewModel @this) => new Address
        {
            Id = @this.Id,
            Title = @this.Title,
            AddressLine1 = @this.AddressLine1,
            AddressLine2 = @this.AddressLine2,
            TownCity = @this.TownCity,
            County = @this.County,
            PostCode = @this.PostCode,
            CountryId = @this.CountryId,
            ContactMethodId = @this.ContactMethodId,
            //OrganisationRoleId = @this.OrganisationRoleId,
            TelephoneNumber = @this.TelephoneNumber,
            Contacts =  string.IsNullOrEmpty( @this.MainContact) ? new List<AddressContact>() :   new List<AddressContact> { new AddressContact { EmailAddress = @this.EmailAddress ?? "", Name =@this.MainContact, IsMain=true, TelephoneNumber =@this.TelephoneNumber ?? ""} }
        };


        public static SimsAddress ToSimsClient(this SimsAddressViewModel @this) => new SimsAddress
        {
            Id = @this.Id,
            Title = @this.Title,
            AddressLine1 = @this.AddressLine1,
            AddressLine2 = @this.AddressLine2,
            TownCity = @this.TownCity,
            County = @this.County,
            PostCode = @this.PostCode,
            CountryId = @this.CountryId,
            ContactMethodId = @this.ContactMethodId,
            //OrganisationRoleId = @this.OrganisationRoleId,
            TelephoneNumber = @this.TelephoneNumber,
            Contacts = string.IsNullOrEmpty(@this.MainContact) ? new List<SimsAddressContact>() : new List<SimsAddressContact> { new SimsAddressContact { EmailAddress = @this.EmailAddress ?? "", Name = @this.MainContact, IsMain = true, TelephoneNumber = @this.TelephoneNumber ?? "" } }
        };

        public static IEnumerable<SimsAddress> ToSimsClient(this IEnumerable<SimsAddressViewModel> @this)
        {
            foreach (var item in @this)
            {
                yield return item.ToSimsClient();
            }
        }

        public static IEnumerable<Address> ToClient(this IEnumerable<SimsAddressViewModel> @this)
        {
            foreach (var item in @this)
            {
                yield return item.ToClient();
            }
        }

        public static SimsAddressViewModel ToWeb(this Address @this) => new SimsAddressViewModel
        {
            Id = @this.Id,
            Title = @this.Title,
            AddressLine1 = @this.AddressLine1,
            AddressLine2 = @this.AddressLine2,
            TownCity = @this.TownCity,
            County = @this.County,
            PostCode = @this.PostCode,
            CountryId = @this.CountryId,
            ContactMethodId = @this.ContactMethodId,
            //OrganisationRoleId = @this.OrganisationRoleId,
            TelephoneNumber = @this.TelephoneNumber,
            MainContact = @this.Contacts.ToList().Count>0?@this.Contacts.First().Name : "",
            EmailAddress = @this.Contacts.ToList().Count > 0 ? @this.Contacts.First().EmailAddress : ""
        };

        public static IEnumerable<SimsAddressViewModel> ToWeb(this IEnumerable<Address> @this)
        {
            foreach (var item in @this)
            {
                yield return item.ToWeb();
            }
        }



        public static StakeholderModel ToWeb(this Stakeholder @this) => new StakeholderModel
        {
            Id = @this.Id,
            HostId = @this.HostId,
            DiscriminatorId = @this.DiscriminatorId,
            Name= @this.Name,
            GovDept= @this.GovDept,
            Role = @this.Role,
            Email = @this.Email,
            Phone = @this.Phone,
            AddressId = @this.AddressId.HasValue ? @this.AddressId.Value : 0
        };

        public static IEnumerable<StakeholderModel> ToWeb(this IEnumerable<Stakeholder> @this)
        {
            foreach (var item in @this)
            {
                yield return item.ToWeb();
            }
        }

    }
}