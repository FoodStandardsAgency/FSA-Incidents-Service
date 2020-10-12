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
                .ForMember(a => a.Contacts, a => a.MapFrom(B => string.IsNullOrEmpty(B.MainContact)
                                                                ? new List<SimsAddressContact>()
                                                                : new List<SimsAddressContact>
                                                                { new SimsAddressContact{ AddressId= B.Id, EmailAddress=B.EmailAddress, IsMain = true, Name=B.MainContact, TelephoneNumber = B.TelephoneNumber } }));
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

            CreateMap<SimsAttachmentFileInfo, SimsAttachmentFileInfoViewModel>()
                .ForMember(a => a.Tags, b => b.MapFrom(c => ((SimsDocumentTagTypes)c.Tags).SelectedFlags().Where(o => o > 0).Select(o => o)));
            CreateMap<SimsAttachmentFileInfoViewModel, SimsAttachmentFileInfo>()
                .ForMember(a => a.Tags, b => b.MapFrom(c => c.Tags.Sum()));

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
                fieldOfficer: @this.FieldOfficer,
                leadLocalAuthorityId: @this.LeadLocalAuthorityId == 0 ? new Nullable<int>() : @this.LeadLocalAuthorityId,
                lAAdvised: @this.LAAdvised,
                deathIllnessId: @this.DeathIllnessId == 0 ? null : @this.DeathIllnessId,
                mostUniqueId: Guid.Empty,
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
           deathIllnessId: @this.DeathIllnessId==0? null : @this.DeathIllnessId,
           receivedOn: @this.ReceivedOn,
           incidentCreated: @this.IncidentCreated,
           incidentClosed: null,
           lastChangedBy: null,
           lastChangedDate: DateTime.Now
       );
    }
}
