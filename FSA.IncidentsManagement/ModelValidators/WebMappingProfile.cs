using AutoMapper;
using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagement.Root.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FSA.IncidentsManagement.ModelValidators
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            CreateMap<SimsAddressViewModel, SimsAddress>()
                .ForMember(a => a.Contacts, a => a.MapFrom(B => string.IsNullOrEmpty(B.MainContact) && string.IsNullOrEmpty(B.EmailAddress)
                                                                ? new List<SimsAddressContact>()
                                                                : new List<SimsAddressContact>
                                                                { new SimsAddressContact{ AddressId= B.Id, EmailAddress=B.EmailAddress, IsMain = true, Name= string.IsNullOrEmpty(B.MainContact)? "No Contact" : B.MainContact , TelephoneNumber = B.TelephoneNumber } }));
            CreateMap<SimsAddress, SimsAddressViewModel>()
                 .ForMember(o => o.MainContact, a => a.MapFrom(sa => sa.Contacts.Count() > 0 ? sa.Contacts.First().Name : ""))
                 .ForMember(o => o.EmailAddress, a => a.MapFrom(sa => sa.Contacts.Count() > 0 ? sa.Contacts.First().EmailAddress : ""));

            CreateMap<ProductViewModel, SimsProduct>();

            CreateMap<ProductPackSizeModel, SimsProductPackSize>();
            CreateMap<ProductDateModel, SimsProductDate>();

            CreateMap<SimsProductFboAddress, ProductFboAddressViewModel>(MemberList.Destination)
                 .ForMember(o => o.MainContact, a => a.MapFrom(sa => sa.Contacts.Count() > 0 ? sa.Contacts.First().Name : ""))
                 .ForMember(o => o.EmailAddress, a => a.MapFrom(sa => sa.Contacts.Count() > 0 ? sa.Contacts.First().EmailAddress : ""))
                 .ForMember(o => o.FboTypes, a => a.MapFrom(a => Utilities.SelectedFlags(a.FboTypes).Where(o => (int)o > 0)))
                 .ForMember(o => o.Contacts, a => a.Ignore());

            CreateMap<IncidentCreateModel, BaseIncident>()
                   .ConstructUsing(@this => @this.ToAutoMapper());
            CreateMap<IncidentUpdateModel, BaseIncident>()
                   .ConstructUsing(@this => @this.ToAutoMapper());

            CreateMap<IncidentCreateModel, SIMSIncident>()
                .ForMember(a => a.NotifierId, b => b.MapFrom(c => c.NotifierId == 0 ? new Nullable<int>() : c.NotifierId))
                .ForMember(a => a.PrincipalFBOId, b => b.MapFrom(c => c.PrincipalFBOId == 0 ? new Nullable<int>() : c.PrincipalFBOId))
                .ForMember(a => a.AdminLeadId, b => b.MapFrom(c => c.AdminLeadId == 0 ? new Nullable<int>() : c.AdminLeadId))
                .ForMember(a => a.LeadLocalAuthorityId, b => b.MapFrom(c => c.LeadLocalAuthorityId == 0 ? new Nullable<int>() : c.LeadLocalAuthorityId))
                .ForMember(a => a.DeathIllnessId, b => b.MapFrom(c => c.DeathIllnessId == 0 ? new Nullable<int>() : c.DeathIllnessId))
                .ForMember(a => a.SignalStatusId, b => b.MapFrom(c => c.SignalStatusId == 0 ? new Nullable<int>() : c.SignalStatusId));

            CreateMap<IncidentUpdateModel, SIMSIncident>()
                .ForMember(a=>a.CommonId, b=>b.MapFrom(c=>c.Id))
                .ForMember(a => a.NotifierId, b => b.MapFrom(c => c.NotifierId == 0 ? new Nullable<int>() : c.NotifierId))
                .ForMember(a => a.PrincipalFBOId, b => b.MapFrom(c => c.PrincipalFBOId == 0 ? new Nullable<int>() : c.PrincipalFBOId))
                .ForMember(a => a.AdminLeadId, b => b.MapFrom(c => c.AdminLeadId == 0 ? new Nullable<int>() : c.AdminLeadId))
                .ForMember(a => a.LeadLocalAuthorityId, b => b.MapFrom(c => c.LeadLocalAuthorityId == 0 ? new Nullable<int>() : c.LeadLocalAuthorityId))
                .ForMember(a => a.DeathIllnessId, b => b.MapFrom(c => c.DeathIllnessId == 0 ? new Nullable<int>() : c.DeathIllnessId));


            CreateMap<SimsAttachmentFileInfo, SimsAttachmentFileInfoViewModel>()
                .ForMember(a => a.Tags, b => b.MapFrom(c => ((SimsDocumentTagTypes)c.Tags).SelectedFlags().Where(o => o > 0).Select(o => o)));
            CreateMap<SimsAttachmentFileInfoViewModel, SimsAttachmentFileInfo>()
                .ForMember(a => a.Tags, b => b.MapFrom(c => c.Tags.Sum()));

            CreateMap<SimsNote, SimsNoteViewModel>()
                .ForMember(a => a.Tags, b => b.MapFrom(a => (a.Tags).ConvertToFlagArray()));

        }
    }

    public static class MapUsing
    {
        public static BaseIncident ToAutoMapper(this IncidentUpdateModel @this)
        {
            return new BaseIncident(
                id: @this.Id,
                incidentTitle: @this.IncidentTitle,
                incidentTypeId: @this.IncidentTypeId,
                incidentSourceId: @this.IncidentSourceId,
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
                adminLeadId: @this.AdminLeadId == 0 ? new Nullable<int>() : @this.AdminLeadId,
                oimtGroups: @this.OIMTGroups ?? "",
                fieldOfficer: @this.FieldOfficer,
                onlineFormId: @this.OnlineFormId,
                leadLocalAuthorityId: @this.LeadLocalAuthorityId == 0 ? new Nullable<int>() : @this.LeadLocalAuthorityId,
                lAAdvised: @this.LAAdvised,
                deathIllnessId: @this.DeathIllnessId == 0 ? null : @this.DeathIllnessId,
                mostUniqueId: Guid.Empty,
                sensitiveInfo: @this.SensitiveInfo,
                incidentClosed: null,
                lastChangedBy: null,
                lastChangedDate: DateTime.Now,
                receivedOn: @this.ReceivedOn,
                incidentCreated: DateTime.Now
                );
        }

        public static BaseIncident ToAutoMapper(this IncidentCreateModel @this) => new BaseIncident(
            id: @this.Id,
           mostUniqueId: Guid.Empty,
           incidentTitle: @this.IncidentTitle,
           incidentSourceId: @this.IncidentSourceId,
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
           oimtGroups: @this.OIMTGroups ?? "",
           fieldOfficer: @this.FieldOfficer,
           leadLocalAuthorityId: @this.LeadLocalAuthorityId.HasValue && @this.LeadLocalAuthorityId.Value != 0 ? @this.LeadLocalAuthorityId : null, // 0 used as an ordinal due to powerapp limitiaion
           lAAdvised: @this.LAAdvised,
           deathIllnessId: @this.DeathIllnessId == 0 ? null : @this.DeathIllnessId,
           receivedOn: @this.ReceivedOn,
           onlineFormId: null,
           sensitiveInfo: @this.SensitiveInfo,
           incidentCreated: @this.IncidentCreated,
           incidentClosed: null,
           lastChangedBy: null,
           lastChangedDate: DateTime.Now
       );
    }
}
