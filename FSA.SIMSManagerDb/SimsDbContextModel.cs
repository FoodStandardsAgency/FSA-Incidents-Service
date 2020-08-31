using FSA.SIMSManagerDb.Builder;
using FSA.SIMSManagerDb.Builders;
using FSA.SIMSManagerDb.Entities;
using FSA.SIMSManagerDb.Entities.Lookups;
using FSA.SIMSManagerDb.Utilities;
using Microsoft.EntityFrameworkCore;

namespace FSA.SIMSManagerDb
{
    public partial class SimsDbContext
    {

        #region Incidents
        internal DbSet<IncidentDb> Incidents { get; set; }
        internal DbSet<IncidentLinkDb> IncidentLinks { get; set; }
        internal DbSet<IncidentNoteDb> IncidentNotes { get; set; }
        internal DbSet<IncidentStakeholderDb> IncidentStakeholders { get; set; }
        internal DbSet<IncidentAttachmentDb> IncidentAttachments { get; set; }
        internal DbSet<IncidentProductDb> IncidentProducts { get; set; }
        internal DbSet<IncidentProductDateDb> IncidentProductDates { get; set; }
        internal DbSet<IncidentProductFboDb> IncidentProductFbos { get; set; }
        internal DbSet<IncidentProductPackSizeDb> IncidentProductPackSizes { get; set; }

        #endregion

        #region Signals
        internal DbSet<SignalDb> Signals { get; set; }
        internal DbSet<SignalLinkDb> SignalLinks { get; set; }
        internal DbSet<SignalNoteDb> SignalNotes { get; set; }
        
        internal DbSet<SignalStakeholderDb> SignalStakeholders { get; set; }
        internal DbSet<SignalAttachmentDb> SignalAttachments { get; set; }

        internal DbSet<SignalProductDb> SignalProducts { get; set; }
        internal DbSet<SignalProductDateDb> SignalProductDates { get; set; }
        internal DbSet<SignalProductFboDb> SignalProductFbos { get; set; }
        internal DbSet<SignalProductPackSizeDb> SignalProductPackSizes { get; set; }

        #endregion

        internal DbSet<AddressDb> Addresses { get; set; }
        internal DbSet<AddressContactDb> AddressContacts { get; set; }
        internal DbSet<NotifierTypeDb> NotifierTypes { get; set; }

        #region Lookups
        internal DbSet<CategoryDb> Categories { get; set; }
        internal DbSet<ClassificationDb> Classifications { get; set; }
        internal DbSet<PriorityDb> Priorities { get; set; }
        internal DbSet<ContactMethodDb> ContactMethods { get; set; }
        internal DbSet<CountryDb> Countries { get; set; }
        internal DbSet<DataSourceDb> DataSources { get; set; }
        internal DbSet<DeathIllnessDb> DeathIllnesss { get; set; }

        internal DbSet<StakeholderIncidentRoleDb> StakeholderIncidentRoles { get; set; }
        internal DbSet<AdminLeadDb> AdminLeads { get; set; }
        internal DbSet<ProductTypeDb> ProductTypes { get; set; }
        internal DbSet<DateTypeDb> ProductDateTypes { get; set; }
        internal DbSet<IncidentStatusDb> IncidentStatus { get; set; }
        internal DbSet<SignalStatusDb> SignalStatus { get; set; }
        internal DbSet<UnitQuantityDb> UnitQuantities { get; set; }
        internal DbSet<FBOTypeDb> FBOTypes { get; set; }
        internal DbSet<DocumentTagDb> DocumentTags { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {         
            modelBuilder.ApplyConfiguration(new AddressBuilder());
            modelBuilder.ApplyConfiguration(new AddressContactBuilder());

            modelBuilder.ApplyConfiguration(new IncidentBuilder());
            modelBuilder.ApplyConfiguration(new LinksBuilder<IncidentLinkDb>(nameof(this.IncidentLinks)));
            modelBuilder.ApplyConfiguration(new AttachmentBuilder<IncidentAttachmentDb>(nameof(this.IncidentAttachments), "IncidentId"));
            modelBuilder.ApplyConfiguration(new StakeholderBuilder<IncidentStakeholderDb>("IncidentId"));
            modelBuilder.ApplyConfiguration(new NotesBuilder<IncidentNoteDb>(nameof(this.IncidentNotes), "IncidentId"));

            modelBuilder.ApplyConfiguration(new IncidentProductBuilder());
            modelBuilder.ApplyConfiguration(new ProductPackSizeBuilder<IncidentProductPackSizeDb>(nameof(this.IncidentProductPackSizes), "IncidentId"));
            modelBuilder.ApplyConfiguration(new ProductFboBuilder<IncidentProductFboDb>(nameof(this.IncidentProductFbos)));
            modelBuilder.ApplyConfiguration(new ProductDateBuilder<IncidentProductDateDb>(nameof(this.IncidentProductDates), "IncidentId"));

            modelBuilder.ApplyConfiguration(new SignalBuilder());
            modelBuilder.ApplyConfiguration(new LinksBuilder<SignalLinkDb>(nameof(this.SignalLinks)));
            modelBuilder.ApplyConfiguration(new AttachmentBuilder<SignalAttachmentDb>(nameof(this.SignalAttachments), "SignalId"));
            modelBuilder.ApplyConfiguration(new StakeholderBuilder<SignalStakeholderDb>("SignalId"));
            modelBuilder.ApplyConfiguration(new NotesBuilder<SignalNoteDb>(nameof(this.SignalNotes), "SignalId"));

            modelBuilder.ApplyConfiguration(new SignalProductBuilder());
            modelBuilder.ApplyConfiguration(new ProductPackSizeBuilder<SignalProductPackSizeDb>(nameof(this.SignalProductPackSizes), "SignalId"));
            modelBuilder.ApplyConfiguration(new ProductDateBuilder<SignalProductDateDb>(nameof(this.SignalProductDates), "SignalId"));
            modelBuilder.ApplyConfiguration(new ProductFboBuilder<SignalProductFboDb>(nameof(this.SignalProductFbos)));

            #region Lookups           
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<CategoryDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<ClassificationDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<PriorityDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<ContactMethodDb>());
            modelBuilder.ApplyConfiguration(new CountriesLookupBuilder());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<DataSourceDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<DeathIllnessDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<StakeholderIncidentRoleDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<AdminLeadDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<ProductTypeDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<DateTypeDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<IncidentStatusDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<SignalStatusDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<UnitQuantityDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<FBOTypeDb>());
            modelBuilder.ApplyConfiguration(new BasicLookupsBuilder<DocumentTagDb>());
            #endregion

            var seeds = new Seeder();
            seeds.SeedLookups(modelBuilder);
        }
    }
}
