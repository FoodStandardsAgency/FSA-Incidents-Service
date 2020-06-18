using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Builders;
using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;

namespace FSA.IncidentsManagementDb
{
    public class FSADbContext : DbContext
    {
        public FSADbContext(DbContextOptions options) : base(options)
        {
        }

        //[Obsolete]
        //internal DbSet<GatewayErrorCodeDb> GatewayErrorCodes { get; set; }
        //[Obsolete]
        //internal DbSet<GatewayRequestDetailDb> GatewayRequestDetails { get; set; }
        //[Obsolete]
        //internal DbSet<GatewayUserIncidentDb> GatewayUserIncidents { get; set; }
        //[Obsolete]

        //internal DbSet<UserDb> Users { get; set; }
        ////[Obsolete]
        //internal DbSet<UserRoleDb> UserRoles { get; set; }

        internal DbSet<IncidentCommentDb> IncidentComments { get; set; }
        internal DbSet<IncidentDb> Incidents { get; set; }
        internal DbSet<IncidentLinkDb> IncidentLinks { get; set; }
        internal DbSet<IncidentOMITGroupDb> IncidentOMITGroups { get; set; }
        internal DbSet<OrganisationDb> Organisations { get; set; }
        internal DbSet<CategoryDb> Categories { get; set; }
        internal DbSet<ClassificationDb> Classifications { get; set; }
        internal DbSet<PriorityDb> Priorities { get; set; }
        internal DbSet<ContactMethodDb> ContactMethods { get; set; }
        internal DbSet<CountryDb> Countries { get; set; }
        internal DbSet<DataSourceDb> DataSources { get; set; }
        internal DbSet<DeathIllnessDb> DeathIllnesss { get; set; }
        internal DbSet<OMITGroupDb> OMITGroups { get; set; }
        internal DbSet<OrganisationRoleDb> OrganisationRoles { get; set; }
        internal DbSet<PersonaRoleDb> PersonaRoles { get; set; }
        internal DbSet<ProductTypeDb> ProductTypes { get; set; }
        internal DbSet<IncidentStatusDb> IncidentStatus { get; set; }
        internal DbSet<SignalStatusDb> SignalStatus { get; set; }
        internal DbSet<UnitQuantityDb> UnitQuantities { get; set; }
        internal DbSet<BatchCodeDb> BatchCodes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<ClassificationDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<CategoryDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<ContactMethodDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<CountryDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<DataSourceDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<DeathIllnessDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<OMITGroupDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<OrganisationDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<ProductTypeDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<SignalStatusDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<UnitQuantityDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<IncidentStatusDb>());

            modelBuilder.ApplyConfiguration(new IncidentBuilderConfig());
            modelBuilder.ApplyConfiguration(new IncidentLinkBuilder());

            //modelBuilder.Entity<GatewayErrorCodeDb>().HasKey(p => p.ReturnCode);
            //modelBuilder.Entity<GatewayRequestDetailDb>().HasKey(p => p.RequestId);

            //modelBuilder.Entity<OrganisationDb>().HasOne(p=>p.OrganisationRole).WithOne().OnDelete(DeleteBehavior.NoAction);
        }
    }
}
