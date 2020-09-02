using AutoMapper;
using AutoMapper.EquivalencyExpression;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Entities;
using FSA.SIMSManagerDb.Entities.Core;
using FSA.SIMSManagerDb.Entities.Core.Product;
using FSA.SIMSManagerDb.Entities.Lookups;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FSA.SIMSManagerDb.MapperProfile
{
    public class SimsDbMappingProfile : Profile
    {
        public SimsDbMappingProfile()
        {

            CreateMap<CategoryDb, Category>(MemberList.Destination);
            CreateMap<ClassificationDb, Classification>(MemberList.Destination);
            CreateMap<PriorityDb, Priority>(MemberList.Destination);
            CreateMap<IncidentStatusDb, IncidentStatusLkUp>(MemberList.Destination);
            CreateMap<ContactMethodDb, ContactMethod>(MemberList.Destination);
            CreateMap<CountryDb, Country>(MemberList.Destination);
            CreateMap<DataSourceDb, DataSource>(MemberList.Destination);
            CreateMap<DeathIllnessDb, DeathIllness>(MemberList.Destination);
            CreateMap<ProductTypeDb, ProductType>(MemberList.Destination);
            CreateMap<SignalStatusDb, SignalStatus>(MemberList.Destination);
            CreateMap<UnitQuantityDb, UnitQuantity>(MemberList.Destination);
            CreateMap<AttachmentTagLkup, DocumentTagDb>(MemberList.Destination);
            CreateMap<FBOType, FBOTypeDb>(MemberList.Destination);
            CreateMap<NotifierTypeDb, NotifierType>(MemberList.Destination);
            CreateMap<AdminLeadDb, AdminLead>(MemberList.Destination);
            CreateMap<ProductDateType, DateTypeDb>(MemberList.Destination);
            CreateMap<StakeholderDiscriminatorDb, StakeholderType>(MemberList.Destination);
            CreateMap<StakeholderIncidentRoleDb, StakeholderIncidentRole>(MemberList.Destination);

            CreateMap<IncidentLinkDb, SimsLinkedRecord>()
                    .ForMember(o => o.From, m => m.MapFrom(a => a.FromId))
                    .ForMember(o => o.To, m => m.MapFrom(a => a.ToId));
            CreateMap<SignalLinkDb, SimsLinkedRecord>()
                    .ForMember(o => o.From, m => m.MapFrom(a => a.FromId))
                    .ForMember(o => o.To, m => m.MapFrom(a => a.ToId));

            CreateMap<SignalStakeholderDb, SimsStakeholder>()
                .ForMember(a => a.DiscriminatorId, m => m.MapFrom(a => a.StakeholderDiscriminatorId))
                .ForMember(a => a.AddressTitle, m => m.MapFrom(a => $"{(a.Address != null ? a.Address.AddressLine1 : String.Empty)} {(a.Address != null ? a.Address.PostCode : String.Empty)}"));

            CreateMap<IncidentStakeholderDb, SimsStakeholder>()
                .ForMember(a => a.DiscriminatorId, m => m.MapFrom(a => a.StakeholderDiscriminatorId))
                .ForMember(a => a.AddressTitle, m => m.MapFrom(a => $"{(a.Address != null ? a.Address.AddressLine1 : String.Empty)} {(a.Address != null ? a.Address.PostCode : String.Empty)}"));

            CreateMap<IncidentNoteDb, SimsNote>(MemberList.Destination);

            CreateMap<SignalNoteDb, SimsNote>(MemberList.Destination);

            CreateMap<FSA.IncidentsManagement.Root.DTOS.SimsAddress, AddressDb>(MemberList.Source);
            CreateMap<FSA.IncidentsManagement.Root.DTOS.SimsAddress, AddressDb>(MemberList.Source);
            CreateMap<AddressDb, FSA.IncidentsManagement.Root.DTOS.SimsAddress>(MemberList.Destination);

            CreateMap<FSA.IncidentsManagement.Root.DTOS.SimsAddressContact, AddressContactDb>(MemberList.Source);
            CreateMap<AddressContactDb, IncidentsManagement.Root.DTOS.SimsAddressContact>(MemberList.Destination);

            CreateMap<IncidentStakeholderDb, SimsStakeholder>(MemberList.Destination);

            CreateMap<SignalStakeholderDb, SimsStakeholder>(MemberList.Destination);

            CreateMap<SimsStakeholder, IncidentStakeholderDb>(MemberList.Source)
                .ForMember(a => a.StakeholderDiscriminatorId, m => m.MapFrom(a => a.DiscriminatorId));


            CreateMap<SimsStakeholder, SignalStakeholderDb>(MemberList.Source)
                .ForMember(a => a.StakeholderDiscriminatorId, m => m.MapFrom(a => a.DiscriminatorId));

            CreateMap<IncidentAttachmentDb, SimsAttachmentFileInfo>(MemberList.Destination)
                    .ForMember(a => a.UserId, m => m.MapFrom(o => o.CreatedBy))
                    .ForMember(a => a.Url, m => m.MapFrom(o => o.DocUrl))
                    .ForMember(o => o.FileName, m => m.MapFrom(o => Path.GetFileName(o.DocUrl)));

            CreateMap<SignalAttachmentDb, SimsAttachmentFileInfo>(MemberList.Destination)
                    .ForMember(a => a.UserId, m => m.MapFrom(o => o.CreatedBy))
                    .ForMember(a => a.Url, m => m.MapFrom(o => o.DocUrl))
                    .ForMember(o => o.FileName, m => m.MapFrom(o => Path.GetFileName(o.DocUrl)));

            CreateMap<IncidentDb, IncidentsDisplayModel>(MemberList.Source)
                .ForCtorParam("statusId", o => o.MapFrom(a => a.IncidentStatusId))
                .ForCtorParam("lastChangedBy", o => o.MapFrom(a => a.ModifiedBy))
                .ForCtorParam("lastChangedDate", o => o.MapFrom(a => a.Modified));

            CreateMap<IncidentDb, BaseIncident>(MemberList.Source)
                .ForCtorParam("statusId", o => o.MapFrom(a => a.IncidentStatusId))
                .ForCtorParam("lastChangedBy", o => o.MapFrom(a => a.ModifiedBy))
                .ForCtorParam("lastChangedDate", o => o.MapFrom(a => a.Modified));

            CreateMap<BaseIncident, IncidentDb>(MemberList.Source)
                .IgnoreAuditData()
                .ForMember(a => a.Id, m => m.MapFrom(a => a.CommonId))
                .ForMember(a => a.IncidentStatusId, m => m.MapFrom(a => a.StatusId));

            CreateMap<IncidentDb, IncidentDashboardView>()
                .ForMember(a => a.CommonId, m => m.MapFrom(a => a.Id))
                .ForMember(a => a.Status, m => m.MapFrom(a => a.IncidentStatus.Title))
                .ForMember(a => a.Updated, m => m.MapFrom(a => a.Modified))
                .ForMember(a => a.Links, m => m.MapFrom(a => a.ToLinks.Select(o => o.FromId)
                                                              .Concat(a.FromLinks.Select(o => o.ToId).ToList())));


            CreateMap<IncidentsManagement.Root.DTOS.SimsSignal, SignalDb>(MemberList.Source);
            CreateMap<SignalDb, IncidentsManagement.Root.DTOS.SimsSignal>(MemberList.Destination);

            CreateMap<IncidentProductDb, SimsProduct>(MemberList.Destination)
                .ForMember(a => a.AdditionalInfo, m => m.MapFrom(a => String.IsNullOrEmpty(a.AdditionalInfo) ? "" : a.AdditionalInfo))
                .ForMember(a => a.Added, m => m.MapFrom(a => a.Created))
                .ForMember(a => a.LastUpdated, m => m.MapFrom(a => a.Modified))
                .ForMember(a => a.LastUpdatedBy, m => m.MapFrom(a => a.ModifiedBy));

            CreateMap<SignalProductDb, SimsProduct>(MemberList.Destination)
                .ForMember(a => a.AdditionalInfo, m => m.MapFrom(a => String.IsNullOrEmpty(a.AdditionalInfo) ? "" : a.AdditionalInfo))
                .ForMember(a => a.Added, m => m.MapFrom(a => a.Created))
                .ForMember(a => a.LastUpdated, m => m.MapFrom(a => a.Modified))
                .ForMember(a => a.LastUpdatedBy, m => m.MapFrom(a => a.ModifiedBy));

            CreateMap<SimsProduct, IncidentProductDb>(MemberList.Source)
                .ForMember(a => a.AdditionalInfo, m => m.MapFrom(a => String.IsNullOrEmpty(a.AdditionalInfo) ? "" : a.AdditionalInfo))
                .IgnoreAuditData();

            CreateMap<SimsProduct, SignalProductDb>(MemberList.Source)
                .ForMember(a => a.AdditionalInfo, m => m.MapFrom(a => String.IsNullOrEmpty(a.AdditionalInfo) ? "" : a.AdditionalInfo))
                .IgnoreAuditData();

            CreateMap<SimsProductPackSize, IncidentProductPackSizeDb>(MemberList.Source)
                   .IgnoreAuditData();
            CreateMap<SimsProductPackSize, SignalProductPackSizeDb>(MemberList.Source)
                    .IgnoreAuditData();

            CreateMap<IncidentProductPackSizeDb, SimsProductPackSize>(MemberList.Destination);
            CreateMap<SignalProductPackSizeDb, SimsProductPackSize>(MemberList.Destination);

            CreateMap<SimsProductDate, IncidentProductDateDb>(MemberList.Source)
                .EqualityComparison((dto, o) => dto.Id == o.Id)
                .ForMember(p => p.Created, p => p.UseDestinationValue())
                .ForMember(p => p.CreatedBy, p => p.UseDestinationValue())
                .ForMember(p => p.Modified, p => p.UseDestinationValue())
                .ForMember(p => p.ModifiedBy, p => p.UseDestinationValue());
            //.IgnoreAuditData();
            CreateMap<SimsProductDate, SignalProductDateDb>(MemberList.Source)
                .EqualityComparison((dto, o) => dto.Id == o.Id)
                .ForMember(p => p.Created, p => p.UseDestinationValue())
                .ForMember(p => p.CreatedBy, p => p.UseDestinationValue())
                .ForMember(p => p.Modified, p => p.UseDestinationValue())
                .ForMember(p => p.ModifiedBy, p => p.DoNotAllowNull());

            CreateMap<IncidentProductDateDb, SimsProductDate>(MemberList.Destination);
            CreateMap<SignalProductDateDb, SimsProductDate>(MemberList.Destination);

            CreateMap<IncidentProductDb, SimsProductDisplayModel>(MemberList.Destination)
                .ForMember(a => a.DataSourceId, m => m.Ignore())
                .ForMember(a => a.SignalUrl, m => m.Ignore())
                .ForMember(a => a.LastUpdated, m => m.MapFrom(a => a.Modified))
                .ForMember(a => a.LastUpdatedBy, m => m.MapFrom(a => a.ModifiedBy))
                .ForMember(a => a.Added, m => m.MapFrom(a => a.Created));

            CreateMap<SignalProductDb, SimsProductDisplayModel>(MemberList.Destination)
                .ForMember(a => a.DataSourceId, m => m.Ignore())
                .ForMember(a => a.SignalUrl, m => m.Ignore())
                .ForMember(a => a.LastUpdated, m => m.MapFrom(a => a.Host.Modified))
                .ForMember(a => a.LastUpdatedBy, m => m.MapFrom(a => a.Host.ModifiedBy))
                .ForMember(a => a.Added, m => m.MapFrom(a => a.Created));

            CreateMap<IncidentProductDb, SimsProductDetail>(MemberList.Destination);
            CreateMap<SignalProductDb, SimsProductDetail>(MemberList.Destination);

            CreateMap<IncidentProductDb, SimsProductDashboard>(MemberList.Destination)
                .ForMember(a => a.ProductType, m => m.MapFrom(a => a.ProductType.Title))
                .ForMember(a => a.AddressNames, m => m.MapFrom(a => a.RelatedFBOs != null ? a.RelatedFBOs.Select(p => p.Address.Title).ToList() : new List<string>()));

            CreateMap<SignalProductDb, SimsProductDashboard>(MemberList.Destination)
                .ForMember(a => a.ProductType, m => m.MapFrom(a => a.ProductType.Title))
                .ForMember(a => a.AddressNames, m => m.MapFrom(a => a.RelatedFBOs != null ? a.RelatedFBOs.Select(p => p.Address.Title).ToList() : new List<string>()));

            CreateMap<IncidentProductFboDb, SimsProductFboAddress>(MemberList.Destination)
            .ForMember(a => a.Id, m => m.MapFrom(m => m.AddressId))
                .ForMember(a => a.Title, m => m.MapFrom(m => m.Address.Title))
                .ForMember(a => a.AddressLine1, m => m.MapFrom(m => m.Address.AddressLine1))
                .ForMember(a => a.AddressLine2, m => m.MapFrom(m => m.Address.AddressLine2))
                .ForMember(a => a.PostCode, m => m.MapFrom(m => m.Address.PostCode))
                .ForMember(a => a.County, m => m.MapFrom(m => m.Address.County))
                .ForMember(a => a.CountryId, m => m.MapFrom(m => m.Address.CountryId))
                .ForMember(a => a.CountryId, m => m.MapFrom(m => m.Address.CountryId))
                .ForMember(a => a.TownCity, m => m.MapFrom(m => m.Address.TownCity))
                .ForMember(a => a.TelephoneNumber, m => m.MapFrom(m => m.Address.TelephoneNumber))
                .ForMember(a => a.ContactMethodId, m => m.MapFrom(m => m.Address.ContactMethodId))
                .ForMember(a => a.Contacts, m => m.MapFrom(m=>m.Address.Contacts));

            CreateMap<SignalProductFboDb, SimsProductFboAddress>(MemberList.Destination)
                .ForMember(a => a.Id, m => m.MapFrom(m => m.AddressId))
                .ForMember(a => a.Title, m => m.MapFrom(m => m.Address.Title))
                .ForMember(a => a.AddressLine1, m => m.MapFrom(m => m.Address.AddressLine1))
                .ForMember(a => a.AddressLine2, m => m.MapFrom(m => m.Address.AddressLine2))
                .ForMember(a => a.PostCode, m => m.MapFrom(m => m.Address.PostCode))
                .ForMember(a => a.County, m => m.MapFrom(m => m.Address.County))
                .ForMember(a => a.CountryId, m => m.MapFrom(m => m.Address.CountryId))
                .ForMember(a => a.CountryId, m => m.MapFrom(m => m.Address.CountryId))
                .ForMember(a => a.TownCity, m => m.MapFrom(m => m.Address.TownCity))
                .ForMember(a => a.TelephoneNumber, m => m.MapFrom(m => m.Address.TelephoneNumber))
                .ForMember(a => a.ContactMethodId, m => m.MapFrom(m => m.Address.ContactMethodId))
                .ForMember(a => a.Contacts, m => m.MapFrom(m => m.Address.Contacts));



        }


    }

    internal static class MappingExtender
    {
        internal static IMappingExpression<T, U> IgnoreAuditData<T, U>(this IMappingExpression<T, U> @this) where U : BaseEntityDb
        {
            return @this.ForMember(a => a.Created, m => m.Ignore())
            .ForMember(a => a.Modified, m => m.UseDestinationValue())
            .ForMember(a => a.CreatedBy, m => m.UseDestinationValue())
            .ForMember(a => a.ModifiedBy, m => m.UseDestinationValue())
            .ForMember(a => a.Timestamp, m => m.UseDestinationValue());
        }
    }

}
