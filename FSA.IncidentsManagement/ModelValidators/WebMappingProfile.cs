using AutoMapper;
using FSA.IncidentsManagement.Misc;
using FSA.IncidentsManagement.Models;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
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


        }
    }
}
