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


            CreateMap<IncidentCreateModel, SIMSIncident>()
                .ForMember(a => a.NotifierId, b => b.MapFrom(c => c.NotifierId == 0 ? new Nullable<int>() : c.NotifierId))
                .ForMember(a => a.PrincipalFBOId, b => b.MapFrom(c => c.PrincipalFBOId == 0 ? new Nullable<int>() : c.PrincipalFBOId))
                .ForMember(a => a.AdminLeadId, b => b.MapFrom(c => c.AdminLeadId == 0 ? new Nullable<int>() : c.AdminLeadId))
                .ForMember(a => a.LeadLocalAuthorityId, b => b.MapFrom(c => c.LeadLocalAuthorityId == 0 ? new Nullable<int>() : c.LeadLocalAuthorityId))
                .ForMember(a => a.DeathIllnessId, b => b.MapFrom(c => c.DeathIllnessId == 0 ? new Nullable<int>() : c.DeathIllnessId))
                .ForMember(a => a.SignalStatusId, b => b.MapFrom(c => c.SignalStatusId == 0 ? new Nullable<int>() : c.SignalStatusId));

            CreateMap<IncidentUpdateModel, SIMSIncident>()
                .ForMember(a => a.CommonId, b => b.MapFrom(c => c.Id))
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

  
}
