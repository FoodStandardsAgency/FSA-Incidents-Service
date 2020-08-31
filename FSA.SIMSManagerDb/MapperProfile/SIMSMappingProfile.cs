using AutoMapper;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Entities;
using FSA.SIMSManagerDb.Entities.Core;
using FSA.SIMSManagerDb.Entities.Lookups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FSA.SIMSManagerDb.MapperProfile
{
    public class SIMSMappingProfile : Profile
    {
        public SIMSMappingProfile()
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
                .ForMember(a => a.addressBlock, m => m.MapFrom(a => $"{(a.Address != null ? a.Address.AddressLine1 : String.Empty)} {(a.Address != null ? a.Address.PostCode : String.Empty)}"));

            CreateMap<IncidentStakeholderDb, SimsStakeholder>()
                .ForMember(a => a.DiscriminatorId, m => m.MapFrom(a => a.StakeholderDiscriminatorId))
                .ForMember(a => a.addressBlock, m => m.MapFrom(a => $"{(a.Address != null ? a.Address.AddressLine1 : String.Empty)} {(a.Address != null ? a.Address.PostCode : String.Empty)}"));

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
                .ForMember(a => a.Status, m => m.MapFrom(a => a.ToLinks.Select(o => o.FromId)
                                                              .Concat(a.FromLinks.Select(o => o.ToId).ToList())));


            CreateMap<SimsSignal, SignalDb>(MemberList.Source);
            CreateMap<SignalDb, SimsSignal>(MemberList.Destination);


        }


    }

    internal static class MappingExtender
    {
        internal static IMappingExpression<T, U> IgnoreAuditData<T, U>(this IMappingExpression<T, U> @this) where U : BaseEntityDb
        {
            return @this.ForMember(a => a.Created, m => m.Ignore())
            .ForMember(a => a.Modified, m => m.Ignore())
            .ForMember(a => a.CreatedBy, m => m.Ignore())
            .ForMember(a => a.ModifiedBy, m => m.Ignore())
            .ForMember(a => a.Timestamp, m => m.Ignore());
        }
    }

}
