using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Entities;
using FSA.IncidentsManagementDb.Repositories.ScratchRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FSA.IncidentsManagementDb.Repositories
{
    // Simple fetcher for all the lookips and basic conversions
    // It's noisy.. but readable...just about.
    public class LookupDataHost : ILookupDataHost
    {
        private readonly FSADbContext ctx;

        public LookupDataHost(FSADbContext ctx)
        {
            this.ctx = ctx;
        }

        public IReferenceDataRepo<Category> Categories => new ReferenceDataRepo<Category, CategoryDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<Classification> Classifications => new ReferenceDataRepo<Classification, ClassificationDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<Priority> Priorities => new ReferenceDataRepo<Priority, PriorityDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<IncidentStatusLkUp> Status => new ReferenceDataRepo<IncidentStatusLkUp, IncidentStatusDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<ContactMethod> ContactMethods => new ReferenceDataRepo<ContactMethod, ContactMethodDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<Country> Countries => new ReferenceDataRepo<Country, CountryDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<DataSource> DataSources => new ReferenceDataRepo<DataSource, DataSourceDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<DeathIllness> DeathIllnesses => new ReferenceDataRepo<DeathIllness, DeathIllnessDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<OMITGroup> OMITGroups => new ReferenceDataRepo<OMITGroup, OMITGroupDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<OrganisationRole> OrganisationsRoles => new ReferenceDataRepo<OrganisationRole, OrganisationRoleDb>(ctx, (itm) => itm.ToClient());

        public IReferenceDataRepo<ProductType> ProductTypes => new ReferenceDataRepo<ProductType, ProductTypeDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<SignalStatus> SignalStatus => new ReferenceDataRepo<SignalStatus, SignalStatusDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<UnitQuantity> Units => new ReferenceDataRepo<UnitQuantity, UnitQuantityDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<AttachmentTagLkup> AttachmentTags => new ReferenceDataRepo<AttachmentTagLkup, DocumentTagDb>(ctx, (itm) => itm.ToClient());

        public IReferenceDataRepo<PersonaRole> PersonaRoles => new ReferenceDataRepo<PersonaRole, PersonaRoleDb>(ctx, (itm) => itm.ToClient());
        // These are here temporairly
        public IReferenceDataRepo<OrganisationLookup> Organisations => new OrganisationLookupManager(ctx);
        public IReferenceDataRepo<OrganisationLookup> FBOs => new FBOLookups(ctx);
        public IReferenceDataRepo<OrganisationLookup> Notifiers => new NotifiersLookups(ctx);
        public IReferenceDataRepo<OrganisationLookup> LocalAuthorities => new LocalAuthoritiesLookups(ctx);
        // These are here temporairly

        public IReferenceDataRepo<FBOType> FBOTypes => new ReferenceDataRepo<FBOType, FBOTypeDb> (ctx, (itm)=>itm.ToClient());
        public IReferenceDataRepo<NotifierType> NotifierTypes => new ReferenceDataRepo<NotifierType, NotifierTypeDb> (ctx, (itm)=>itm.ToClient());
        public IReferenceDataRepo<AdminLead> AdminLeads => new ReferenceDataRepo<AdminLead, AdminLeadDb> (ctx, (itm)=>itm.ToClient());
        public IReferenceDataRepo<ProductDateType> ProductDateTypes => new ReferenceDataRepo<ProductDateType, DateTypeDb>(ctx, (itm) => itm.ToClient());
    }
}
