using AutoMapper;
using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
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
                 .ForMember(o => o.FboTypes, a => a.MapFrom(a => Utilities.SelectedFlags(a.FboTypes).Where(o=>(int)o>0)))
                 .ForMember(o => o.Contacts, a => a.Ignore());

            CreateMap<IncidentUpdateModel, BaseIncident>()
                   .ConstructUsing(@this => @this.ToAutoMapper());




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
                deathIllnessId: @this.DeathIllnessId,
                mostUniqueId: Guid.Empty,
                incidentClosed: null,
                lastChangedBy: null,
                lastChangedDate: DateTime.Now,
                receivedOn: null,
                incidentCreated: DateTime.Now
                );
        }
    }
}
