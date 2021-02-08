using AutoMapper;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.DTOS.Lookups;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities.Lookups;
using System.Collections.Generic;
using System.Linq;

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

        private ISimsReferenceData<HazardGroup> mCategories => new ReferenceDataRepo<HazardGroup, HazardGroupDb>(ctx, mapper);
        private ISimsReferenceData<Classification> mClassifications => new ReferenceDataRepo<Classification, ClassificationDb>(ctx, mapper);
        private ISimsReferenceData<Priority> mPriorities => new ReferenceDataRepo<Priority, PriorityDb>(ctx, mapper);
        private ISimsReferenceData<IncidentStatusLkUp> IncidentStatus => new ReferenceDataRepo<IncidentStatusLkUp, IncidentStatusDb>(ctx, mapper);
        private ISimsReferenceData<ContactMethod> ContactMethods => new ReferenceDataRepo<ContactMethod, ContactMethodDb>(ctx, mapper);
        private ISimsReferenceData<Country> mCountries => new ReferenceDataRepo<Country, CountryDb>(ctx, mapper);
        private ISimsReferenceData<DataSource> DataSources => new ReferenceDataRepo<DataSource, DataSourceDb>(ctx, mapper);
        private ISimsReferenceData<DeathIllness> DeathIllnesses => new ReferenceDataRepo<DeathIllness, DeathIllnessDb>(ctx, mapper);
        private ISimsReferenceData<ProductType> ProductTypes => new ReferenceDataRepo<ProductType, ProductTypeDb>(ctx, mapper);
        private ISimsReferenceData<SignalStatus> SignalStatus => new ReferenceDataRepo<SignalStatus, SignalStatusDb>(ctx, mapper);
        private ISimsReferenceData<UnitQuantity> Units => new ReferenceDataRepo<UnitQuantity, UnitQuantityDb>(ctx, mapper);
        private ISimsReferenceData<AttachmentTagLkup> AttachmentTags => new ReferenceDataRepo<AttachmentTagLkup, DocumentTagDb>(ctx, mapper);
        private ISimsReferenceData<FBOType> FBOTypes => new ReferenceDataRepo<FBOType, FBOTypeDb>(ctx, mapper);
        private ISimsReferenceData<NotifierType> NotifierTypes => new ReferenceDataRepo<NotifierType, NotifierTypeDb>(ctx, mapper);
        private ISimsReferenceData<IncidentSource> IncidentSources => new ReferenceDataRepo<IncidentSource, IncidentSourceDb>(ctx, mapper);
        private ISimsReferenceData<AdminLead> AdminLeads => new ReferenceDataRepo<AdminLead, AdminLeadDb>(ctx, mapper);
        private ISimsReferenceData<ProductDateType> ProductDateTypes => new ReferenceDataRepo<ProductDateType, DateTypeDb>(ctx, mapper);
        private ISimsReferenceData<StakeholderType> StakeholderTypes => new ReferenceDataRepo<StakeholderType, StakeholderDiscriminatorDb>(ctx, mapper);
        private ISimsReferenceData<CloseSignalTeam> CloseSignalTeams => new ReferenceDataRepo<CloseSignalTeam, CloseSignalTeamDb>(ctx, mapper);
        private ISimsReferenceData<CloseSignalReason> CloseSignalReasons => new ReferenceDataRepo<CloseSignalReason, CloseSignalReasonDb>(ctx, mapper);
        private ISimsReferenceData<NoteTag> NoteTags => new ReferenceDataRepo<NoteTag, NoteTagDb>(ctx, mapper);
        private ISimsReferenceData<StakeholderIncidentRole> StakeholderIncidentRoles => new ReferenceDataRepo<StakeholderIncidentRole, StakeholderIncidentRoleDb>(ctx, mapper);


        public IEnumerable<Country> Countries => this.mCountries.GetAll();

        public LookupsHost GetAll() => new LookupsHost
        {
            Categories = this.mCategories.GetAll(),
            Classifications = this.mClassifications.GetAll(),
            Priorites = this.mPriorities.GetAll(),
            IncidentStatus = this.IncidentStatus.GetAll(),
            ContactMethods = this.ContactMethods.GetAll(),
            Countries = this.mCountries.GetAll(),
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
            StakeholderIncidentRoles = this.StakeholderIncidentRoles.GetAll(),
            CloseSignalTeams = this.CloseSignalTeams.GetAll(),
            CloseSignalReasons = this.CloseSignalReasons.GetAll(),
            IncidentSources = this.IncidentSources.GetAll(),
            NoteTagTypes = this.NoteTags.GetAll()
        };

        public SimsExternalLookups GetExternalLookups() => new SimsExternalLookups
        {
            Countries = this.mCountries.GetAll(),
            ProductTypes = this.ProductTypes.GetAll(),
            FBOTypes = this.FBOTypes.GetAll(),
            Units = this.Units.GetAll(),
            NotifierTypes = this.NotifierTypes.GetAll().Where(a=>a.Id<3).ToList() // Public Individual and local authority are being selected for the onine form.
        };
    }
}
