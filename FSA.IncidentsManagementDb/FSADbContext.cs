using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace FSA.IncidentsManagementDb
{
    public class FSADbContext : DbContext
    {
        public FSADbContext(DbContextOptions options) : base(options)
        {
        }

        internal DbSet<GatewayErrorCodeDb> GatewayErrorCodes { get; set; }
        internal DbSet<GatewayRequestDetailDb> GatewayRequestDetails { get; set; }
        internal DbSet<GatewayUserIncidentDb> GatewayUserIncidents { get; set; }
        internal DbSet<IncidentCommentDb> IncidentComments { get; set; }
        internal DbSet<IncidentDb> Incidents { get; set; }
        internal DbSet<IncidentLinkDb> IncidentLinks { get; set; }
        internal DbSet<IncidentOMITGroupDb> IncidentOMITGroups { get; set; }
        internal DbSet<OrganisationDb> Organisations { get; set; }
        internal DbSet<CategoryDb> Categories { get; set; }
        internal DbSet<ClassificationDb> Classifications { get; set; }
        internal DbSet<ContactMethodDb> ContactMethods { get; set; }
        internal DbSet<CountryDb> Countrys { get; set; }
        internal DbSet<DataSourceDb> DataSources { get; set; }
        internal DbSet<DeathIllnessDb> DeathIllnesss { get; set; }
        internal DbSet<OMITGroupDb> OMITGroups { get; set; }
        internal DbSet<OrganisationRoleDb> OrganisationRoles { get; set; }
        internal DbSet<PersonaRoleDb> PersonaRoles { get; set; }
        internal DbSet<ProductTypeDb> ProductTypes { get; set; }
        internal DbSet<StatusDb> Status { get; set; }
        internal DbSet<UnitQuantityDb> UnitQuantities { get; set; }
        internal DbSet<UserDb> Users { get; set; }
        internal DbSet<UserRoleDb> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GatewayErrorCodeDb>().HasKey(p => p.ReturnCode);
            modelBuilder.Entity<GatewayRequestDetailDb>().HasKey(p => p.RequestId);
            modelBuilder.Entity<IncidentLinkDb>().HasKey(p => new { p.FromIncidentId, p.ToIncidentId });

            //modelBuilder.Entity<OrganisationDb>().HasOne(p=>p.OrganisationRole).WithOne().OnDelete(DeleteBehavior.NoAction);
        }
    }
}
