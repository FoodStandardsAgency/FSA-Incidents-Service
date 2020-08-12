using EntityFrameworkCore.TemporalTables.Extensions;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Builders;
using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FSA.IncidentsManagementDb
{
    public class FSADbContext : DbContext
    {
        private string _Editor;

        public FSADbContext(DbContextOptions options) : base(options)
        {
        }

        internal DbSet<IncidentCommentDb> IncidentComments { get; set; }
        internal DbSet<IncidentDb> Incidents { get; set; }
        internal DbSet<StakeholderDb> Stakeholders { get; set; }

        internal DbSet<IncidentLinkDb> IncidentLinks { get; set; }
        internal DbSet<IncidentOMITGroupDb> IncidentOMITGroups { get; set; }

        internal DbSet<OrganisationDb> Organisations { get; set; }
        //internal DbSet<OrganisationRoleDb> OrganisationRoles { get; set; }
        internal DbSet<NotifierTypeDb> NotifierTypes { get; set; }

        internal DbSet<CategoryDb> Categories { get; set; }
        internal DbSet<ClassificationDb> Classifications { get; set; }
        internal DbSet<PriorityDb> Priorities { get; set; }
        internal DbSet<ContactMethodDb> ContactMethods { get; set; }
        internal DbSet<CountryDb> Countries { get; set; }
        internal DbSet<DataSourceDb> DataSources { get; set; }
        internal DbSet<DeathIllnessDb> DeathIllnesss { get; set; }
        internal DbSet<OMITGroupDb> OMITGroups { get; set; }
        //internal DbSet<PersonaRoleDb> PersonaRoles { get; set; }

        internal DbSet<AdminLeadDb> AdminLeads { get; set; }

        internal DbSet<ProductDb> Products { get; set; }
        internal DbSet<ProductTypeDb> ProductTypes { get; set; }
        internal DbSet<ProductDateDb> ProductDates { get; set; }
        internal DbSet<DateTypeDb> ProductDateTypes { get; set; }
        internal DbSet<ProductFBODb> ProductFBOItems { get; set; }
        internal DbSet<IncidentStatusDb> IncidentStatus { get; set; }
        internal DbSet<SignalStatusDb> SignalStatus { get; set; }
        internal DbSet<UnitQuantityDb> UnitQuantities { get; set; }
        internal DbSet<ProductPackSizeDb> ProductPackSizes { get; set; }

        internal DbSet<FBODb> FBOs { get; set; }
        internal DbSet<FBOTypeDb> FBOTypes { get; set; }

        internal DbSet<NotifierDb> Notifiers { get; set; }

        internal DbSet<DocumentTagDb> DocumentTags { get; set; }
        internal DbSet<TaggedDocumentDb> TaggedAttachements { get; set; }

        internal void SetEditor(string editor)
        {
            this._Editor = editor ?? throw new ArgumentNullException("Must have an editor name.");
        }

        private void SetAuditData()
        {
            var items = ChangeTracker
                            .Entries<BaseEntityDb>()
                            .Where(o => o.State == EntityState.Modified || o.State == EntityState.Added);
            var now = DateTime.Now;
            foreach (var item in items)
            {
                item.Property(o => o.Modified).CurrentValue = now;
                item.Property(o => o.ModifiedBy).CurrentValue = _Editor;
                if (item.State == EntityState.Added)
                {
                    item.Property(o => o.Created).CurrentValue = now;
                    item.Property(o => o.CreatedBy).CurrentValue = _Editor;
                }
            }
        }

        public override int SaveChanges()
        {
            this.SetAuditData();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            this.SetAuditData();
            return base.SaveChangesAsync(cancellationToken);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//#if DEBUG
//            optionsBuilder.EnableSensitiveDataLogging(true);
//#endif
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // We are only applying temporal tables explictly
            modelBuilder.PreventTemporalTables();

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
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<PriorityDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<DateTypeDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<NotifierTypeDb>());
            //modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<FBOTypeDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<AdminLeadDb>());


            modelBuilder.ApplyConfiguration(new IncidentBuilder());
            modelBuilder.ApplyConfiguration(new IncidentLinkBuilder());
            modelBuilder.ApplyConfiguration(new IncidentCommentsBuilder());
            modelBuilder.ApplyConfiguration(new IncidentOMITGroupDbBuilder());
            modelBuilder.ApplyConfiguration(new FBOBuilder());
            modelBuilder.ApplyConfiguration(new NotifierBuilder());
            modelBuilder.ApplyConfiguration(new OrganisationBuilder());

            modelBuilder.ApplyConfiguration(new ProductBuilder());
            modelBuilder.ApplyConfiguration(new ProductDatesBuilder());
            modelBuilder.ApplyConfiguration(new ProductPackSizeBuilder());
            modelBuilder.ApplyConfiguration(new ProductFBOBuilder());
            modelBuilder.ApplyConfiguration(new FBOTypesBuilder());
            modelBuilder.ApplyConfiguration(new DocumentTagBuilder());
            modelBuilder.ApplyConfiguration(new TaggedDocumentBuilder());

            modelBuilder.ApplyConfiguration(new StakeholdersBuilder());

            var seeds= new Seeder();
            seeds.SeedLookups(modelBuilder);

            
        }
    }
}
