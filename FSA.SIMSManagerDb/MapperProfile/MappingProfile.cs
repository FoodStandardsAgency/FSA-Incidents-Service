using AutoMapper;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Entities.Lookups;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.MapperProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoryDb, Category>();
            CreateMap<ClassificationDb, Classification>();
            CreateMap<PriorityDb, Priority>();
            CreateMap<IncidentStatusDb, IncidentStatusLkUp>();
            CreateMap<ContactMethodDb, ContactMethod>();
            CreateMap<CountryDb, Country>();
            CreateMap<DataSourceDb, DataSource>();
            CreateMap<DeathIllnessDb, DeathIllness>();
            CreateMap<ProductTypeDb, ProductType>();
            CreateMap<SignalStatusDb, SignalStatus>();
            CreateMap<UnitQuantityDb, UnitQuantity>();
            CreateMap<AttachmentTagLkup, DocumentTagDb>();
            CreateMap<FBOType, FBOTypeDb>();
            CreateMap<NotifierTypeDb, NotifierType>();
            CreateMap<AdminLeadDb, AdminLead>();
            CreateMap<ProductDateType, DateTypeDb>();
            CreateMap<StakeholderDiscriminatorDb, StakeholderType>();
            CreateMap<StakeholderIncidentRoleDb, StakeholderIncidentRole>();
        }
    }
}
