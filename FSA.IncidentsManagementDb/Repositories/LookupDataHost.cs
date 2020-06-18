using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Entities;
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
        public IReferenceDataRepo<IncidentStatus> Status=> new ReferenceDataRepo<IncidentStatus, IncidentStatusDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<ContactMethod> ContactMethods => new ReferenceDataRepo<ContactMethod, ContactMethodDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<Country> Countries => new ReferenceDataRepo<Country, CountryDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<DataSource> DataSources => new ReferenceDataRepo<DataSource, DataSourceDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<DeathIllness> DeathIllnesses => new ReferenceDataRepo<DeathIllness, DeathIllnessDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<OMITGroup> OMITGroups => new ReferenceDataRepo<OMITGroup, OMITGroupDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<OrganisationRole> OrganisationsRoles => new ReferenceDataRepo<OrganisationRole, OrganisationRoleDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<PersonaRole> PersonaRole => new ReferenceDataRepo<PersonaRole, PersonaRoleDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<ProductType> ProductTypes => new ReferenceDataRepo<ProductType, ProductTypeDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<SignalStatus> SignalStatus => new ReferenceDataRepo<SignalStatus, SignalStatusDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<UnitQuantity> Units => new ReferenceDataRepo<UnitQuantity, UnitQuantityDb>(ctx, (itm) => itm.ToClient());

        public IReferenceDataRepo<PersonaRole> PersonaRoles => new ReferenceDataRepo<PersonaRole, PersonaRoleDb>(ctx, (itm) => itm.ToClient());
        public IReferenceDataRepo<OrganisationLookup> Organisations => new ReferenceDataRepo<OrganisationLookup, OrganisationLookupDb>(ctx,
                                                                                            customFetch: (ctx) => {
                                                                                                var items = ctx.Organisations.Select(o => new OrganisationLookupDb { Id = o.Id, Title = o.Title }).ToListAsync();
                                                                                                return items;
                                                                                            }, 
                                                                                            toClient: (itm) => itm.ToLookup());
    }
}
