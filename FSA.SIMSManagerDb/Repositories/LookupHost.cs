using AutoMapper;
using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Entities.Lookups;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
namespace FSA.SIMSManagerDb.Repositories
{
    /// <summary>
    /// Simple fetcher for all the lookips and basic conversions
    /// GetAll it is exepected for the reciver to cache the results
    /// </summary>
    public class LookupHost : ILookupDataHost
    {
        private SimsDbContext ctx;
        private readonly Mapper mapper;
        public LookupHost(SimsDbContext ctx, Mapper mapper)
        {
            this.ctx = ctx;
            this.mapper = mapper;
        }
        public IReferenceDataRepo<Category> Categories => new ReferenceDataRepo<Category, CategoryDb>(ctx, mapper);
        public IReferenceDataRepo<Classification> Classifications => new ReferenceDataRepo<Classification, ClassificationDb>(ctx, mapper);
        public IReferenceDataRepo<Priority> Priorities => new ReferenceDataRepo<Priority, PriorityDb>(ctx, mapper);
        public IReferenceDataRepo<IncidentStatusLkUp> IncidentStatus => new ReferenceDataRepo<IncidentStatusLkUp, IncidentStatusDb>(ctx, mapper);
        public IReferenceDataRepo<ContactMethod> ContactMethods => new ReferenceDataRepo<ContactMethod, ContactMethodDb>(ctx, mapper);
        public IReferenceDataRepo<Country> Countries => new ReferenceDataRepo<Country, CountryDb>(ctx, mapper);
        public IReferenceDataRepo<DataSource> DataSources => new ReferenceDataRepo<DataSource, DataSourceDb>(ctx, mapper);
        public IReferenceDataRepo<DeathIllness> DeathIllnesses => new ReferenceDataRepo<DeathIllness, DeathIllnessDb>(ctx, mapper);
        public IReferenceDataRepo<ProductType> ProductTypes => new ReferenceDataRepo<ProductType, ProductTypeDb>(ctx, mapper);
        public IReferenceDataRepo<SignalStatus> SignalStatus => new ReferenceDataRepo<SignalStatus, SignalStatusDb>(ctx, mapper);
        public IReferenceDataRepo<UnitQuantity> Units => new ReferenceDataRepo<UnitQuantity, UnitQuantityDb>(ctx, mapper);
        public IReferenceDataRepo<AttachmentTagLkup> AttachmentTags => new ReferenceDataRepo<AttachmentTagLkup, DocumentTagDb>(ctx, mapper);
        public IReferenceDataRepo<FBOType> FBOTypes => new ReferenceDataRepo<FBOType, FBOTypeDb>(ctx, mapper);
        public IReferenceDataRepo<NotifierType> NotifierTypes => new ReferenceDataRepo<NotifierType, NotifierTypeDb>(ctx, mapper);
        public IReferenceDataRepo<AdminLead> AdminLeads => new ReferenceDataRepo<AdminLead, AdminLeadDb>(ctx, mapper);
        public IReferenceDataRepo<ProductDateType> ProductDateTypes => new ReferenceDataRepo<ProductDateType, DateTypeDb>(ctx, mapper);
        public IReferenceDataRepo<StakeholderType> StakeholderTypes => new ReferenceDataRepo<StakeholderType, StakeholderDiscriminatorDb>(ctx, mapper);
        public IReferenceDataRepo<StakeholderIncidentRole> StakeholderIncidentRoles => new ReferenceDataRepo<StakeholderIncidentRole, StakeholderIncidentRoleDb>(ctx, mapper);
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
