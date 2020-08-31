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

        private IReferenceDataRepo<Category> Categories => new ReferenceDataRepo<Category, CategoryDb>(ctx, mapper);
        private IReferenceDataRepo<Classification> Classifications => new ReferenceDataRepo<Classification, ClassificationDb>(ctx, mapper);
        private IReferenceDataRepo<Priority> Priorities => new ReferenceDataRepo<Priority, PriorityDb>(ctx, mapper);
        private IReferenceDataRepo<IncidentStatusLkUp> IncidentStatus => new ReferenceDataRepo<IncidentStatusLkUp, IncidentStatusDb>(ctx, mapper);
        private IReferenceDataRepo<ContactMethod> ContactMethods => new ReferenceDataRepo<ContactMethod, ContactMethodDb>(ctx, mapper);
        private IReferenceDataRepo<Country> Countries => new ReferenceDataRepo<Country, CountryDb>(ctx, mapper);
        private IReferenceDataRepo<DataSource> DataSources => new ReferenceDataRepo<DataSource, DataSourceDb>(ctx, mapper);
        private IReferenceDataRepo<DeathIllness> DeathIllnesses => new ReferenceDataRepo<DeathIllness, DeathIllnessDb>(ctx, mapper);
        private IReferenceDataRepo<ProductType> ProductTypes => new ReferenceDataRepo<ProductType, ProductTypeDb>(ctx, mapper);
        private IReferenceDataRepo<SignalStatus> SignalStatus => new ReferenceDataRepo<SignalStatus, SignalStatusDb>(ctx, mapper);
        private IReferenceDataRepo<UnitQuantity> Units => new ReferenceDataRepo<UnitQuantity, UnitQuantityDb>(ctx, mapper);
        private IReferenceDataRepo<AttachmentTagLkup> AttachmentTags => new ReferenceDataRepo<AttachmentTagLkup, DocumentTagDb>(ctx, mapper);
        private IReferenceDataRepo<FBOType> FBOTypes => new ReferenceDataRepo<FBOType, FBOTypeDb>(ctx, mapper);
        private IReferenceDataRepo<NotifierType> NotifierTypes => new ReferenceDataRepo<NotifierType, NotifierTypeDb>(ctx, mapper);
        private IReferenceDataRepo<AdminLead> AdminLeads => new ReferenceDataRepo<AdminLead, AdminLeadDb>(ctx, mapper);
        private IReferenceDataRepo<ProductDateType> ProductDateTypes => new ReferenceDataRepo<ProductDateType, DateTypeDb>(ctx, mapper);
        private IReferenceDataRepo<StakeholderType> StakeholderTypes => new ReferenceDataRepo<StakeholderType, StakeholderDiscriminatorDb>(ctx, mapper);
        private IReferenceDataRepo<StakeholderIncidentRole> StakeholderIncidentRoles => new ReferenceDataRepo<StakeholderIncidentRole, StakeholderIncidentRoleDb>(ctx, mapper);
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
