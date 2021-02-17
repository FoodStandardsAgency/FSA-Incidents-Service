using FSA.SIMSManagerDb.Entities.Lookups;
using Microsoft.EntityFrameworkCore;
using System;

namespace FSA.SIMSManagerDb.Utilities
{
    public class Seeder
    {
        public void SeedLookups(ModelBuilder modelBuilder)
        {
            AdminLeads(modelBuilder);
            IncidentCategories(modelBuilder);
            Classifications(modelBuilder);
            ContactMethods(modelBuilder);
            Countries(modelBuilder);
            DataSource(modelBuilder);
            DeathIllness(modelBuilder);
            FBOType(modelBuilder);
            IncidentStatus(modelBuilder);
            IncidentSource(modelBuilder);
            NotifierType(modelBuilder);
            Priorities(modelBuilder);
            ProductDateDb(modelBuilder);
            ProductTypes(modelBuilder);
            SignalStatus(modelBuilder);
            UnitQuants(modelBuilder);
            DocumentTag(modelBuilder);
            NoteTagDb(modelBuilder);
            StakeholderDiscrimatior(modelBuilder);
            StakeholderIncidentRoles(modelBuilder);
            CloseSignalTeams(modelBuilder);
            CloseSignalReasons(modelBuilder);
        }

        private void NoteTagDb(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NoteTagDb>()
                 .HasData(new NoteTagDb
                 {
                     Id = 1,
                     Title = "CVED/CED",
                     CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                     ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                 },
                     new NoteTagDb
                     {
                         Id = 2,
                         Title = "Analytical report",
                         CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                         ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                     },
                     new NoteTagDb
                     {
                         Id = 4,
                         Title = "Bill / Delivery Document",
                         CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                         ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                     },
                     new NoteTagDb
                     {
                         Id = 8,
                         Title = "Follow up notification",
                         CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                         ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                     },
                     new NoteTagDb
                     {
                         Id = 16,
                         Title = "Health certifiacte",
                         CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                         ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                     },
                     new NoteTagDb
                     {
                         Id = 32,
                         Title = "Phytosanitary Certifcate",
                         CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                         ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                     },
                     new NoteTagDb
                     {
                         Id = 64,
                         Title = "Picture",
                         CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                         ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                     },
                     new NoteTagDb
                     {
                         Id = 128,
                         Title = "Public warning / Press release",
                         CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                         ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                     },
                     new NoteTagDb
                     {
                         Id = 256,
                         Title = "Recipients List",
                         CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                         ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                     },
                     new NoteTagDb
                     {
                         Id = 512,
                         Title = "Risk assessment",
                         CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                         ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                     },
                     new NoteTagDb
                     {
                         Id = 1024,
                         Title = "Screenshot",
                         CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                         ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                     },
                     new NoteTagDb
                     {
                         Id = 2048,
                         Title = "Translation",
                         CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                         ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                     },
                     new NoteTagDb
                     {
                         Id = 4096,
                         Title = "Video File",
                         CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                         ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                     }, new NoteTagDb
                     {
                         Id = 8192,
                         Title = "Other",
                         CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                         ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                     });
        }

        private void IncidentSource(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IncidentSourceDb>()
                .HasData(new IncidentSourceDb
                {
                    Id = 1,
                    Title = "Animal Feed",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                }, new IncidentSourceDb
                {
                    Id = 2,
                    Title = "Biocides",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new IncidentSourceDb
                {
                    Id = 3,
                    Title = "Fire",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new IncidentSourceDb
                {
                    Id = 4,
                    Title = "Fraud",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new IncidentSourceDb
                {
                    Id = 5,
                    Title = "Human Error",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new IncidentSourceDb
                {
                    Id = 6,
                    Title = "Illegal Import/Export",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new IncidentSourceDb
                {
                    Id = 7,
                    Title = "Investigation Ongoing",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new IncidentSourceDb
                {
                    Id = 8,
                    Title = "Labelling Packaging Error",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new IncidentSourceDb
                {
                    Id = 9,
                    Title = "Malicious Tampering",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new IncidentSourceDb
                {
                    Id = 10,
                    Title = "Metals - Geochemical",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new IncidentSourceDb
                {
                    Id = 11,
                    Title = "Metals - Other",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new IncidentSourceDb
                {
                    Id = 12,
                    Title = "Microbiological Contamination",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new IncidentSourceDb
                {
                    Id = 13,
                    Title = "Migration of Chemicals",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new IncidentSourceDb
                {
                    Id = 14,
                    Title = "Natural Chemical Contamination",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new IncidentSourceDb
                {
                    Id = 15,
                    Title = "Pesticides",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },

                new IncidentSourceDb
                {
                    Id = 16,
                    Title = "Production Fault",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new IncidentSourceDb
                {
                    Id = 17,
                    Title = "Spill/Leak",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new IncidentSourceDb
                {
                    Id = 18,
                    Title = "Unauthorised Premises/Process",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new IncidentSourceDb
                {
                    Id = 19,
                    Title = "Unknown",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new IncidentSourceDb
                {
                    Id = 20,
                    Title = "Use of Unauthorised Ingredient",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new IncidentSourceDb
                {
                    Id = 21,
                    Title = "Veterinary Medicine",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                });
        }

        private void CloseSignalReasons(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CloseSignalReasonDb>()
              .HasData(new CloseSignalReasonDb
              {
                  Id = 1,
                  Title = "No UK distribution",
                  CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                  ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
              }, new CloseSignalReasonDb
              {
                  Id = 2,
                  Title = "Duplicate Signal - Same Source",
                  CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                  ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
              }, new CloseSignalReasonDb
              {
                  Id = 3,
                  Title = "Duplicate Signal - Different Source",
                  CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                  ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
              }, new CloseSignalReasonDb
              {
                  Id = 4,
                  Title = "RASFF - No UK Distribution",
                  CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                  ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
              }, new CloseSignalReasonDb
              {
                  Id = 5,
                  Title = "Not Enough Information for Follow-Up",
                  CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                  ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
              }, new CloseSignalReasonDb
              {
                  Id = 6,
                  Title = "Not a food or feed safety issue",
                  CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                  ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
              }, new CloseSignalReasonDb
              {
                  Id = 7,
                  Title = "RASFF - Confirmed UK Distribution",
                  CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                  ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
              }, new CloseSignalReasonDb
              {
                  Id = 8,
                  Title = "Historic Signal",
                  CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                  ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
              }, new CloseSignalReasonDb
              {
                  Id = 9,
                  Title = "Known Issue",
                  CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                  ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
              });
        }

        private void CloseSignalTeams(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CloseSignalTeamDb>()
               .HasData(new CloseSignalTeamDb
               {
                   Id = 1,
                   Title = "National Food Crime Unit (NFCU)",
                   CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                   ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
               }, new CloseSignalTeamDb
               {
                   Id = 2,
                   Title = "Food Policy lead",
                   CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                   ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
               }, new CloseSignalTeamDb
               {
                   Id = 4,
                   Title = "Imported foods",
                   CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                   ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
               }, new CloseSignalTeamDb
               {
                   Id = 8,
                   Title = "Food Industry Liasion Group (FILG)",
                   CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                   ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
               }, new CloseSignalTeamDb
               {
                   Id = 16,
                   Title = "Comms",
                   CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                   ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
               }, new CloseSignalTeamDb
               {
                   Id = 32,
                   Title = "Referred to LA/PA for Information only",
                   CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                   ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
               }, new CloseSignalTeamDb
               {
                   Id = 64,
                   Title = "Incident Team",
                   CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                   ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
               }, new CloseSignalTeamDb
               {
                   Id = 128,
                   Title = "Other Government Department",
                   CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                   ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
               }, new CloseSignalTeamDb
               {
                   Id = 256,
                   Title = "Other",
                   CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                   ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
               });
        }

        private void UnitQuants(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UnitQuantityDb>()
                .HasData(new UnitQuantityDb
                {
                    Id = 1,
                    Title = "Undefined",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 8,
                    Title = "Gallons (gal)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 9,
                    Title = "Grams (g)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 10,
                    Title = "Kilograms (kg)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 11,
                    Title = "Litres (l)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 19,
                    Title = "Tonnes (t)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                }, new UnitQuantityDb
                {
                    Id = 20,
                    Title = "Millilitres (ml)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                }, new UnitQuantityDb
                {
                    Id = 21,
                    Title = "Ounces (oz)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 22,
                    Title = "Pints (pt)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 23,
                    Title = "Pounds (lb)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 24,
                    Title = "Units",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                });
        }

        private void SignalStatus(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SignalStatusDb>()
                .HasData(
                new SignalStatusDb
                {
                    Id = 1,
                    Title = "Unassigned",
                    SortOrder = 100,
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new SignalStatusDb
                {
                    Id = 2,
                    Title = "Open",
                    SortOrder = 200,
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new SignalStatusDb
                {
                    Id = 3,
                    SortOrder = 300,
                    Title = "Pending",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new SignalStatusDb
                {
                    Id = 50,
                    Title = "Closed : New Incident",
                    SortOrder = 400,
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new SignalStatusDb
                {
                    Id = 100,
                    Title = "Closed : No Incident",
                    SortOrder = 500,
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new SignalStatusDb
                {
                    Id = 150,
                    Title = "Closed : Referral (Offline)",
                    SortOrder = 700,
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new SignalStatusDb
                {
                    Id = 200,
                    Title = "Closed : Linked Incident",
                    SortOrder = 600,
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                });

        }

        private void ProductTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductTypeDb>()
                .HasData(new ProductTypeDb
                {
                    Id = 1,
                    Title = "Undefined",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
            new ProductTypeDb
            {
                Id = 2,
                Title = "Animal by-Products",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 3,
                Title = "Alcoholic Beverages",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 4,
                Title = "Bivalve Molluscs & Products Thereof",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 5,
                Title = "Cephalopods & Products Thereof",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 6,
                Title = "Cereals & Bakery Products",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 7,
                Title = "Cocoa / Cocoa Preparations / Coffee / Tea",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 8,
                Title = "Compound Feeds",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 9,
                Title = "Confectionery",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 10,
                Title = "Crustaceans & Products Thereof",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 11,
                Title = "Dietetic Foods / Food Supplements / Fortified Foods",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 12,
                Title = "Egg & Egg Products",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 13,
                Title = "Fats & Oils",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 14,
                Title = "Feed Additives",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 15,
                Title = "Feed Materials",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 16,
                Title = "Feed Premixtures",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 17,
                Title = "Fish & Fish Products",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 18,
                Title = "Food Additives & Flavourings",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 19,
                Title = "Food Contact Materials",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 20,
                Title = "Fruits & Vegetables",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 21,
                Title = "Gastropods",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 22,
                Title = "Herbs & Spices",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 23,
                Title = "Honey & Royal Jelly",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 24,
                Title = "Ices & Desserts",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 25,
                Title = "Meat & Meat Products (other than poultry)",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 26,
                Title = "Milk & Milk Products",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 27,
                Title = "N/A",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 28,
                Title = "Non-Alcoholic Beverages",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 29,
                Title = "Nuts / Nut Products / Seeds",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 30,
                Title = "Other Food Product / Mixed",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 31,
                Title = "Pet Food",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 32,
                Title = "Poultry Meat & Poultry Meat Products",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 33,
                Title = "Prepared Dishes & Snacks",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 34,
                Title = "Soups / Broths / Sauces & Condiments",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 35,
                Title = "Water",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 36,
                Title = "Wine",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
            new ProductTypeDb
            {
                Id = 37,
                Title = "Unmapped SPT Signal Value",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            });
        }

        private void ProductDateDb(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DateTypeDb>()
                .HasData(new DateTypeDb
                {
                    Id = 1,
                    Title = "Use By Date",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                    new DateTypeDb
                    {
                        Id = 2,
                        Title = "Best before",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new DateTypeDb
                    {
                        Id = 3,
                        Title = "Best before End",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new DateTypeDb
                    {
                        Id = 4,
                        Title = "Display Until",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    }, new DateTypeDb
                    {
                        Id = 5,
                        Title = "Undefined",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    });
        }

        private void Priorities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PriorityDb>()
         .HasData(
            new PriorityDb
            {
                Id = 1,
                Title = "TBC",
                CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
            },
             new PriorityDb
             {
                 Id = 2,
                 Title = "High",
                 CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                 ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
             },
             new PriorityDb
             {
                 Id = 3,
                 Title = "Medium",
                 CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                 ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
             },
             new PriorityDb
             {
                 Id = 4,
                 Title = "Low",
                 CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                 ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
             }, new PriorityDb
             {
                 Id = 5,
                 Title = "Undefined",
                 CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                 ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
             });
        }

        private void FBOType(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FBOTypeDb>()
                .HasData(new FBOTypeDb
                {
                    Id = 1,
                    Title = "Consignor",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                    new FBOTypeDb
                    {
                        Id = 2,
                        Title = "e-platform/e-market place",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 4,
                        Title = "e-trader",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 8,
                        Title = "Exporter",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 16,
                        Title = "Farmer",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 32,
                        Title = "Hospitality/Food service",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 64,
                        Title = "Importer",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 128,
                        Title = "Manufacturer",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 256,
                        Title = "Packer/filler",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 512,
                        Title = "Processor",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 1024,
                        Title = "Producer",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 2048,
                        Title = "Retailer",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 4096,
                        Title = "Storage",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 8192,
                        Title = "Supplier",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 16384,
                        Title = "Trader/Broker",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 32768,
                        Title = "Transporter",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 65536,
                        Title = "Wholesaler",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    });
        }

        private void DocumentTag(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocumentTagDb>()
                .HasData(new DocumentTagDb
                {
                    Id = 1,
                    Title = "CVED/CED",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                    new DocumentTagDb
                    {
                        Id = 2,
                        Title = "Analytical report",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new DocumentTagDb
                    {
                        Id = 4,
                        Title = "Bill / Delivery Document",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new DocumentTagDb
                    {
                        Id = 8,
                        Title = "Follow up notification",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new DocumentTagDb
                    {
                        Id = 16,
                        Title = "Health certifiacte",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new DocumentTagDb
                    {
                        Id = 32,
                        Title = "Phytosanitary Certifcate",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new DocumentTagDb
                    {
                        Id = 64,
                        Title = "Picture",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new DocumentTagDb
                    {
                        Id = 128,
                        Title = "Public warning / Press release",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new DocumentTagDb
                    {
                        Id = 256,
                        Title = "Recipients List",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new DocumentTagDb
                    {
                        Id = 512,
                        Title = "Risk assessment",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new DocumentTagDb
                    {
                        Id = 1024,
                        Title = "Screenshot",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new DocumentTagDb
                    {
                        Id = 2048,
                        Title = "Translation",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new DocumentTagDb
                    {
                        Id = 4096,
                        Title = "Video File",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    }, new DocumentTagDb
                    {
                        Id = 8192,
                        Title = "Other",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    });
        }

        private void StakeholderDiscrimatior(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StakeholderDiscriminatorDb>()
               .HasData(new StakeholderDiscriminatorDb
               {
                   Id = 1,
                   Title = "Food Standards Agency (FSA)",
                   CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                   ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
               },
               new StakeholderDiscriminatorDb
               {
                   Id = 2,
                   Title = "Local Authority",
                   CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                   ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
               },
               new StakeholderDiscriminatorDb
               {
                   Id = 3,
                   Title = "Other government department",
                   CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                   ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
               },
               new StakeholderDiscriminatorDb
               {
                   Id = 4,
                   Title = "Food/Feed Business Operator (FBO/FeBO)",
                   CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                   ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
               });
        }

        private void NotifierType(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NotifierTypeDb>()
                .HasData(new NotifierTypeDb
                {
                    Id = 1,
                    Title = "Industry",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new NotifierTypeDb
                {
                    Id = 2,
                    Title = "Local Authority",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new NotifierTypeDb
                {
                    Id = 3,
                    Title = "Other Government Department",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                });
        }

        private void DeathIllness(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeathIllnessDb>()
                .HasData(new DeathIllnessDb
                {
                    Id = 1,
                    Title = "Abdominal Pain",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DeathIllnessDb
                {
                    Id = 4,
                    Title = "Undefined",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                    new DeathIllnessDb
                    {
                        Id = 2,
                        Title = "Diarrhoea",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new DeathIllnessDb
                    {
                        Id = 3,
                        Title = "Vomiting",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    });
        }

        private void DataSource(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataSourceDb>()
                .HasData(new DataSourceDb
                {
                    Id = 2,
                    Title = "Administrative Assistance & Cooperation System (AAC)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 3,
                    Title = "Animal & Plant Health Agency (APHA)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 4,
                    Title = "Border Inspection Posts (BIPs)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 5,
                    Title = "Department of Agriculture, Environment and Rural Affairs (DAERA)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 6,
                    Title = "Department of Health (DH)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 7,
                    Title = "Department for Environment Food & Rural Affairs (Defra)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 8,
                    Title = "Environment Agency (EA)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 9,
                    Title = "EU Member States",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 10,
                    Title = "European Commission (EC)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 11,
                    Title = "Fire Services",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 12,
                    Title = "Food Standards Scotland (FSS)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 13,
                    Title = "FSA Business Assurance Auditors",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 14,
                    Title = "FSA Dairy Inspector",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 15,
                    Title = "FSA England",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 16,
                    Title = "FSA Operations Group",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 17,
                    Title = "FSA Field Operations - FVL",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 18,
                    Title = "FSA Field Operations - FVC",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 19,
                    Title = "FSA Meat Hygiene Inspector",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 20,
                    Title = "FSA Northern Ireland (FSANI)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 21,
                    Title = "FSA Policy",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 22,
                    Title = "FSA Poultry Hygiene Inspector",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 23,
                    Title = "FSA RAM Referral",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 24,
                    Title = "FSA Survey",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 25,
                    Title = "FSA Wales (FSAW)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 26,
                    Title = "FSA Wine Inspector",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 27,
                    Title = "FSA Unannounced Inspector",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 28,
                    Title = "General Public",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 29,
                    Title = "Home Office / Border Force",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 30,
                    Title = "Health Protection Agency (HPA)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 31,
                    Title = "Health Protection Scotland (HPS)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 32,
                    Title = "Health & Safety Executive",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 33,
                    Title = "Industry",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 34,
                    Title = "INFOSAN",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 35,
                    Title = "Local Authority",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 36,
                    Title = "Marine Management Organisation (MMO)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 37,
                    Title = "Maritime & Costguard Agency (MCA)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 38,
                    Title = "Medicines & Healthcare products Regulatory Agency (MHRA)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 39,
                    Title = "Met Office",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 40,
                    Title = "National Crime Agency (NCA)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 41,
                    Title = "National Food Crime Unit (NFCU)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 42,
                    Title = "National Food Crime Unit (NFCU) - NFCU INTEL Report",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 43,
                    Title = "National Food Crime Unit (NFCU) - DIM Referral",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 44,
                    Title = "National Health Service (NHS)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 45,
                    Title = "Nuclear Power Station",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 46,
                    Title = "Other",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 47,
                    Title = "Police",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 48,
                    Title = "Port Health Authority (PHA)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 49,
                    Title = "Public Analyst / Laboratory",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 50,
                    Title = "Public Health England (PHE)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 51,
                    Title = "RASFF",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 52,
                    Title = "SAC (Scottish Agricultural College)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 53,
                    Title = "SOCA",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 54,
                    Title = "Third Country",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 55,
                    Title = "Water Company",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 56,
                    Title = "Veterinary Medicines Directorate",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
                {
                    Id = 57,
                    Title = "Unmapped SPT Signal Value",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                }, new DataSourceDb
                {
                    Id = 58,
                    Title = "Undefined",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                });
        }

        private void Countries(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CountryDb>()
                .HasData(new CountryDb()
                {
                    Id = 1,
                    Title = "Andorra",
                    KeyField = "https://country.register.gov.uk/record/AD",
                    CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                    ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                },
                    new CountryDb()
                    {
                        Id = 2,
                        Title = "United Arab Emirates",
                        KeyField = "https://country.register.gov.uk/record/AE",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 3,
                        Title = "Ajman",
                        KeyField = "https://territory.register.gov.uk/record/AE-AJ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 4,
                        Title = "Abu Dhabi",
                        KeyField = "https://territory.register.gov.uk/record/AE-AZ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 5,
                        Title = "Dubai",
                        KeyField = "https://territory.register.gov.uk/record/AE-DU",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 6,
                        Title = "Fujairah",
                        KeyField = "https://territory.register.gov.uk/record/AE-FU",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 7,
                        Title = "Ras al-Khaimah",
                        KeyField = "https://territory.register.gov.uk/record/AE-RK",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 8,
                        Title = "Sharjah",
                        KeyField = "https://territory.register.gov.uk/record/AE-SH",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 9,
                        Title = "Umm al-Quwain",
                        KeyField = "https://territory.register.gov.uk/record/AE-UQ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 10,
                        Title = "Afghanistan",
                        KeyField = "https://country.register.gov.uk/record/AF",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 11,
                        Title = "Antigua and Barbuda",
                        KeyField = "https://country.register.gov.uk/record/AG",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 12,
                        Title = "Anguilla",
                        KeyField = "https://territory.register.gov.uk/record/AI",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 13,
                        Title = "Albania",
                        KeyField = "https://country.register.gov.uk/record/AL",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 14,
                        Title = "Armenia",
                        KeyField = "https://country.register.gov.uk/record/AM",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 15,
                        Title = "Angola",
                        KeyField = "https://country.register.gov.uk/record/AO",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 16,
                        Title = "Antarctica",
                        KeyField = "https://territory.register.gov.uk/record/AQ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 17,
                        Title = "Argentina",
                        KeyField = "https://country.register.gov.uk/record/AR",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 18,
                        Title = "American Samoa",
                        KeyField = "https://territory.register.gov.uk/record/AS",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 19,
                        Title = "Austria",
                        KeyField = "https://country.register.gov.uk/record/AT",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 20,
                        Title = "Australia",
                        KeyField = "https://country.register.gov.uk/record/AU",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 21,
                        Title = "Aruba",
                        KeyField = "https://territory.register.gov.uk/record/AW",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 22,
                        Title = "Aland Islands",
                        KeyField = "https://territory.register.gov.uk/record/AX",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 23,
                        Title = "Azerbaijan",
                        KeyField = "https://country.register.gov.uk/record/AZ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 24,
                        Title = "Bosnia and Herzegovina",
                        KeyField = "https://country.register.gov.uk/record/BA",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 25,
                        Title = "British Antarctic Territory",
                        KeyField = "https://territory.register.gov.uk/record/BAT",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 26,
                        Title = "Barbados",
                        KeyField = "https://country.register.gov.uk/record/BB",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 27,
                        Title = "Bangladesh",
                        KeyField = "https://country.register.gov.uk/record/BD",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 28,
                        Title = "Belgium",
                        KeyField = "https://country.register.gov.uk/record/BE",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 29,
                        Title = "Burkina Faso",
                        KeyField = "https://country.register.gov.uk/record/BF",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 30,
                        Title = "Bulgaria",
                        KeyField = "https://country.register.gov.uk/record/BG",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 31,
                        Title = "Bahrain",
                        KeyField = "https://country.register.gov.uk/record/BH",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 32,
                        Title = "Burundi",
                        KeyField = "https://country.register.gov.uk/record/BI",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 33,
                        Title = "Benin",
                        KeyField = "https://country.register.gov.uk/record/BJ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 34,
                        Title = "Saint Barthelemy",
                        KeyField = "https://territory.register.gov.uk/record/BL",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 35,
                        Title = "Bermuda",
                        KeyField = "https://territory.register.gov.uk/record/BM",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 36,
                        Title = "Brunei",
                        KeyField = "https://country.register.gov.uk/record/BN",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 37,
                        Title = "Bolivia",
                        KeyField = "https://country.register.gov.uk/record/BO",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 38,
                        Title = "Bonaire",
                        KeyField = "https://territory.register.gov.uk/record/BQ-BO",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 39,
                        Title = "Saba",
                        KeyField = "https://territory.register.gov.uk/record/BQ-SA",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 40,
                        Title = "Sint Eustatius",
                        KeyField = "https://territory.register.gov.uk/record/BQ-SE",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 41,
                        Title = "Brazil",
                        KeyField = "https://country.register.gov.uk/record/BR",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 42,
                        Title = "The Bahamas",
                        KeyField = "https://country.register.gov.uk/record/BS",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 43,
                        Title = "Bhutan",
                        KeyField = "https://country.register.gov.uk/record/BT",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 44,
                        Title = "Bouvet Island",
                        KeyField = "https://territory.register.gov.uk/record/BV",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 45,
                        Title = "Botswana",
                        KeyField = "https://country.register.gov.uk/record/BW",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 46,
                        Title = "Belarus",
                        KeyField = "https://country.register.gov.uk/record/BY",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 47,
                        Title = "Belize",
                        KeyField = "https://country.register.gov.uk/record/BZ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 48,
                        Title = "Canada",
                        KeyField = "https://country.register.gov.uk/record/CA",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 49,
                        Title = "Cocos (Keeling) Islands",
                        KeyField = "https://territory.register.gov.uk/record/CC",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 50,
                        Title = "Congo (Democratic Republic)",
                        KeyField = "https://country.register.gov.uk/record/CD",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 51,
                        Title = "Central African Republic",
                        KeyField = "https://country.register.gov.uk/record/CF",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 52,
                        Title = "Congo",
                        KeyField = "https://country.register.gov.uk/record/CG",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 53,
                        Title = "Switzerland",
                        KeyField = "https://country.register.gov.uk/record/CH",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 54,
                        Title = "Ivory Coast",
                        KeyField = "https://country.register.gov.uk/record/CI",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 55,
                        Title = "Cook Islands",
                        KeyField = "https://territory.register.gov.uk/record/CK",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 56,
                        Title = "Chile",
                        KeyField = "https://country.register.gov.uk/record/CL",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 57,
                        Title = "Cameroon",
                        KeyField = "https://country.register.gov.uk/record/CM",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 58,
                        Title = "China",
                        KeyField = "https://country.register.gov.uk/record/CN",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 59,
                        Title = "Colombia",
                        KeyField = "https://country.register.gov.uk/record/CO",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 60,
                        Title = "Costa Rica",
                        KeyField = "https://country.register.gov.uk/record/CR",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 61,
                        Title = "Cuba",
                        KeyField = "https://country.register.gov.uk/record/CU",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 62,
                        Title = "Cape Verde",
                        KeyField = "https://country.register.gov.uk/record/CV",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 63,
                        Title = "Curacao",
                        KeyField = "https://territory.register.gov.uk/record/CW",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 64,
                        Title = "Christmas Island",
                        KeyField = "https://territory.register.gov.uk/record/CX",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 65,
                        Title = "Cyprus",
                        KeyField = "https://country.register.gov.uk/record/CY",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 66,
                        Title = "Czechia",
                        KeyField = "https://country.register.gov.uk/record/CZ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 67,
                        Title = "Germany",
                        KeyField = "https://country.register.gov.uk/record/DE",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 68,
                        Title = "Djibouti",
                        KeyField = "https://country.register.gov.uk/record/DJ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 69,
                        Title = "Denmark",
                        KeyField = "https://country.register.gov.uk/record/DK",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 70,
                        Title = "Dominica",
                        KeyField = "https://country.register.gov.uk/record/DM",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 71,
                        Title = "Dominican Republic",
                        KeyField = "https://country.register.gov.uk/record/DO",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 72,
                        Title = "Algeria",
                        KeyField = "https://country.register.gov.uk/record/DZ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 73,
                        Title = "Ecuador",
                        KeyField = "https://country.register.gov.uk/record/EC",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 74,
                        Title = "Estonia",
                        KeyField = "https://country.register.gov.uk/record/EE",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 75,
                        Title = "Egypt",
                        KeyField = "https://country.register.gov.uk/record/EG",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 76,
                        Title = "Western Sahara",
                        KeyField = "https://territory.register.gov.uk/record/EH",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 77,
                        Title = "Eritrea",
                        KeyField = "https://country.register.gov.uk/record/ER",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 78,
                        Title = "Spain",
                        KeyField = "https://country.register.gov.uk/record/ES",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 79,
                        Title = "Ceuta",
                        KeyField = "https://territory.register.gov.uk/record/ES-CE",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 80,
                        Title = "Melilla",
                        KeyField = "https://territory.register.gov.uk/record/ES-ML",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 81,
                        Title = "Ethiopia",
                        KeyField = "https://country.register.gov.uk/record/ET",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 82,
                        Title = "European Union",
                        KeyField = "http://data.food.gov.uk/codes/geographies/countries/EU",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 83,
                        Title = "Finland",
                        KeyField = "https://country.register.gov.uk/record/FI",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 84,
                        Title = "Fiji",
                        KeyField = "https://country.register.gov.uk/record/FJ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 85,
                        Title = "Falkland Islands",
                        KeyField = "https://territory.register.gov.uk/record/FK",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 86,
                        Title = "Micronesia",
                        KeyField = "https://country.register.gov.uk/record/FM",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 87,
                        Title = "Faroe Islands",
                        KeyField = "https://territory.register.gov.uk/record/FO",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 88,
                        Title = "France",
                        KeyField = "https://country.register.gov.uk/record/FR",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 89,
                        Title = "Gabon",
                        KeyField = "https://country.register.gov.uk/record/GA",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 90,
                        Title = "United Kingdom",
                        KeyField = "https://country.register.gov.uk/record/GB",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 91,
                        Title = "England",
                        KeyField = "http://data.food.gov.uk/codes/geographies/countries/GB-ENG",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 92,
                        Title = "Northern Ireland",
                        KeyField = "http://data.food.gov.uk/codes/geographies/countries/GB-NIR",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 93,
                        Title = "Scotland",
                        KeyField = "http://data.food.gov.uk/codes/geographies/countries/GB-SCT",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 94,
                        Title = "Wales",
                        KeyField = "http://data.food.gov.uk/codes/geographies/countries/GB-WLS",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 95,
                        Title = "Grenada",
                        KeyField = "https://country.register.gov.uk/record/GD",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 96,
                        Title = "Georgia",
                        KeyField = "https://country.register.gov.uk/record/GE",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 97,
                        Title = "French Guiana",
                        KeyField = "https://territory.register.gov.uk/record/GF",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 98,
                        Title = "Guernsey",
                        KeyField = "https://territory.register.gov.uk/record/GG",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 99,
                        Title = "Ghana",
                        KeyField = "https://country.register.gov.uk/record/GH",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 100,
                        Title = "Gibraltar",
                        KeyField = "https://territory.register.gov.uk/record/GI",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 101,
                        Title = "Greenland",
                        KeyField = "https://territory.register.gov.uk/record/GL",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 102,
                        Title = "The Gambia",
                        KeyField = "https://country.register.gov.uk/record/GM",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 103,
                        Title = "Guinea",
                        KeyField = "https://country.register.gov.uk/record/GN",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 104,
                        Title = "Guadeloupe",
                        KeyField = "https://territory.register.gov.uk/record/GP",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 105,
                        Title = "Equatorial Guinea",
                        KeyField = "https://country.register.gov.uk/record/GQ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 106,
                        Title = "Greece",
                        KeyField = "https://country.register.gov.uk/record/GR",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 107,
                        Title = "South Georgia and South Sandwich Islands",
                        KeyField = "https://territory.register.gov.uk/record/GS",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 108,
                        Title = "Guatemala",
                        KeyField = "https://country.register.gov.uk/record/GT",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 109,
                        Title = "Guam",
                        KeyField = "https://territory.register.gov.uk/record/GU",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 110,
                        Title = "Guinea-Bissau",
                        KeyField = "https://country.register.gov.uk/record/GW",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 111,
                        Title = "Guyana",
                        KeyField = "https://country.register.gov.uk/record/GY",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 112,
                        Title = "Hong Kong",
                        KeyField = "https://territory.register.gov.uk/record/HK",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 113,
                        Title = "Heard Island and McDonald Islands",
                        KeyField = "https://territory.register.gov.uk/record/HM",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 114,
                        Title = "Honduras",
                        KeyField = "https://country.register.gov.uk/record/HN",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 115,
                        Title = "Croatia",
                        KeyField = "https://country.register.gov.uk/record/HR",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 116,
                        Title = "Haiti",
                        KeyField = "https://country.register.gov.uk/record/HT",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 117,
                        Title = "Hungary",
                        KeyField = "https://country.register.gov.uk/record/HU",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 118,
                        Title = "Indonesia",
                        KeyField = "https://country.register.gov.uk/record/ID",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 119,
                        Title = "Ireland",
                        KeyField = "https://country.register.gov.uk/record/IE",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 120,
                        Title = "Israel",
                        KeyField = "https://country.register.gov.uk/record/IL",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 121,
                        Title = "Isle of Man",
                        KeyField = "https://territory.register.gov.uk/record/IM",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 122,
                        Title = "India",
                        KeyField = "https://country.register.gov.uk/record/IN",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 123,
                        Title = "British Indian Ocean Territory",
                        KeyField = "https://territory.register.gov.uk/record/IO",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 124,
                        Title = "Iraq",
                        KeyField = "https://country.register.gov.uk/record/IQ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 125,
                        Title = "Iran",
                        KeyField = "https://country.register.gov.uk/record/IR",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 126,
                        Title = "Iceland",
                        KeyField = "https://country.register.gov.uk/record/IS",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 127,
                        Title = "Italy",
                        KeyField = "https://country.register.gov.uk/record/IT",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 128,
                        Title = "Jersey",
                        KeyField = "https://territory.register.gov.uk/record/JE",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 129,
                        Title = "Jamaica",
                        KeyField = "https://country.register.gov.uk/record/JM",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 130,
                        Title = "Jordan",
                        KeyField = "https://country.register.gov.uk/record/JO",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 131,
                        Title = "Japan",
                        KeyField = "https://country.register.gov.uk/record/JP",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 132,
                        Title = "Kenya",
                        KeyField = "https://country.register.gov.uk/record/KE",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 133,
                        Title = "Kyrgyzstan",
                        KeyField = "https://country.register.gov.uk/record/KG",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 134,
                        Title = "Cambodia",
                        KeyField = "https://country.register.gov.uk/record/KH",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 135,
                        Title = "Kiribati",
                        KeyField = "https://country.register.gov.uk/record/KI",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 136,
                        Title = "Comoros",
                        KeyField = "https://country.register.gov.uk/record/KM",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 137,
                        Title = "St Kitts and Nevis",
                        KeyField = "https://country.register.gov.uk/record/KN",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 138,
                        Title = "North Korea",
                        KeyField = "https://country.register.gov.uk/record/KP",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 139,
                        Title = "South Korea",
                        KeyField = "https://country.register.gov.uk/record/KR",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 140,
                        Title = "Kuwait",
                        KeyField = "https://country.register.gov.uk/record/KW",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 141,
                        Title = "Cayman Islands",
                        KeyField = "https://territory.register.gov.uk/record/KY",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 142,
                        Title = "Kazakhstan",
                        KeyField = "https://country.register.gov.uk/record/KZ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 143,
                        Title = "Laos",
                        KeyField = "https://country.register.gov.uk/record/LA",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 144,
                        Title = "Lebanon",
                        KeyField = "https://country.register.gov.uk/record/LB",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 145,
                        Title = "St Lucia",
                        KeyField = "https://country.register.gov.uk/record/LC",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 146,
                        Title = "Liechtenstein",
                        KeyField = "https://country.register.gov.uk/record/LI",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 147,
                        Title = "Sri Lanka",
                        KeyField = "https://country.register.gov.uk/record/LK",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 148,
                        Title = "Liberia",
                        KeyField = "https://country.register.gov.uk/record/LR",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 149,
                        Title = "Lesotho",
                        KeyField = "https://country.register.gov.uk/record/LS",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 150,
                        Title = "Lithuania",
                        KeyField = "https://country.register.gov.uk/record/LT",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 151,
                        Title = "Luxembourg",
                        KeyField = "https://country.register.gov.uk/record/LU",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 152,
                        Title = "Latvia",
                        KeyField = "https://country.register.gov.uk/record/LV",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 153,
                        Title = "Libya",
                        KeyField = "https://country.register.gov.uk/record/LY",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 154,
                        Title = "Morocco",
                        KeyField = "https://country.register.gov.uk/record/MA",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 155,
                        Title = "Monaco",
                        KeyField = "https://country.register.gov.uk/record/MC",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 156,
                        Title = "Moldova",
                        KeyField = "https://country.register.gov.uk/record/MD",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 157,
                        Title = "Montenegro",
                        KeyField = "https://country.register.gov.uk/record/ME",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 158,
                        Title = "Saint-Martin (French part)",
                        KeyField = "https://territory.register.gov.uk/record/MF",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 159,
                        Title = "Madagascar",
                        KeyField = "https://country.register.gov.uk/record/MG",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 160,
                        Title = "Marshall Islands",
                        KeyField = "https://country.register.gov.uk/record/MH",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 161,
                        Title = "Macedonia",
                        KeyField = "https://country.register.gov.uk/record/MK",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 162,
                        Title = "Mali",
                        KeyField = "https://country.register.gov.uk/record/ML",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 163,
                        Title = "Burma",
                        KeyField = "https://country.register.gov.uk/record/MM",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 164,
                        Title = "Mongolia",
                        KeyField = "https://country.register.gov.uk/record/MN",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 165,
                        Title = "Macao",
                        KeyField = "https://territory.register.gov.uk/record/MO",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 166,
                        Title = "Northern Mariana Islands",
                        KeyField = "https://territory.register.gov.uk/record/MP",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 167,
                        Title = "Martinique",
                        KeyField = "https://territory.register.gov.uk/record/MQ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 168,
                        Title = "Mauritania",
                        KeyField = "https://country.register.gov.uk/record/MR",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 169,
                        Title = "Montserrat",
                        KeyField = "https://territory.register.gov.uk/record/MS",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 170,
                        Title = "Malta",
                        KeyField = "https://country.register.gov.uk/record/MT",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 171,
                        Title = "Mauritius",
                        KeyField = "https://country.register.gov.uk/record/MU",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 172,
                        Title = "Maldives",
                        KeyField = "https://country.register.gov.uk/record/MV",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 173,
                        Title = "Malawi",
                        KeyField = "https://country.register.gov.uk/record/MW",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 174,
                        Title = "Mexico",
                        KeyField = "https://country.register.gov.uk/record/MX",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 175,
                        Title = "Malaysia",
                        KeyField = "https://country.register.gov.uk/record/MY",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 176,
                        Title = "Mozambique",
                        KeyField = "https://country.register.gov.uk/record/MZ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 177,
                        Title = "Namibia",
                        KeyField = "https://country.register.gov.uk/record/NA",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 178,
                        Title = "New Caledonia",
                        KeyField = "https://territory.register.gov.uk/record/NC",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 179,
                        Title = "Niger",
                        KeyField = "https://country.register.gov.uk/record/NE",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 180,
                        Title = "Norfolk Island",
                        KeyField = "https://territory.register.gov.uk/record/NF",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 181,
                        Title = "Nigeria",
                        KeyField = "https://country.register.gov.uk/record/NG",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 182,
                        Title = "Nicaragua",
                        KeyField = "https://country.register.gov.uk/record/NI",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 183,
                        Title = "Netherlands",
                        KeyField = "https://country.register.gov.uk/record/NL",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 184,
                        Title = "Norway",
                        KeyField = "https://country.register.gov.uk/record/NO",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 185,
                        Title = "Nepal",
                        KeyField = "https://country.register.gov.uk/record/NP",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 186,
                        Title = "Nauru",
                        KeyField = "https://country.register.gov.uk/record/NR",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 187,
                        Title = "Niue",
                        KeyField = "https://territory.register.gov.uk/record/NU",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 188,
                        Title = "New Zealand",
                        KeyField = "https://country.register.gov.uk/record/NZ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 189,
                        Title = "Oman",
                        KeyField = "https://country.register.gov.uk/record/OM",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 190,
                        Title = "Panama",
                        KeyField = "https://country.register.gov.uk/record/PA",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 191,
                        Title = "Peru",
                        KeyField = "https://country.register.gov.uk/record/PE",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 192,
                        Title = "French Polynesia",
                        KeyField = "https://territory.register.gov.uk/record/PF",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 193,
                        Title = "Papua New Guinea",
                        KeyField = "https://country.register.gov.uk/record/PG",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 194,
                        Title = "Philippines",
                        KeyField = "https://country.register.gov.uk/record/PH",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 195,
                        Title = "Pakistan",
                        KeyField = "https://country.register.gov.uk/record/PK",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 196,
                        Title = "Poland",
                        KeyField = "https://country.register.gov.uk/record/PL",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 197,
                        Title = "Saint Pierre and Miquelon",
                        KeyField = "https://territory.register.gov.uk/record/PM",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 198,
                        Title = "Pitcairn, Henderson, Ducie and Oeno Islands",
                        KeyField = "https://territory.register.gov.uk/record/PN",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 199,
                        Title = "Puerto Rico",
                        KeyField = "https://territory.register.gov.uk/record/PR",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 200,
                        Title = "Occupied Palestinian Territories",
                        KeyField = "https://territory.register.gov.uk/record/PS",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 201,
                        Title = "Portugal",
                        KeyField = "https://country.register.gov.uk/record/PT",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 202,
                        Title = "Palau",
                        KeyField = "https://country.register.gov.uk/record/PW",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 203,
                        Title = "Paraguay",
                        KeyField = "https://country.register.gov.uk/record/PY",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 204,
                        Title = "Qatar",
                        KeyField = "https://country.register.gov.uk/record/QA",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 205,
                        Title = "Reunion",
                        KeyField = "https://territory.register.gov.uk/record/RE",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 206,
                        Title = "Romania",
                        KeyField = "https://country.register.gov.uk/record/RO",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 207,
                        Title = "Serbia",
                        KeyField = "https://country.register.gov.uk/record/RS",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 208,
                        Title = "Russia",
                        KeyField = "https://country.register.gov.uk/record/RU",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 209,
                        Title = "Rwanda",
                        KeyField = "https://country.register.gov.uk/record/RW",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 210,
                        Title = "Saudi Arabia",
                        KeyField = "https://country.register.gov.uk/record/SA",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 211,
                        Title = "Solomon Islands",
                        KeyField = "https://country.register.gov.uk/record/SB",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 212,
                        Title = "Seychelles",
                        KeyField = "https://country.register.gov.uk/record/SC",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 213,
                        Title = "Sudan",
                        KeyField = "https://country.register.gov.uk/record/SD",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 214,
                        Title = "Sweden",
                        KeyField = "https://country.register.gov.uk/record/SE",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 215,
                        Title = "Singapore",
                        KeyField = "https://country.register.gov.uk/record/SG",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 216,
                        Title = "Ascension",
                        KeyField = "https://territory.register.gov.uk/record/SH-AC",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 217,
                        Title = "Saint Helena",
                        KeyField = "https://territory.register.gov.uk/record/SH-HL",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 218,
                        Title = "Tristan da Cunha",
                        KeyField = "https://territory.register.gov.uk/record/SH-TA",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 219,
                        Title = "Slovenia",
                        KeyField = "https://country.register.gov.uk/record/SI",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 220,
                        Title = "Svalbard and Jan Mayen",
                        KeyField = "https://territory.register.gov.uk/record/SJ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 221,
                        Title = "Slovakia",
                        KeyField = "https://country.register.gov.uk/record/SK",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 222,
                        Title = "Sierra Leone",
                        KeyField = "https://country.register.gov.uk/record/SL",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 223,
                        Title = "San Marino",
                        KeyField = "https://country.register.gov.uk/record/SM",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 224,
                        Title = "Senegal",
                        KeyField = "https://country.register.gov.uk/record/SN",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 225,
                        Title = "Somalia",
                        KeyField = "https://country.register.gov.uk/record/SO",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 226,
                        Title = "Suriname",
                        KeyField = "https://country.register.gov.uk/record/SR",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 227,
                        Title = "South Sudan",
                        KeyField = "https://country.register.gov.uk/record/SS",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 228,
                        Title = "Sao Tome and Principe",
                        KeyField = "https://country.register.gov.uk/record/ST",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 229,
                        Title = "El Salvador",
                        KeyField = "https://country.register.gov.uk/record/SV",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 230,
                        Title = "Sint Maarten (Dutch part)",
                        KeyField = "https://territory.register.gov.uk/record/SX",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 231,
                        Title = "Syria",
                        KeyField = "https://country.register.gov.uk/record/SY",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 232,
                        Title = "Swaziland",
                        KeyField = "https://country.register.gov.uk/record/SZ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 233,
                        Title = "Turks and Caicos Islands",
                        KeyField = "https://territory.register.gov.uk/record/TC",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 234,
                        Title = "Chad",
                        KeyField = "https://country.register.gov.uk/record/TD",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 235,
                        Title = "French Southern Territories",
                        KeyField = "https://territory.register.gov.uk/record/TF",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 236,
                        Title = "Togo",
                        KeyField = "https://country.register.gov.uk/record/TG",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 237,
                        Title = "Thailand",
                        KeyField = "https://country.register.gov.uk/record/TH",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 238,
                        Title = "Tajikistan",
                        KeyField = "https://country.register.gov.uk/record/TJ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 239,
                        Title = "Tokelau",
                        KeyField = "https://territory.register.gov.uk/record/TK",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 240,
                        Title = "East Timor",
                        KeyField = "https://country.register.gov.uk/record/TL",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 241,
                        Title = "Turkmenistan",
                        KeyField = "https://country.register.gov.uk/record/TM",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 242,
                        Title = "Tunisia",
                        KeyField = "https://country.register.gov.uk/record/TN",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 243,
                        Title = "Tonga",
                        KeyField = "https://country.register.gov.uk/record/TO",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 244,
                        Title = "Turkey",
                        KeyField = "https://country.register.gov.uk/record/TR",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 245,
                        Title = "Trinidad and Tobago",
                        KeyField = "https://country.register.gov.uk/record/TT",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 246,
                        Title = "Tuvalu",
                        KeyField = "https://country.register.gov.uk/record/TV",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 247,
                        Title = "Taiwan",
                        KeyField = "https://territory.register.gov.uk/record/TW",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 248,
                        Title = "Tanzania",
                        KeyField = "https://country.register.gov.uk/record/TZ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 249,
                        Title = "Ukraine",
                        KeyField = "https://country.register.gov.uk/record/UA",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 250,
                        Title = "Uganda",
                        KeyField = "https://country.register.gov.uk/record/UG",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 251,
                        Title = "Johnston Atoll",
                        KeyField = "https://territory.register.gov.uk/record/UM-67",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 252,
                        Title = "Midway Islands",
                        KeyField = "https://territory.register.gov.uk/record/UM-71",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 253,
                        Title = "Navassa Island",
                        KeyField = "https://territory.register.gov.uk/record/UM-76",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 254,
                        Title = "Wake Island",
                        KeyField = "https://territory.register.gov.uk/record/UM-79",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 255,
                        Title = "Baker Island",
                        KeyField = "https://territory.register.gov.uk/record/UM-81",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 256,
                        Title = "Howland Island",
                        KeyField = "https://territory.register.gov.uk/record/UM-84",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 257,
                        Title = "Jarvis Island",
                        KeyField = "https://territory.register.gov.uk/record/UM-86",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 258,
                        Title = "Kingman Reef",
                        KeyField = "https://territory.register.gov.uk/record/UM-89",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 259,
                        Title = "Palmyra Atoll",
                        KeyField = "https://territory.register.gov.uk/record/UM-95",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 260,
                        Title = "United States",
                        KeyField = "https://country.register.gov.uk/record/US",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 261,
                        Title = "Uruguay",
                        KeyField = "https://country.register.gov.uk/record/UY",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 262,
                        Title = "Uzbekistan",
                        KeyField = "https://country.register.gov.uk/record/UZ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 263,
                        Title = "Vatican City",
                        KeyField = "https://country.register.gov.uk/record/VA",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 264,
                        Title = "St Vincent",
                        KeyField = "https://country.register.gov.uk/record/VC",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 265,
                        Title = "Venezuela",
                        KeyField = "https://country.register.gov.uk/record/VE",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 266,
                        Title = "British Virgin Islands",
                        KeyField = "https://territory.register.gov.uk/record/VG",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 267,
                        Title = "United States Virgin Islands",
                        KeyField = "https://territory.register.gov.uk/record/VI",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 268,
                        Title = "Vietnam",
                        KeyField = "https://country.register.gov.uk/record/VN",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 269,
                        Title = "Vanuatu",
                        KeyField = "https://country.register.gov.uk/record/VU",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 270,
                        Title = "Wallis and Futuna",
                        KeyField = "https://territory.register.gov.uk/record/WF",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 271,
                        Title = "Samoa",
                        KeyField = "https://country.register.gov.uk/record/WS",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 272,
                        Title = "Kosovo",
                        KeyField = "https://country.register.gov.uk/record/XK",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 273,
                        Title = "Akrotiri",
                        KeyField = "https://territory.register.gov.uk/record/XQZ",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 274,
                        Title = "Dhekelia",
                        KeyField = "https://territory.register.gov.uk/record/XXD",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 275,
                        Title = "Yemen",
                        KeyField = "https://country.register.gov.uk/record/YE",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 276,
                        Title = "Mayotte",
                        KeyField = "https://territory.register.gov.uk/record/YT",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 277,
                        Title = "South Africa",
                        KeyField = "https://country.register.gov.uk/record/ZA",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 278,
                        Title = "Zambia",
                        KeyField = "https://country.register.gov.uk/record/ZM",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 279,
                        Title = "Zimbabwe",
                        KeyField = "https://country.register.gov.uk/record/ZW",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 280,
                        Title = "Country",
                        KeyField = "http://data.food.gov.uk/codes/geographies/countries/country",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 281,
                        Title = "non-EU",
                        KeyField = "http://data.food.gov.uk/codes/geographies/countries/non-EU",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 282,
                        Title = "Not Easily Identified",
                        KeyField = "http://data.food.gov.uk/codes/geographies/countries/not-easily-identified",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 283,
                        Title = "Other",
                        KeyField = "http://data.food.gov.uk/codes/geographies/countries/other",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    },
                    new CountryDb()
                    {
                        Id = 284,
                        Title = "Territory",
                        KeyField = "http://data.food.gov.uk/codes/geographies/countries/territory",
                        CreatedBy = "5134b97e9d-eb28-444f-87cb-2c6311af8009",
                        ModifiedBy = "34b97e9d-eb28-444f-87cb-2c6311af8009"
                    });
        }

        private void ContactMethods(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactMethodDb>()
                .HasData(new ContactMethodDb
                {
                    Id = 1,
                    Title = "Email",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new ContactMethodDb
                {
                    Id = 2,
                    Title = "Telephone",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new ContactMethodDb
                {
                    Id = 3,
                    Title = "Web Form",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new ContactMethodDb
                {
                    Id = 4,
                    Title = "No Preference",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new ContactMethodDb
                {
                    Id = 5,
                    Title = "Undefined",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                });

        }

        private void Classifications(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassificationDb>()
                .HasData(new ClassificationDb
                {
                    Id = 1,
                    Title = "Routine",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                }, new ClassificationDb
                {
                    Id = 2,
                    Title = "Non-Routine",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                }
                , new ClassificationDb
                {
                    Id = 3,
                    Title = "Undefined",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                }
                );
        }

        private void IncidentCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HazardGroupDb>()
               .HasData(new HazardGroupDb
               {
                   Id = 36,
                   Title = "Undefined",
                   CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                   ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
               }, new HazardGroupDb
               {
                   Id = 37,
                   Title = "ALLERGEN: Cereals containing gluten",
                   CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                   ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
               },
                new HazardGroupDb
                {
                    Id = 38,
                    Title = "ALLERGEN: Celery",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 39,
                    Title = "ALLERGEN: Crustaceans",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 40,
                    Title = "ALLERGEN: Eggs",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 41,
                    Title = "ALLERGEN: Fish",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 42,
                    Title = "ALLERGEN: Lupin",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 43,
                    Title = "ALLERGEN: Milk",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 44,
                    Title = "ALLERGEN: Molluscs",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 45,
                    Title = "ALLERGEN: Mustard",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 46,
                    Title = "ALLERGEN: Nuts",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 47,
                    Title = "ALLERGEN: Peanuts",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 48,
                    Title = "ALLERGEN: Sesame seeds",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 49,
                    Title = "ALLERGEN: Soya",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 50,
                    Title = "ALLERGEN: Sulphur dioxide / Sulphites",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 51,
                    Title = "ALLERGEN: Non-regulated allergen reactions",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 53,
                    Title = "Biocontaminants",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 54,
                    Title = "Biotoxins (other)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 55,
                    Title = "Clandestine Detection",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 56,
                    Title = "CHEMET",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 57,
                    Title = "Chemical Contamination (other)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 58,
                    Title = "Composition",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 59,
                    Title = "Feed Additives",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 60,
                    Title = "Food Additives & Flavourings",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 61,
                    Title = "Foreign Bodies",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 62,
                    Title = "Heavy Metals",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 63,
                    Title = "Industrial Contaminants",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 64,
                    Title = "Labelling Absent / Incomplete / Incorrect",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 65,
                    Title = "Migration",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 66,
                    Title = "Mycotoxins",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 67,
                    Title = "Non-Pathogenic Micro-Organisims",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 68,
                    Title = "Not Determined / Other",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 69,
                    Title = "Novel Food",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 70,
                    Title = "Organoleptic Aspects",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 71,
                    Title = "Packaging Defective / Incorrect",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 72,
                    Title = "Parasitic Infestation",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 73,
                    Title = "Pathogenic Micro-Organisms",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 74,
                    Title = "Pesticide Residues",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 75,
                    Title = "Poor or Insufficient Controls",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 76,
                    Title = "Radiation",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 77,
                    Title = "Residues of Veterinary Medicinal Products",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new HazardGroupDb
                {
                    Id = 78,
                    Title = "TSE's",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                });


        }

        private void AdminLeads(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminLeadDb>()
                 .HasData(new AdminLeadDb
                 {
                     Id = 1,
                     Title = "Incidents Branch London",
                     CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                     ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                 }, new AdminLeadDb
                 {
                     Id = 2,
                     Title = "Incidents Branch Northern Ireland",
                     CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                     ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                 }, new AdminLeadDb
                 {
                     Id = 3,
                     Title = "Incidents Branch Wales",
                     CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                     ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                 }, new AdminLeadDb
                 {
                     Id = 4,
                     Title = "Incidents Food Standards Scotland",
                     CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                     ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                 }, new AdminLeadDb
                 {
                     Id = 5,
                     Title = "Undefined",
                     CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                     ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                 });


        }

        private void IncidentStatus(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IncidentStatusDb>()
                  .HasData(
                  new IncidentStatusDb
                  {
                      Id = 1,
                      Title = "Open",
                      SortOrder = 200,
                      CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                      ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                  }, new IncidentStatusDb
                  {
                      Id = 2,
                      Title = "Closed",
                      SortOrder = 100,
                      CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                      ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                  }, new IncidentStatusDb
                  {
                      Id = 4,
                      Title = "Unassigned",
                      SortOrder = 500,
                      CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                      ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                  });
        }

        private void StakeholderIncidentRoles(ModelBuilder modelBuilder) =>
            modelBuilder.Entity<StakeholderIncidentRoleDb>()
                .HasData(new StakeholderIncidentRoleDb
                {
                    Id = 1,
                    Title = "Briefing Cell",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 2,
                    Title = "Briefing Cell Manager",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 3,
                    Title = "Situation Report (SITREP) Lead",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 4,
                    Title = "Q&A lead",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 5,
                    Title = "Official Note Taker",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 6,
                    Title = "Communications Lead",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 7,
                    Title = "Press Officer",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 8,
                    Title = "Legal Advisior",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 9,
                    Title = "Admin Support",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 10,
                    Title = "Policy/Science Lead",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 11,
                    Title = "Ministerial Submission Lead",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 12,
                    Title = "FSS/FSA Liason",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 13,
                    Title = "Risk Manager",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 14,
                    Title = "Risk Assesor",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 15,
                    Title = "Incident Manager",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 16,
                    Title = "Incident Lead",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 17,
                    Title = "Incident Support",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 18,
                    Title = "Operational Incident Management Team (OIMT)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 19,
                    Title = "Incident Management Co-ordination Group (IMCG)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 20,
                    Title = "Chair, IMCG",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 21,
                    Title = "Policy Lead - FSA",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 22,
                    Title = "Policy Lead - Other Government Department",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 23,
                    Title = "Strategic Incident Oversight Group (SIOG)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 24,
                    Title = "Chair, SIOG",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 25,
                    Title = "Strategic Advisior",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 26,
                    Title = "Strategic Director",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 27,
                    Title = "Dairy Inspector",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 28,
                    Title = "Field Operations - FVC",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 29,
                    Title = "Field Operations - FVL",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 30,
                    Title = "FSA Business Assurance Auditors",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 31,
                    Title = "Meat Hygiene Inspector",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 32,
                    Title = "Poultry Hygiene Inspector",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 33,
                    Title = "Wine Inspector",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 34,
                    Title = "Receipt & Management  (RAM) Lead",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 35,
                    Title = "Stakeholder  Engagement  (SHE) Lead",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 36,
                    Title = "Receipt & Management (RAM ) Officer",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 37,
                    Title = "Stakeholder Engagement (SHE) Officer",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new StakeholderIncidentRoleDb
                {
                    Id = 38,
                    Title = "Undefined",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                });
    }
}
