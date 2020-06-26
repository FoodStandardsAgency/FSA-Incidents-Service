using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb
{
    public class Seeder
    {
        public void SeedLookups(ModelBuilder modelBuilder)
        {
            AdminLeads(modelBuilder);
            Categories(modelBuilder);
            Classifications(modelBuilder);
            ContactMethods(modelBuilder);
            Countries(modelBuilder);
            DataSource(modelBuilder);
            DeathIllness(modelBuilder);
            FBOType(modelBuilder);
            IncidentStatus(modelBuilder);
            NotifierType(modelBuilder);
            Priorities(modelBuilder);
            ProductDateDb(modelBuilder);
            ProductTypes(modelBuilder);
            SignalStatus(modelBuilder);
            UnitQuants(modelBuilder);
        }

        private void UnitQuants(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UnitQuantityDb>()
                .HasData(new UnitQuantityDb
                {
                    Id = 1,
                    Title = "Undefined",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new UnitQuantityDb
                {
                    Id = 2,
                    Title = "µg/kg",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new UnitQuantityDb
                {
                    Id = 3,
                    Title = "µSv",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new UnitQuantityDb
                {
                    Id = 4,
                    Title = "Bq/Kg",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new UnitQuantityDb
                {
                    Id = 5,
                    Title = "Bq/l",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new UnitQuantityDb
                {
                    Id = 6,
                    Title = "Bq/M2",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new UnitQuantityDb
                {
                    Id = 7,
                    Title = "Bq/M3",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new UnitQuantityDb
                {
                    Id = 8,
                    Title = "Gallons",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new UnitQuantityDb
                {
                    Id = 9,
                    Title = "Grams",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new UnitQuantityDb
                {
                    Id = 10,
                    Title = "kg",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new UnitQuantityDb
                {
                    Id = 11,
                    Title = "Litres",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new UnitQuantityDb
                {
                    Id = 12,
                    Title = "mg/kg",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new UnitQuantityDb
                {
                    Id = 13,
                    Title = "mg/litre",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new UnitQuantityDb
                {
                    Id = 14,
                    Title = "mSv",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new UnitQuantityDb
                {
                    Id = 15,
                    Title = "nSv",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new UnitQuantityDb
                {
                    Id = 16,
                    Title = "ppb",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new UnitQuantityDb
                {
                    Id = 17,
                    Title = "ppm",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new UnitQuantityDb
                {
                    Id = 18,
                    Title = "ppt",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new UnitQuantityDb
                {
                    Id = 19,
                    Title = "tonnes",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                });
        }

        private void SignalStatus(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SignalStatusDb>()
                .HasData(new SignalStatusDb
                {
                    Id = 1,
                    Title = "Unassigned",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new SignalStatusDb
                {
                    Id = 2,
                    Title = "Open",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new SignalStatusDb
                {
                    Id = 3,
                    Title = "Closed",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new SignalStatusDb
                {
                    Id = 4,
                    Title = "Duplicate",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new SignalStatusDb
                {
                    Id = 5,
                    Title = "Rejected",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new SignalStatusDb
                {
                    Id = 6,
                    Title = "Converted to Incident",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new SignalStatusDb
                {
                    Id = 7,
                    Title = "Associated to Incident",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new SignalStatusDb
                {
                    Id = 8,
                    Title = "Converted to Signal",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new SignalStatusDb
                {
                    Id = 9,
                    Title = "Associated to Signal",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new SignalStatusDb
                {
                    Id = 10,
                    Title = "Merged to Incident",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                });
        }

        private void ProductTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductTypeDb>()
                .HasData(new ProductTypeDb
                {
                    Id = 1,
                    Title = "Undefined",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
            new ProductTypeDb
            {
                Id = 2,
                Title = "Animal by-Products",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 3,
                Title = "Alcoholic Beverages",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 4,
                Title = "Bivalve Molluscs & Products Thereof",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 5,
                Title = "Cephalopods & Products Thereof",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 6,
                Title = "Cereals & Bakery Products",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 7,
                Title = "Cocoa / Cocoa Preparations / Coffee / Tea",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 8,
                Title = "Compound Feeds",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 9,
                Title = "Confectionery",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 10,
                Title = "Crustaceans & Products Thereof",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 11,
                Title = "Dietetic Foods / Food Supplements / Fortified Foods",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 12,
                Title = "Egg & Egg Products",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 13,
                Title = "Fats & Oils",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 14,
                Title = "Feed Additives",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 15,
                Title = "Feed Materials",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 16,
                Title = "Feed Premixtures",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 17,
                Title = "Fish & Fish Products",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 18,
                Title = "Food Additives & Flavourings",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 19,
                Title = "Food Contact Materials",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 20,
                Title = "Fruits & Vegetables",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 21,
                Title = "Gastropods",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 22,
                Title = "Herbs & Spices",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 23,
                Title = "Honey & Royal Jelly",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 24,
                Title = "Ices & Desserts",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 25,
                Title = "Meat & Meat Products (other than poultry)",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 26,
                Title = "Milk & Milk Products",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 27,
                Title = "N/A",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 28,
                Title = "Non-Alcoholic Beverages",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 29,
                Title = "Nuts / Nut Products / Seeds",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 30,
                Title = "Other Food Product / Mixed",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 31,
                Title = "Pet Food",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 32,
                Title = "Poultry Meat & Poultry Meat Products",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 33,
                Title = "Prepared Dishes & Snacks",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 34,
                Title = "Soups / Broths / Sauces & Condiments",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 35,
                Title = "Water",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 36,
                Title = "Wine",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            },
            new ProductTypeDb
            {
                Id = 37,
                Title = "Unmapped SPT Signal Value",
                CreatedBy = "Paul",
                ModifiedBy = "Paul"
            });
        }

        private void ProductDateDb(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DateTypeDb>()
                .HasData(new DateTypeDb
                {
                    Id = 1,
                    Title = "Use By Date",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                    new DateTypeDb
                    {
                        Id = 2,
                        Title = "Best before",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new DateTypeDb
                    {
                        Id = 3,
                        Title = "Best before End",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new DateTypeDb
                    {
                        Id = 4,
                        Title = "Display Until",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    });
        }

        private void Priorities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PriorityDb>()
         .HasData(new PriorityDb
         {
             Id = 1,
             Title = "Unclassified",
             CreatedBy = "Paul",
             ModifiedBy = "Paul"
         },
             new PriorityDb
             {
                 Id = 2,
                 Title = "Low",
                 CreatedBy = "Paul",
                 ModifiedBy = "Paul"
             },
             new PriorityDb
             {
                 Id = 3,
                 Title = "Medium",
                 CreatedBy = "Paul",
                 ModifiedBy = "Paul"
             },
             new PriorityDb
             {
                 Id = 4,
                 Title = "High",
                 CreatedBy = "Paul",
                 ModifiedBy = "Paul"
             });
        }

        private void FBOType(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FBOTypeDb>()
                .HasData(new FBOTypeDb
                {
                    Id = 1,
                    Title = "Consignor",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                    new FBOTypeDb
                    {
                        Id = 2,
                        Title = "e-platform/e-market place",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new FBOTypeDb
                    {
                        Id = 3,
                        Title = "e-trader",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new FBOTypeDb
                    {
                        Id = 4,
                        Title = "Exporter",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new FBOTypeDb
                    {
                        Id = 5,
                        Title = "Farmer",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new FBOTypeDb
                    {
                        Id = 6,
                        Title = "Hospitality/Food service",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new FBOTypeDb
                    {
                        Id = 7,
                        Title = "Importer",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new FBOTypeDb
                    {
                        Id = 8,
                        Title = "Manufacturer",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new FBOTypeDb
                    {
                        Id = 9,
                        Title = "Packer/filler",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new FBOTypeDb
                    {
                        Id = 10,
                        Title = "Processor",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new FBOTypeDb
                    {
                        Id = 11,
                        Title = "Producer",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new FBOTypeDb
                    {
                        Id = 12,
                        Title = "Retailer",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new FBOTypeDb
                    {
                        Id = 13,
                        Title = "Storage",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new FBOTypeDb
                    {
                        Id = 14,
                        Title = "Supplier",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new FBOTypeDb
                    {
                        Id = 15,
                        Title = "Trader/Broker",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new FBOTypeDb
                    {
                        Id = 16,
                        Title = "Transporter",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new FBOTypeDb
                    {
                        Id = 17,
                        Title = "Wholesaler",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    });
        }

        private void NotifierType(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NotifierTypeDb>()
                .HasData(new NotifierTypeDb
                {
                    Id = 1,
                    Title = "Public individual",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                    new NotifierTypeDb
                    {
                        Id = 2,
                        Title = "Local Authority",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new NotifierTypeDb
                    {
                        Id = 3,
                        Title = "Retailer",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    }, new NotifierTypeDb
                    {
                        Id = 4,
                        Title = "Manufacturer",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    });
        }

        private void DeathIllness(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeathIllnessDb>()
                .HasData(new DeathIllnessDb
                {
                    Id = 1,
                    Title = "Abdominal Pain",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                    new DeathIllnessDb
                    {
                        Id = 2,
                        Title = "Diarrhoea",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new DeathIllnessDb
                    {
                        Id = 3,
                        Title = "Vomiting",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    });
        }

        private void DataSource(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataSourceDb>()
                .HasData(new DataSourceDb
                {
                    Id = 1,
                    Title = "Web Form",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 2,
                    Title = "Administrative Assistance & Cooperation System (AAC)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 3,
                    Title = "Animal & Plant Health Agency (APHA)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 4,
                    Title = "Border Inspection Posts (BIPs)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 5,
                    Title = "Department of Agriculture & Rural Development (DARD)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 6,
                    Title = "Department of Health (DH)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 7,
                    Title = "Department for Environment Food & Rural Affairs (Defra)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 8,
                    Title = "Environment Agency (EA)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 9,
                    Title = "EU Member States",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 10,
                    Title = "European Commission (EC)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 11,
                    Title = "Fire Services",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 12,
                    Title = "Food Standards Scotland (FSS)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 13,
                    Title = "FSA Business Assurance Auditors",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 14,
                    Title = "FSA Dairy Inspector",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 15,
                    Title = "FSA England",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 16,
                    Title = "FSA Operations Group",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 17,
                    Title = "FSA Field Operations - FVL",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 18,
                    Title = "FSA Field Operations - FVC",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 19,
                    Title = "FSA Meat Hygiene Inspector",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 20,
                    Title = "FSA Northern Ireland (FSANI)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 21,
                    Title = "FSA Policy",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 22,
                    Title = "FSA Poultry Hygiene Inspector",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 23,
                    Title = "FSA RAM Referral",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 24,
                    Title = "FSA Survey",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 25,
                    Title = "FSA Wales (FSAW)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 26,
                    Title = "FSA Wine Inspector",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 27,
                    Title = "FSA Unannounced Inspector",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 28,
                    Title = "General Public",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 29,
                    Title = "Home Office / Border Force",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 30,
                    Title = "Health Protection Agency (HPA)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 31,
                    Title = "Health Protection Scotland (HPS)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 32,
                    Title = "Health & Safety Executive",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 33,
                    Title = "Industry",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 34,
                    Title = "INFOSAN",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 35,
                    Title = "Local Authority",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 36,
                    Title = "Marine Management Organisation (MMO)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 37,
                    Title = "Maritime & Costguard Agency (MCA)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 38,
                    Title = "Medicines & Healthcare products Regulatory Agency (MHRA)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 39,
                    Title = "Met Office",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 40,
                    Title = "National Crime Agency (NCA)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 41,
                    Title = "National Food Crime Unit (NFCU)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 42,
                    Title = "National Food Crime Unit (NFCU) - NFCU INTEL Report",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 43,
                    Title = "National Food Crime Unit (NFCU) - DIM Referral",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 44,
                    Title = "National Health Service (NHS)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 45,
                    Title = "Nuclear Power Station",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 46,
                    Title = "Other",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 47,
                    Title = "Police",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 48,
                    Title = "Port Health Authority (PHA)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 49,
                    Title = "Public Analyst / Laboratory",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 50,
                    Title = "Public Health England (PHE)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 51,
                    Title = "RASFF",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 52,
                    Title = "SAC (Scottish Agricultural College)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 53,
                    Title = "SOCA",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 54,
                    Title = "Third Country",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 55,
                    Title = "Water Company",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 56,
                    Title = "Veterinary Medicines Directorate",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                new DataSourceDb
                {
                    Id = 57,
                    Title = "Unmapped SPT Signal Value",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                });
        }

        private void Countries(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CountryDb>()
                .HasData(new CountryDb
                {
                    Id = 1,
                    Title = "Afganistan (AF)",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                    new CountryDb
                    {
                        Id = 2,
                        Title = "Aland Islands (AX)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 3,
                        Title = "Albania (AL)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 4,
                        Title = "Algeria (DZ)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 5,
                        Title = "America Samoa (AS)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 6,
                        Title = "Andorra (AD)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 7,
                        Title = "Angola (AO)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 8,
                        Title = "Anguilla (AI)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 9,
                        Title = "Antarctica (AQ)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 10,
                        Title = "Antigua & Barbuda (AG)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 11,
                        Title = "Argentina (AR)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 12,
                        Title = "Armenia (AM)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 13,
                        Title = "Aruba (AW)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 14,
                        Title = "Australia (AU)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 15,
                        Title = "Austria (AT)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 16,
                        Title = "Azerbaijan (AZ)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 17,
                        Title = "Bahamas (BS)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 18,
                        Title = "Bahrain (BH)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 19,
                        Title = "Bangladesh (BD)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 20,
                        Title = "Barbados (BB)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 21,
                        Title = "Belarus (BY)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 22,
                        Title = "Belgium (BE)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 23,
                        Title = "Belize (BZ)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 24,
                        Title = "Benin (BJ)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 25,
                        Title = "Bermuda (BM)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 26,
                        Title = "Bhutan (BT)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 27,
                        Title = "Bolivia (BO)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 28,
                        Title = "Bosnia & Herzegovina (BA)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 29,
                        Title = "Botswana (BW)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 30,
                        Title = "Bouvet Island (BV)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 31,
                        Title = "Brazil (BR)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 32,
                        Title = "British Indian Ocean Territory (IO)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 33,
                        Title = "Brunei Darussalam (BN)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 34,
                        Title = "Bulgaria (BG)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 35,
                        Title = "Burkina Faso (BF)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 36,
                        Title = "Burundi (BI)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 37,
                        Title = "Cambodia (KH)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 38,
                        Title = "Cameroon (CM)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 39,
                        Title = "Canada (CA)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 40,
                        Title = "Cape Verde (CV)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 41,
                        Title = "Cayman Islands (KY)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 42,
                        Title = "Central African Republic (CF)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 43,
                        Title = "Chad (TD)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 44,
                        Title = "Chile (CL)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 45,
                        Title = "China (CX)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 46,
                        Title = "Christmas Island (CX)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 47,
                        Title = "Cocos (Keeling) Islands (CC)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 48,
                        Title = "Columbia (CO)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 49,
                        Title = "Commission Services (CS)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 50,
                        Title = "Comoros (KM)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 51,
                        Title = "Congo The Democratic Rebulic of the (CD)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 52,
                        Title = "Congo-Brazzaville (CG)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 53,
                        Title = "Cook Islands (CK)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 54,
                        Title = "Costa Rica (CR)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 55,
                        Title = "Cote D`Ivoire (CI)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 56,
                        Title = "Country Not mentioned (NM)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 57,
                        Title = "Croatia (HR)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 58,
                        Title = "Cuba (CU)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 59,
                        Title = "Cyprus (CY)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 60,
                        Title = "Czech Republic (DO)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 61,
                        Title = "Denmark (DK)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 62,
                        Title = "Djibouti (DJ)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 63,
                        Title = "Dominica (DM)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 64,
                        Title = "Dominican Republic (DO)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 65,
                        Title = "Eathiopia (ET)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 66,
                        Title = "Ecuador (EC)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 67,
                        Title = "EFSA (FS)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 68,
                        Title = "El Salvador (SV)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 69,
                        Title = "Equatorial Guinea (GQ)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 70,
                        Title = "Eritrea (ER)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 71,
                        Title = "ESA (EF)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 72,
                        Title = "Estonia (EE)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 73,
                        Title = "Eygypt (EG)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 74,
                        Title = "Falkland Islands (Malvinas) (FK)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 75,
                        Title = "Faroe Islands (FO)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 76,
                        Title = "Fiji (FJ)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 77,
                        Title = "Finland (FI)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 78,
                        Title = "France (FR)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 79,
                        Title = "French Guiana (GF)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 80,
                        Title = "French Polynesia (PF)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 81,
                        Title = "French Southern Territories (TF)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 82,
                        Title = "Gabon (GA)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 83,
                        Title = "Gambia (GM)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 84,
                        Title = "Georgia (GE)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 85,
                        Title = "Germany (DE)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 86,
                        Title = "Ghana GH)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 87,
                        Title = "Gibraltar (GI)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 88,
                        Title = "Greece (GR)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 89,
                        Title = "Greenland (GL)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 90,
                        Title = "Grenada (GD)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 91,
                        Title = "Guadeloupe (GP)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 92,
                        Title = "Guam (GU)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 93,
                        Title = "Guatemala (GT)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 94,
                        Title = "Guernsey (GG)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 95,
                        Title = "Guinea-Bissau (GW)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 96,
                        Title = "Guyana (GY)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 97,
                        Title = "Haiti (HT)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 98,
                        Title = "Heatrd Island & McDonald Islands (HM)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 99,
                        Title = "Holy See (Vatican City State) (VA)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 100,
                        Title = "Honduras (HN)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 101,
                        Title = "Hong Kong (HK)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 102,
                        Title = "Hungary (HU)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 103,
                        Title = "Iceland (IS)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 104,
                        Title = "Ilse of Man (IM)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 105,
                        Title = "India (IN)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 106,
                        Title = "Indonesia (ID)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 107,
                        Title = "Iran Islamic Republic of (IR)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 108,
                        Title = "Iraq (IQ)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 109,
                        Title = "Ireland (IE)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 110,
                        Title = "Israel (IL)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 111,
                        Title = "Italy (IT)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 112,
                        Title = "Jamacia (JM)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 113,
                        Title = "Japan (JP)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 114,
                        Title = "Jersey (JE)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 115,
                        Title = "Jordan (JO)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 116,
                        Title = "Kiribati (KI)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 117,
                        Title = "Korea Democratic People`s Republic of (KP)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 118,
                        Title = "Korea Republic of (KR)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 119,
                        Title = "Kosovo Autonomous Region of (KS)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 120,
                        Title = "Kuwait (KW)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 121,
                        Title = "Kyrgyzstan (KG)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 122,
                        Title = "Lao People`s Democratic Republic (LA)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 123,
                        Title = "Latvia (LV)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 124,
                        Title = "Lebanon (LB)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 125,
                        Title = "Lesotho (LS)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 126,
                        Title = "Liberia (LR)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 127,
                        Title = "Libyan Arab Jamahirya (LY)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 128,
                        Title = "Liechtenstien (LI)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 129,
                        Title = "Lithuania (LT)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 130,
                        Title = "Luxembourg (LU)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 131,
                        Title = "Macao (MO)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 132,
                        Title = "Macedonia The Former Yugoslav Republic of (MK)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 133,
                        Title = "Madagascar (MG)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 134,
                        Title = "Malawi (MW)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 135,
                        Title = "Malaysia (MY)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 136,
                        Title = "Maldives (MV)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 137,
                        Title = "Mali (ML)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 138,
                        Title = "Malta (ML)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 139,
                        Title = "Marshall Islands (MH)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 140,
                        Title = "Martinique (MQ)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 141,
                        Title = "Mauritania (MR)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 142,
                        Title = "Mauritius (MU)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 143,
                        Title = "Mayotte (YT)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 144,
                        Title = "Mexico (MX)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 145,
                        Title = "Micronesia Federated States of (FM)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 146,
                        Title = "Moldova Republic of (MD)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 147,
                        Title = "Monaco (MC)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 148,
                        Title = "Mongolia (MN)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 149,
                        Title = "Montenegro (ME)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 150,
                        Title = "Montserrat (MS)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 151,
                        Title = "Morocco (MA)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 152,
                        Title = "Mozambique (MZ)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 153,
                        Title = "Myanimar (MM)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 154,
                        Title = "Nambia (NA)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 155,
                        Title = "Nauru (NR)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 156,
                        Title = "Nepal (NP)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 157,
                        Title = "Netherlands (NL)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 158,
                        Title = "Netherlands Antilles (AN)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 159,
                        Title = "New Caledonia (NC)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 160,
                        Title = "New Zealand (NZ)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 161,
                        Title = "Nicaragua ((NI)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 162,
                        Title = "Niger (NE)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 163,
                        Title = "Nigeria (NG)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 164,
                        Title = "Niue (NU)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 165,
                        Title = "Norfolk Island (NF)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 166,
                        Title = "Northern Mariana Islands (MP)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 167,
                        Title = "Norway (NO)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 168,
                        Title = "Oman (OM)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 169,
                        Title = "Pakistan (PK)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 170,
                        Title = "Palau (PW)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 171,
                        Title = "Palestinian Territory Occupied (PS)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 172,
                        Title = "Panama (PA)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 173,
                        Title = "Papua New Guinea (PG)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 174,
                        Title = "Paraguay (PY)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 175,
                        Title = "Peru (PE)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 176,
                        Title = "Philippines (PH)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 177,
                        Title = "Pitcairn (PN)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 178,
                        Title = "Poland (PL)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 179,
                        Title = "Portugal (PT)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 180,
                        Title = "Puerto Rico (PR)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 181,
                        Title = "Qatar (QA)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 182,
                        Title = "Reunion (RE)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 183,
                        Title = "Romania (RO)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 184,
                        Title = "Russian Federation (RU)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 185,
                        Title = "Rwanda (RO)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 186,
                        Title = "Saint Barthelemy (BL)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 187,
                        Title = "Saint Helena (SH)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 188,
                        Title = "Saint Kitts & Nevis (KN)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 189,
                        Title = "Saint Lucia (LC)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 190,
                        Title = "Saint Martin (MF)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 191,
                        Title = "Saint Pierre & Miquelon (PM)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 192,
                        Title = "Saint Vincent & the Grenadines (VC)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 193,
                        Title = "Samoa (WS)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 194,
                        Title = "San Marino (SM)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 195,
                        Title = "Sao Tome & Principe (ST)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 196,
                        Title = "Saudi Arabia (SA)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 197,
                        Title = "Senegal (SN)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 198,
                        Title = "Serbia (RS)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CountryDb
                    {
                        Id = 199,
                        Title = "Seychelles (SC)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    });
        }

        private void ContactMethods(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactMethodDb>()
                .HasData(new ContactMethodDb
                {
                    Id = 1,
                    Title = "Email",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                },
                    new ContactMethodDb
                    {
                        Id = 2,
                        Title = "Telephone",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new ContactMethodDb
                    {
                        Id = 3,
                        Title = "Fax",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new ContactMethodDb
                    {
                        Id = 4,
                        Title = "No Preference",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    });

        }

        private void Classifications(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassificationDb>()
                .HasData(new ClassificationDb
                {
                    Id = 1,
                    Title = "Routine",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                }, new ClassificationDb
                {
                    Id = 2,
                    Title = "Non-Routine",
                    CreatedBy = "Paul",
                    ModifiedBy = "Paul"
                });
        }

        private void Categories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryDb>()
                 .HasData(new CategoryDb
                 {
                     Id = 2,
                     Title = "Adulteration / Fraud",
                     CreatedBy = "Paul",
                     ModifiedBy = "Paul"
                 }, new CategoryDb
                 {
                     Id = 3,
                     Title = "ALLERGEN: Multiple Allergens",
                     CreatedBy = "Paul",
                     ModifiedBy = "Paul"
                 },
                    new CategoryDb
                    {
                        Id = 4,
                        Title = "ALLERGEN: Cereals containing gluten",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 5,
                        Title = "ALLERGEN: Celery",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 6,
                        Title = "ALLERGEN: Crustaceans",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 7,
                        Title = "ALLERGEN: Eggs",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 8,
                        Title = "ALLERGEN: Fish",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 9,
                        Title = "ALLERGEN: Lupin",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 10,
                        Title = "ALLERGEN: Milk",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 11,
                        Title = "ALLERGEN: Molluscs",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 12,
                        Title = "ALLERGEN: Mustard",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 13,
                        Title = "ALLERGEN: Nuts",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 14,
                        Title = "ALLERGEN: Peanuts",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 15,
                        Title = "ALLERGEN: Sesame seeds",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 16,
                        Title = "ALLERGEN: Soya",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 17,
                        Title = "ALLERGEN: Sulphur dioxide / Sulphites",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 18,
                        Title = "ALLERGEN: Non-regulated allergen reactions",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 19,
                        Title = "Allergens",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 20,
                        Title = "Biocontaminants",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 21,
                        Title = "Biotoxins (other)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 22,
                        Title = "Clandestine Detection",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 23,
                        Title = "CHEMET",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 24,
                        Title = "Chemical Contamination (other)",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 25,
                        Title = "Composition",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 26,
                        Title = "Feed Additives",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 27,
                        Title = "Food Additives & Flavourings",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 28,
                        Title = "Foreign Bodies",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 29,
                        Title = "Heavy Metals",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 30,
                        Title = "Industrial Contaminants",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 31,
                        Title = "Labelling Absent / Incomplete / Incorrect",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 32,
                        Title = "Migration",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 33,
                        Title = "Mycotoxins",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 34,
                        Title = "Non-Pathogenic Micro-Organisims",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 35,
                        Title = "Not Determined / Other",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 36,
                        Title = "Novel Food",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 37,
                        Title = "Organoleptic Aspects",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 38,
                        Title = "Packaging Defective / Incorrect",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 39,
                        Title = "Parasitic Infestation",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 40,
                        Title = "Pathogenic Micro-Organisms",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 41,
                        Title = "Pesticide Residues",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 42,
                        Title = "Poor or Insufficient Controls",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 43,
                        Title = "Radiation",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 44,
                        Title = "Residues of Veterinary Medicinal Products",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 45,
                        Title = "TSE`s",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 46,
                        Title = "Undefined",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    },
                    new CategoryDb
                    {
                        Id = 47,
                        Title = "Unmapped SPT Signal Value",
                        CreatedBy = "Paul",
                        ModifiedBy = "Paul"
                    });
        }

        private void AdminLeads(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminLeadDb>()
                 .HasData(new AdminLeadDb
                 {
                     Id = 1,
                     Title = "Incidents Branch London",
                     CreatedBy = "Paul",
                     ModifiedBy = "Paul"
                 }, new AdminLeadDb
                 {
                     Id = 2,
                     Title = "Incidents Branch Northern Ireland",
                     CreatedBy = "Paul",
                     ModifiedBy = "Paul"
                 }, new AdminLeadDb
                 {
                     Id = 3,
                     Title = "Incidents Branch Wales",
                     CreatedBy = "Paul",
                     ModifiedBy = "Paul"
                 }, new AdminLeadDb
                 {
                     Id = 4,
                     Title = "Incidents Food Standards Scotland",
                     CreatedBy = "Paul",
                     ModifiedBy = "Paul"
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
                      CreatedBy = "Paul",
                      ModifiedBy = "Paul"
                  }, new IncidentStatusDb
                  {
                      Id = 2,
                      Title = "Closed",
                      CreatedBy = "Paul",
                      ModifiedBy = "Paul"
                  }, new IncidentStatusDb
                  {
                      Id = 3,
                      Title = "No wait!",
                      CreatedBy = "Paul",
                      ModifiedBy = "Paul"
                  });
        }
    }
}
