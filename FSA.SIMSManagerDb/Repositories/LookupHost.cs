using AutoMapper;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities.Lookups;
namespace FSA.SIMSManagerDb.Repositories
{
    /// <summary>
    /// Simple fetcher for all the lookips and basic conversions
    /// GetAll it is exepected for the reciver to cache the results
    /// </summary>
    public class LookupHost : IDbLookups
    {
        private SimsDbContext ctx;
        private readonly IMapper mapper;
        public LookupHost(SimsDbContext ctx, IMapper mapper)
        {
            this.ctx = ctx;
            this.mapper = mapper;
        }

        private ISimsReferenceData<HazardGroup> Categories => new ReferenceDataRepo<HazardGroup, HazardGroupDb>(ctx, mapper);
        private ISimsReferenceData<Classification> Classifications => new ReferenceDataRepo<Classification, ClassificationDb>(ctx, mapper);
        private ISimsReferenceData<Priority> Priorities => new ReferenceDataRepo<Priority, PriorityDb>(ctx, mapper);
        private ISimsReferenceData<IncidentStatusLkUp> IncidentStatus => new ReferenceDataRepo<IncidentStatusLkUp, IncidentStatusDb>(ctx, mapper);
        private ISimsReferenceData<ContactMethod> ContactMethods => new ReferenceDataRepo<ContactMethod, ContactMethodDb>(ctx, mapper);
        private ISimsReferenceData<Country> Countries => new ReferenceDataRepo<Country, CountryDb>(ctx, mapper);
        private ISimsReferenceData<DataSource> DataSources => new ReferenceDataRepo<DataSource, DataSourceDb>(ctx, mapper);
        private ISimsReferenceData<DeathIllness> DeathIllnesses => new ReferenceDataRepo<DeathIllness, DeathIllnessDb>(ctx, mapper);
        private ISimsReferenceData<ProductType> ProductTypes => new ReferenceDataRepo<ProductType, ProductTypeDb>(ctx, mapper);
        private ISimsReferenceData<SignalStatus> SignalStatus => new ReferenceDataRepo<SignalStatus, SignalStatusDb>(ctx, mapper);
        private ISimsReferenceData<UnitQuantity> Units => new ReferenceDataRepo<UnitQuantity, UnitQuantityDb>(ctx, mapper);
        private ISimsReferenceData<AttachmentTagLkup> AttachmentTags => new ReferenceDataRepo<AttachmentTagLkup, DocumentTagDb>(ctx, mapper);
        private ISimsReferenceData<FBOType> FBOTypes => new ReferenceDataRepo<FBOType, FBOTypeDb>(ctx, mapper);
        private ISimsReferenceData<NotifierType> NotifierTypes => new ReferenceDataRepo<NotifierType, NotifierTypeDb>(ctx, mapper);
        private ISimsReferenceData<AdminLead> AdminLeads => new ReferenceDataRepo<AdminLead, AdminLeadDb>(ctx, mapper);
        private ISimsReferenceData<ProductDateType> ProductDateTypes => new ReferenceDataRepo<ProductDateType, DateTypeDb>(ctx, mapper);
        private ISimsReferenceData<StakeholderType> StakeholderTypes => new ReferenceDataRepo<StakeholderType, StakeholderDiscriminatorDb>(ctx, mapper);
        private ISimsReferenceData<StakeholderIncidentRole> StakeholderIncidentRoles => new ReferenceDataRepo<StakeholderIncidentRole, StakeholderIncidentRoleDb>(ctx, mapper);
        public LookupsHost GetAll() => new LookupsHost
        {
            Categories = this.Categories.GetAll(),
            Classifications = this.Classifications.GetAll(),
            Priorites = this.Priorities.GetAll(),
            IncidentStatus = this.IncidentStatus.GetAll(),
            ContactMethods = this.ContactMethods.GetAll(),
            Countries = this.Countries.GetAll(),
            DataSources = this.DataSources.GetAll(),
            DeathIllnesses = this.DeathIllnesses.GetAll(),
            ProductTypes = this.ProductTypes.GetAll(),
            SignalStatus = SignalStatus.GetAll(),
            Units = this.Units.GetAll(),
            AttachmentTags = this.AttachmentTags.GetAll(),
            FBOTypes = this.FBOTypes.GetAll(),
            NotifierTypes = this.NotifierTypes.GetAll(),
            AdminLeads = this.AdminLeads.GetAll(),
            ProductDateTypes = this.ProductDateTypes.GetAll(),
            StakeholderTypes = this.StakeholderTypes.GetAll(),
            StakeholderIncidentRoles = this.StakeholderIncidentRoles.GetAll()
        };
    }
}
