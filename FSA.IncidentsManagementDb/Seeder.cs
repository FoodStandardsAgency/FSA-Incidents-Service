using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
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
            DocumentTag(modelBuilder);
            StakeholderDiscrimatior(modelBuilder);
            StakeholderIncidentRoles(modelBuilder);
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
                    Id = 2,
                    Title = "µg/kg",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 3,
                    Title = "µSv",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 4,
                    Title = "Bq/Kg",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 5,
                    Title = "Bq/l",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 6,
                    Title = "Bq/M2",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 7,
                    Title = "Bq/M3",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 8,
                    Title = "Gallons",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 9,
                    Title = "Grams",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 10,
                    Title = "kg",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 11,
                    Title = "Litres",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 12,
                    Title = "mg/kg",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 13,
                    Title = "mg/litre",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 14,
                    Title = "mSv",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 15,
                    Title = "nSv",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 16,
                    Title = "ppb",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 17,
                    Title = "ppm",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 18,
                    Title = "ppt",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 19,
                    Title = "tonnes",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                });
        }

        private void SignalStatus(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SignalStatusDb>()
                .HasData(new SignalStatusDb
                {
                    Id = 1,
                    Title = "Unassigned",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new SignalStatusDb
                {
                    Id = 2,
                    Title = "Open",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new SignalStatusDb
                {
                    Id = 3,
                    Title = "Closed",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new SignalStatusDb
                {
                    Id = 4,
                    Title = "Duplicate",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new SignalStatusDb
                {
                    Id = 5,
                    Title = "Rejected",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new SignalStatusDb
                {
                    Id = 6,
                    Title = "Converted to Incident",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new SignalStatusDb
                {
                    Id = 7,
                    Title = "Associated to Incident",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new SignalStatusDb
                {
                    Id = 8,
                    Title = "Converted to Signal",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new SignalStatusDb
                {
                    Id = 9,
                    Title = "Associated to Signal",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new SignalStatusDb
                {
                    Id = 10,
                    Title = "Merged to Incident",
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
                   Title = "FSA",
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
                   Title = "FBO/FeBO",
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
                    Title = "Public individual",
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
                    Title = "Retailer",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                }, new NotifierTypeDb
                {
                    Id = 4,
                    Title = "Manufacturer",
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
                    Id = 1,
                    Title = "Web Form",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new DataSourceDb
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
                    Title = "Department of Agriculture & Rural Development (DARD)",
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
                });
        }

        private void Countries(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CountryDb>()
                .HasData(new CountryDb
                {
                    Id = 1,
                    Title = "Georgia",
                    KeyField = "GE",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },

                    new CountryDb
                    {
                        Id = 2,
                        Title = "French Guiana",
                        KeyField = "GF",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 3,
                        Title = "Guernsey",
                        KeyField = "GG",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 4,
                        Title = "Ghana",
                        KeyField = "GH",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 5,
                        Title = "Gibraltar",
                        KeyField = "GI",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 6,
                        Title = "Greenland",
                        KeyField = "GL",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 7,
                        Title = "The Gambia",
                        KeyField = "GM",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 8,
                        Title = "Guinea",
                        KeyField = "GN",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 9,
                        Title = "Guadeloupe",
                        KeyField = "GP",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 10,
                        Title = "Equatorial Guinea",
                        KeyField = "GQ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 11,
                        Title = "Greece",
                        KeyField = "GR",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 12,
                        Title = "South Georgia and South Sandwich Islands",
                        KeyField = "GS",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 13,
                        Title = "Guatemala",
                        KeyField = "GT",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 14,
                        Title = "Guam",
                        KeyField = "GU",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 15,
                        Title = "Guinea-Bissau",
                        KeyField = "GW",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 16,
                        Title = "Guyana",
                        KeyField = "GY",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 17,
                        Title = "Hong Kong",
                        KeyField = "HK",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 18,
                        Title = "Heard Island and McDonald Islands",
                        KeyField = "HM",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 19,
                        Title = "Honduras",
                        KeyField = "HN",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 20,
                        Title = "Croatia",
                        KeyField = "HR",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 21,
                        Title = "Haiti",
                        KeyField = "HT",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 22,
                        Title = "Hungary",
                        KeyField = "HU",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 23,
                        Title = "Indonesia",
                        KeyField = "ID",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 24,
                        Title = "Ireland",
                        KeyField = "IE",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 25,
                        Title = "Israel",
                        KeyField = "IL",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 26,
                        Title = "Isle of Man",
                        KeyField = "IM",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 27,
                        Title = "India",
                        KeyField = "IN",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 28,
                        Title = "British Indian Ocean Territory",
                        KeyField = "IO",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 29,
                        Title = "Iraq",
                        KeyField = "IQ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 30,
                        Title = "Iran",
                        KeyField = "IR",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 31,
                        Title = "Andorra",
                        KeyField = "AD",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 32,
                        Title = "United Arab Emirates",
                        KeyField = "AE",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 33,
                        Title = "Ajman",
                        KeyField = "AE-AJ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 34,
                        Title = "Abu Dhabi",
                        KeyField = "AE-AZ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 35,
                        Title = "Dubai",
                        KeyField = "AE-DU",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 36,
                        Title = "Fujairah",
                        KeyField = "AE-FU",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 37,
                        Title = "Ras al-Khaimah",
                        KeyField = "AE-RK",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 38,
                        Title = "Sharjah",
                        KeyField = "AE-SH",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 39,
                        Title = "Umm al-Quwain",
                        KeyField = "AE-UQ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 40,
                        Title = "Afghanistan",
                        KeyField = "AF",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 41,
                        Title = "Antigua and Barbuda",
                        KeyField = "AG",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 42,
                        Title = "Anguilla",
                        KeyField = "AI",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 43,
                        Title = "Albania",
                        KeyField = "AL",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 44,
                        Title = "Armenia",
                        KeyField = "AM",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 45,
                        Title = "Angola",
                        KeyField = "AO",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 46,
                        Title = "Antarctica",
                        KeyField = "AQ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 47,
                        Title = "Argentina",
                        KeyField = "AR",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 48,
                        Title = "American Samoa",
                        KeyField = "AS",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 49,
                        Title = "Austria",
                        KeyField = "AT",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 50,
                        Title = "Australia",
                        KeyField = "AU",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 51,
                        Title = "Aruba",
                        KeyField = "AW",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 52,
                        Title = "Aland Islands",
                        KeyField = "AX",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 53,
                        Title = "Azerbaijan",
                        KeyField = "AZ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 54,
                        Title = "Bosnia and Herzegovina",
                        KeyField = "BA",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 55,
                        Title = "British Antarctic Territory",
                        KeyField = "BAT",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 56,
                        Title = "Barbados",
                        KeyField = "BB",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 57,
                        Title = "Bangladesh",
                        KeyField = "BD",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 58,
                        Title = "Belgium",
                        KeyField = "BE",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 59,
                        Title = "Burkina Faso",
                        KeyField = "BF",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 60,
                        Title = "Bulgaria",
                        KeyField = "BG",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 61,
                        Title = "Bahrain",
                        KeyField = "BH",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 62,
                        Title = "Burundi",
                        KeyField = "BI",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 63,
                        Title = "Benin",
                        KeyField = "BJ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 64,
                        Title = "Saint Barthelemy",
                        KeyField = "BL",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 65,
                        Title = "Bermuda",
                        KeyField = "BM",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 66,
                        Title = "Brunei",
                        KeyField = "BN",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 67,
                        Title = "Bolivia",
                        KeyField = "BO",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 68,
                        Title = "Bonaire",
                        KeyField = "BQ-BO",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 69,
                        Title = "Saba",
                        KeyField = "BQ-SA",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 70,
                        Title = "Sint Eustatius",
                        KeyField = "BQ-SE",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 71,
                        Title = "Brazil",
                        KeyField = "BR",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 72,
                        Title = "The Bahamas",
                        KeyField = "BS",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 73,
                        Title = "Bhutan",
                        KeyField = "BT",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 74,
                        Title = "Bouvet Island",
                        KeyField = "BV",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 75,
                        Title = "Botswana",
                        KeyField = "BW",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 76,
                        Title = "Belarus",
                        KeyField = "BY",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 77,
                        Title = "Belize",
                        KeyField = "BZ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 78,
                        Title = "Canada",
                        KeyField = "CA",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 79,
                        Title = "Cocos (Keeling) Islands",
                        KeyField = "CC",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 80,
                        Title = "Congo (Democratic Republic)",
                        KeyField = "CD",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 81,
                        Title = "Central African Republic",
                        KeyField = "CF",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 82,
                        Title = "Congo",
                        KeyField = "CG",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 83,
                        Title = "Switzerland",
                        KeyField = "CH",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 84,
                        Title = "Ivory Coast",
                        KeyField = "CI",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 85,
                        Title = "Cook Islands",
                        KeyField = "CK",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 86,
                        Title = "Chile",
                        KeyField = "CL",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 87,
                        Title = "Cameroon",
                        KeyField = "CM",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 88,
                        Title = "China",
                        KeyField = "CN",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 89,
                        Title = "Colombia",
                        KeyField = "CO",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 90,
                        Title = "Costa Rica",
                        KeyField = "CR",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 91,
                        Title = "Cuba",
                        KeyField = "CU",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 92,
                        Title = "Cape Verde",
                        KeyField = "CV",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 93,
                        Title = "Curacao",
                        KeyField = "CW",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 94,
                        Title = "Christmas Island",
                        KeyField = "CX",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 95,
                        Title = "Cyprus",
                        KeyField = "CY",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 96,
                        Title = "Czechia",
                        KeyField = "CZ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 97,
                        Title = "Germany",
                        KeyField = "DE",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 98,
                        Title = "Djibouti",
                        KeyField = "DJ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 99,
                        Title = "Denmark",
                        KeyField = "DK",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 100,
                        Title = "Dominica",
                        KeyField = "DM",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 101,
                        Title = "Dominican Republic",
                        KeyField = "DO",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 102,
                        Title = "Algeria",
                        KeyField = "DZ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 103,
                        Title = "Ecuador",
                        KeyField = "EC",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 104,
                        Title = "Estonia",
                        KeyField = "EE",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 105,
                        Title = "Egypt",
                        KeyField = "EG",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 106,
                        Title = "Western Sahara",
                        KeyField = "EH",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 107,
                        Title = "Eritrea",
                        KeyField = "ER",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 108,
                        Title = "Spain",
                        KeyField = "ES",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 109,
                        Title = "Ceuta",
                        KeyField = "ES-CE",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 110,
                        Title = "Melilla",
                        KeyField = "ES-ML",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 111,
                        Title = "Ethiopia",
                        KeyField = "ET",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 112,
                        Title = "European Union",
                        KeyField = "EU",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 113,
                        Title = "Finland",
                        KeyField = "FI",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 114,
                        Title = "Fiji",
                        KeyField = "FJ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 115,
                        Title = "Falkland Islands",
                        KeyField = "FK",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 116,
                        Title = "Micronesia",
                        KeyField = "FM",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 117,
                        Title = "Faroe Islands",
                        KeyField = "FO",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 118,
                        Title = "France",
                        KeyField = "FR",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 119,
                        Title = "Gabon",
                        KeyField = "GA",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 120,
                        Title = "United Kingdom",
                        KeyField = "GB",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 121,
                        Title = "England",
                        KeyField = "GB-ENG",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 122,
                        Title = "Northern Ireland",
                        KeyField = "GB-NIR",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 123,
                        Title = "Scotland",
                        KeyField = "GB-SCT",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 124,
                        Title = "Wales",
                        KeyField = "GB-WLS",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 125,
                        Title = "Grenada",
                        KeyField = "GD",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 126,
                        Title = "Georgia",
                        KeyField = "GE",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 127,
                        Title = "French Guiana",
                        KeyField = "GF",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 128,
                        Title = "Guernsey",
                        KeyField = "GG",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 129,
                        Title = "Ghana",
                        KeyField = "GH",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 130,
                        Title = "Gibraltar",
                        KeyField = "GI",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 131,
                        Title = "Greenland",
                        KeyField = "GL",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 132,
                        Title = "The Gambia",
                        KeyField = "GM",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 133,
                        Title = "Guinea",
                        KeyField = "GN",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 134,
                        Title = "Guadeloupe",
                        KeyField = "GP",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 135,
                        Title = "Equatorial Guinea",
                        KeyField = "GQ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 136,
                        Title = "Greece",
                        KeyField = "GR",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 137,
                        Title = "South Georgia and South Sandwich Islands",
                        KeyField = "GS",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 138,
                        Title = "Guatemala",
                        KeyField = "GT",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 139,
                        Title = "Guam",
                        KeyField = "GU",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 140,
                        Title = "Guinea-Bissau",
                        KeyField = "GW",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 141,
                        Title = "Guyana",
                        KeyField = "GY",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 142,
                        Title = "Hong Kong",
                        KeyField = "HK",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 143,
                        Title = "Heard Island and McDonald Islands",
                        KeyField = "HM",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 144,
                        Title = "Honduras",
                        KeyField = "HN",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 145,
                        Title = "Croatia",
                        KeyField = "HR",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 146,
                        Title = "Haiti",
                        KeyField = "HT",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 147,
                        Title = "Hungary",
                        KeyField = "HU",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 148,
                        Title = "Indonesia",
                        KeyField = "ID",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 149,
                        Title = "Ireland",
                        KeyField = "IE",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 150,
                        Title = "Israel",
                        KeyField = "IL",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 151,
                        Title = "Isle of Man",
                        KeyField = "IM",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 152,
                        Title = "India",
                        KeyField = "IN",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 153,
                        Title = "British Indian Ocean Territory",
                        KeyField = "IO",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 154,
                        Title = "Iraq",
                        KeyField = "IQ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 155,
                        Title = "Iran",
                        KeyField = "IR",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 156,
                        Title = "Iceland",
                        KeyField = "IS",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 157,
                        Title = "Italy",
                        KeyField = "IT",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 158,
                        Title = "Jersey",
                        KeyField = "JE",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 159,
                        Title = "Jamaica",
                        KeyField = "JM",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 160,
                        Title = "Jordan",
                        KeyField = "JO",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 161,
                        Title = "Japan",
                        KeyField = "JP",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 162,
                        Title = "Kenya",
                        KeyField = "KE",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 163,
                        Title = "Kyrgyzstan",
                        KeyField = "KG",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 164,
                        Title = "Cambodia",
                        KeyField = "KH",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 165,
                        Title = "Kiribati",
                        KeyField = "KI",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 166,
                        Title = "Comoros",
                        KeyField = "KM",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 167,
                        Title = "St Kitts and Nevis",
                        KeyField = "KN",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 168,
                        Title = "North Korea",
                        KeyField = "KP",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 169,
                        Title = "South Korea",
                        KeyField = "KR",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 170,
                        Title = "Kuwait",
                        KeyField = "KW",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 171,
                        Title = "Cayman Islands",
                        KeyField = "KY",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 172,
                        Title = "Kazakhstan",
                        KeyField = "KZ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 173,
                        Title = "Laos",
                        KeyField = "LA",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 174,
                        Title = "Lebanon",
                        KeyField = "LB",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 175,
                        Title = "St Lucia",
                        KeyField = "LC",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 176,
                        Title = "Liechtenstein",
                        KeyField = "LI",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 177,
                        Title = "Sri Lanka",
                        KeyField = "LK",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 178,
                        Title = "Liberia",
                        KeyField = "LR",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 179,
                        Title = "Lesotho",
                        KeyField = "LS",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 180,
                        Title = "Lithuania",
                        KeyField = "LT",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 181,
                        Title = "Luxembourg",
                        KeyField = "LU",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 182,
                        Title = "Latvia",
                        KeyField = "LV",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 183,
                        Title = "Libya",
                        KeyField = "LY",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 184,
                        Title = "Morocco",
                        KeyField = "MA",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 185,
                        Title = "Monaco",
                        KeyField = "MC",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 186,
                        Title = "Moldova",
                        KeyField = "MD",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 187,
                        Title = "Montenegro",
                        KeyField = "ME",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 188,
                        Title = "Saint-Martin (French part)",
                        KeyField = "MF",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 189,
                        Title = "Madagascar",
                        KeyField = "MG",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 190,
                        Title = "Marshall Islands",
                        KeyField = "MH",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 191,
                        Title = "Macedonia",
                        KeyField = "MK",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 192,
                        Title = "Mali",
                        KeyField = "ML",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 193,
                        Title = "Burma",
                        KeyField = "MM",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 194,
                        Title = "Mongolia",
                        KeyField = "MN",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 195,
                        Title = "Macao",
                        KeyField = "MO",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 196,
                        Title = "Northern Mariana Islands",
                        KeyField = "MP",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 197,
                        Title = "Martinique",
                        KeyField = "MQ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 198,
                        Title = "Mauritania",
                        KeyField = "MR",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 199,
                        Title = "Montserrat",
                        KeyField = "MS",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 200,
                        Title = "Malta",
                        KeyField = "MT",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 201,
                        Title = "Mauritius",
                        KeyField = "MU",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 202,
                        Title = "Maldives",
                        KeyField = "MV",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 203,
                        Title = "Malawi",
                        KeyField = "MW",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 204,
                        Title = "Mexico",
                        KeyField = "MX",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 205,
                        Title = "Malaysia",
                        KeyField = "MY",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 206,
                        Title = "Mozambique",
                        KeyField = "MZ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 207,
                        Title = "Namibia",
                        KeyField = "NA",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 208,
                        Title = "New Caledonia",
                        KeyField = "NC",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 209,
                        Title = "Niger",
                        KeyField = "NE",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 210,
                        Title = "Norfolk Island",
                        KeyField = "NF",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 211,
                        Title = "Nigeria",
                        KeyField = "NG",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 212,
                        Title = "Nicaragua",
                        KeyField = "NI",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 213,
                        Title = "Netherlands",
                        KeyField = "NL",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 214,
                        Title = "Norway",
                        KeyField = "NO",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 215,
                        Title = "Nepal",
                        KeyField = "NP",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 216,
                        Title = "Nauru",
                        KeyField = "NR",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 217,
                        Title = "Niue",
                        KeyField = "NU",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 218,
                        Title = "New Zealand",
                        KeyField = "NZ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 219,
                        Title = "Oman",
                        KeyField = "OM",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 220,
                        Title = "Panama",
                        KeyField = "PA",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 221,
                        Title = "Peru",
                        KeyField = "PE",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 222,
                        Title = "French Polynesia",
                        KeyField = "PF",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 223,
                        Title = "Papua New Guinea",
                        KeyField = "PG",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 224,
                        Title = "Philippines",
                        KeyField = "PH",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 225,
                        Title = "Pakistan",
                        KeyField = "PK",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 226,
                        Title = "Poland",
                        KeyField = "PL",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 227,
                        Title = "Saint Pierre and Miquelon",
                        KeyField = "PM",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 228,
                        Title = "Pitcairn, Henderson, Ducie and Oeno Islands",
                        KeyField = "PN",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 229,
                        Title = "Puerto Rico",
                        KeyField = "PR",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 230,
                        Title = "Occupied Palestinian Territories",
                        KeyField = "PS",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 231,
                        Title = "Portugal",
                        KeyField = "PT",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 232,
                        Title = "Palau",
                        KeyField = "PW",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 233,
                        Title = "Paraguay",
                        KeyField = "PY",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 234,
                        Title = "Qatar",
                        KeyField = "QA",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 235,
                        Title = "Reunion",
                        KeyField = "RE",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 236,
                        Title = "Romania",
                        KeyField = "RO",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 237,
                        Title = "Serbia",
                        KeyField = "RS",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 238,
                        Title = "Russia",
                        KeyField = "RU",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 239,
                        Title = "Rwanda",
                        KeyField = "RW",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 240,
                        Title = "Saudi Arabia",
                        KeyField = "SA",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 241,
                        Title = "Solomon Islands",
                        KeyField = "SB",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 242,
                        Title = "Seychelles",
                        KeyField = "SC",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 243,
                        Title = "Sudan",
                        KeyField = "SD",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 244,
                        Title = "Sweden",
                        KeyField = "SE",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 245,
                        Title = "Singapore",
                        KeyField = "SG",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 246,
                        Title = "Ascension",
                        KeyField = "SH-AC",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 247,
                        Title = "Saint Helena",
                        KeyField = "SH-HL",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 248,
                        Title = "Tristan da Cunha",
                        KeyField = "SH-TA",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 249,
                        Title = "Slovenia",
                        KeyField = "SI",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 250,
                        Title = "Svalbard and Jan Mayen",
                        KeyField = "SJ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 251,
                        Title = "Slovakia",
                        KeyField = "SK",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 252,
                        Title = "Sierra Leone",
                        KeyField = "SL",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 253,
                        Title = "San Marino",
                        KeyField = "SM",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 254,
                        Title = "Senegal",
                        KeyField = "SN",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 255,
                        Title = "Somalia",
                        KeyField = "SO",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 256,
                        Title = "Suriname",
                        KeyField = "SR",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 257,
                        Title = "South Sudan",
                        KeyField = "SS",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 258,
                        Title = "Sao Tome and Principe",
                        KeyField = "ST",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 259,
                        Title = "El Salvador",
                        KeyField = "SV",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 260,
                        Title = "Sint Maarten (Dutch part)",
                        KeyField = "SX",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 261,
                        Title = "Syria",
                        KeyField = "SY",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 262,
                        Title = "Swaziland",
                        KeyField = "SZ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 263,
                        Title = "Turks and Caicos Islands",
                        KeyField = "TC",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 264,
                        Title = "Chad",
                        KeyField = "TD",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 265,
                        Title = "French Southern Territories",
                        KeyField = "TF",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 266,
                        Title = "Togo",
                        KeyField = "TG",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 267,
                        Title = "Thailand",
                        KeyField = "TH",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 268,
                        Title = "Tajikistan",
                        KeyField = "TJ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 269,
                        Title = "Tokelau",
                        KeyField = "TK",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 270,
                        Title = "East Timor",
                        KeyField = "TL",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 271,
                        Title = "Turkmenistan",
                        KeyField = "TM",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 272,
                        Title = "Tunisia",
                        KeyField = "TN",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 273,
                        Title = "Tonga",
                        KeyField = "TO",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 274,
                        Title = "Turkey",
                        KeyField = "TR",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 275,
                        Title = "Trinidad and Tobago",
                        KeyField = "TT",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 276,
                        Title = "Tuvalu",
                        KeyField = "TV",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 277,
                        Title = "Taiwan",
                        KeyField = "TW",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 278,
                        Title = "Tanzania",
                        KeyField = "TZ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 279,
                        Title = "Ukraine",
                        KeyField = "UA",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 280,
                        Title = "Uganda",
                        KeyField = "UG",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 281,
                        Title = "Johnston Atoll",
                        KeyField = "UM-67",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 282,
                        Title = "Midway Islands",
                        KeyField = "UM-71",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 283,
                        Title = "Navassa Island",
                        KeyField = "UM-76",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 284,
                        Title = "Wake Island",
                        KeyField = "UM-79",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 285,
                        Title = "Baker Island",
                        KeyField = "UM-81",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 286,
                        Title = "Howland Island",
                        KeyField = "UM-84",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 287,
                        Title = "Jarvis Island",
                        KeyField = "UM-86",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 288,
                        Title = "Kingman Reef",
                        KeyField = "UM-89",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 289,
                        Title = "Palmyra Atoll",
                        KeyField = "UM-95",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 290,
                        Title = "United States",
                        KeyField = "US",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 291,
                        Title = "Uruguay",
                        KeyField = "UY",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 292,
                        Title = "Uzbekistan",
                        KeyField = "UZ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 293,
                        Title = "Vatican City",
                        KeyField = "VA",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 294,
                        Title = "St Vincent",
                        KeyField = "VC",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 295,
                        Title = "Venezuela",
                        KeyField = "VE",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 296,
                        Title = "British Virgin Islands",
                        KeyField = "VG",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 297,
                        Title = "United States Virgin Islands",
                        KeyField = "VI",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 298,
                        Title = "Vietnam",
                        KeyField = "VN",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 299,
                        Title = "Vanuatu",
                        KeyField = "VU",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 300,
                        Title = "Wallis and Futuna",
                        KeyField = "WF",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 301,
                        Title = "Samoa",
                        KeyField = "WS",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 302,
                        Title = "Kosovo",
                        KeyField = "XK",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 303,
                        Title = "Akrotiri",
                        KeyField = "XQZ",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 304,
                        Title = "Dhekelia",
                        KeyField = "XXD",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 305,
                        Title = "Yemen",
                        KeyField = "YE",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 306,
                        Title = "Mayotte",
                        KeyField = "YT",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 307,
                        Title = "South Africa",
                        KeyField = "ZA",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 308,
                        Title = "Zambia",
                        KeyField = "ZM",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 309,
                        Title = "Zimbabwe",
                        KeyField = "ZW",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 310,
                        Title = "Country",
                        KeyField = "country",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 311,
                        Title = "non-EU",
                        KeyField = "non-EU",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 312,
                        Title = "Not Easily Identified",
                        KeyField = "not-easily-identified",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 313,
                        Title = "Other",
                        KeyField = "other",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },

                    new CountryDb
                    {
                        Id = 314,
                        Title = "Territory",
                        KeyField = "territory",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
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
                    Id = 4,
                    Title = "No Preference",
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
                });
        }

        private void Categories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryDb>()
                 .HasData(new CategoryDb
                 {
                     Id = 1,
                     Title = "Adulteration / Fraud",
                     CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                     ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                 }, new CategoryDb
                 {
                     Id = 2,
                     Title = "ALLERGEN: Multiple Allergens",
                     CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                     ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                 },
                    new CategoryDb
                    {
                        Id = 3,
                        Title = "ALLERGEN: Cereals containing gluten",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 4,
                        Title = "ALLERGEN: Celery",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 5,
                        Title = "ALLERGEN: Crustaceans",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 6,
                        Title = "ALLERGEN: Eggs",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 7,
                        Title = "ALLERGEN: Fish",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 8,
                        Title = "ALLERGEN: Lupin",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 9,
                        Title = "ALLERGEN: Milk",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 10,
                        Title = "ALLERGEN: Molluscs",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 11,
                        Title = "ALLERGEN: Mustard",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 12,
                        Title = "ALLERGEN: Nuts",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 13,
                        Title = "ALLERGEN: Peanuts",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 14,
                        Title = "ALLERGEN: Sesame seeds",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 15,
                        Title = "ALLERGEN: Soya",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 16,
                        Title = "ALLERGEN: Sulphur dioxide / Sulphites",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 17,
                        Title = "ALLERGEN: Non-regulated allergen reactions",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 18,
                        Title = "Allergens",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 19,
                        Title = "Biocontaminants",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 20,
                        Title = "Biotoxins (other)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 21,
                        Title = "Clandestine Detection",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 22,
                        Title = "CHEMET",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 23,
                        Title = "Chemical Contamination (other)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 24,
                        Title = "Composition",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 25,
                        Title = "Feed Additives",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 26,
                        Title = "Food Additives & Flavourings",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 27,
                        Title = "Foreign Bodies",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 28,
                        Title = "Heavy Metals",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 29,
                        Title = "Industrial Contaminants",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 30,
                        Title = "Labelling Absent / Incomplete / Incorrect",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 31,
                        Title = "Migration",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 32,
                        Title = "Mycotoxins",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 33,
                        Title = "Non-Pathogenic Micro-Organisims",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 34,
                        Title = "Not Determined / Other",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 35,
                        Title = "Novel Food",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 36,
                        Title = "Organoleptic Aspects",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 37,
                        Title = "Packaging Defective / Incorrect",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 38,
                        Title = "Parasitic Infestation",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 39,
                        Title = "Pathogenic Micro-Organisms",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 40,
                        Title = "Pesticide Residues",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 41,
                        Title = "Poor or Insufficient Controls",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 42,
                        Title = "Radiation",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 43,
                        Title = "Residues of Veterinary Medicinal Products",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 44,
                        Title = "TSE`s",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 45,
                        Title = "Undefined",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CategoryDb
                    {
                        Id = 46,
                        Title = "Unmapped SPT Signal Value",
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
                .HasData(new UnitQuantityDb
                {
                    Id = 1,
                    Title = "Briefing Cell",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 2,
                    Title = "Briefing Cell Manager",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 3,
                    Title = "Situation Report (SITREP) Lead",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 4,
                    Title = "Q&A lead",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 5,
                    Title = "Official Note Taker",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 6,
                    Title = "Communications Lead",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 7,
                    Title = "Press Officer",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 8,
                    Title = "Legal Advisior",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 9,
                    Title = "Admin Support",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 10,
                    Title = "Policy/Science Lead",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 11,
                    Title = "Ministerial Submission Lead",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 12,
                    Title = "FSS/FSA Liason",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 13,
                    Title = "Risk Manager",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 14,
                    Title = "Risk Assesor",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 15,
                    Title = "Incident Manager",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 16,
                    Title = "Incident Lead?",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 17,
                    Title = "Incident Support?",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 18,
                    Title = "Operational Incident Management Team (OIMT)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 19,
                    Title = "Incident Management Co-ordination Group (IMCG)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 20,
                    Title = "Chair, IMCG",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 21,
                    Title = "Policy Lead - FSA",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 22,
                    Title = "Policy Lead - Other Government Department",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 23,
                    Title = "Strategic Incident Oversight Group (SIOG)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 24,
                    Title = "Chair, SIOG",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 25,
                    Title = "Strategic Advisior",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 26,
                    Title = "Strategic Director",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 27,
                    Title = "Dairy Inspector",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 28,
                    Title = "Field Operations - FVC",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 29,
                    Title = "Field Operations - FVL",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 30,
                    Title = "FSA Business Assurance Auditors",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 31,
                    Title = "Meat Hygiene Inspector",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 32,
                    Title = "Poultry Hygiene Inspector",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 33,
                    Title = "Wine Inspector",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 34,
                    Title = "Receipt & Management  (RAM) Lead",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 35,
                    Title = "Stakeholder  Engagement  (SHE) Lead",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 36,
                    Title = "Receipt & Management (RAM ) Officer",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                new UnitQuantityDb
                {
                    Id = 37,
                    Title = "Stakeholder Engagement (SHE) Officer",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                });
    }
}
