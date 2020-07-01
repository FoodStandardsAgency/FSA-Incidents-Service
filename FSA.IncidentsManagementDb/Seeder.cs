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
                        Id = 3,
                        Title = "e-trader",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 4,
                        Title = "Exporter",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 5,
                        Title = "Farmer",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 6,
                        Title = "Hospitality/Food service",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 7,
                        Title = "Importer",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 8,
                        Title = "Manufacturer",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 9,
                        Title = "Packer/filler",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 10,
                        Title = "Processor",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 11,
                        Title = "Producer",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 12,
                        Title = "Retailer",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 13,
                        Title = "Storage",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 14,
                        Title = "Supplier",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 15,
                        Title = "Trader/Broker",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 16,
                        Title = "Transporter",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new FBOTypeDb
                    {
                        Id = 17,
                        Title = "Wholesaler",
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
                    Title = "Afganistan (AF)",
                    CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                    ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                },
                    new CountryDb
                    {
                        Id = 2,
                        Title = "Aland Islands (AX)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 3,
                        Title = "Albania (AL)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 4,
                        Title = "Algeria (DZ)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 5,
                        Title = "America Samoa (AS)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 6,
                        Title = "Andorra (AD)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 7,
                        Title = "Angola (AO)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 8,
                        Title = "Anguilla (AI)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 9,
                        Title = "Antarctica (AQ)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 10,
                        Title = "Antigua & Barbuda (AG)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 11,
                        Title = "Argentina (AR)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 12,
                        Title = "Armenia (AM)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 13,
                        Title = "Aruba (AW)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 14,
                        Title = "Australia (AU)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 15,
                        Title = "Austria (AT)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 16,
                        Title = "Azerbaijan (AZ)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 17,
                        Title = "Bahamas (BS)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 18,
                        Title = "Bahrain (BH)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 19,
                        Title = "Bangladesh (BD)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 20,
                        Title = "Barbados (BB)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 21,
                        Title = "Belarus (BY)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 22,
                        Title = "Belgium (BE)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 23,
                        Title = "Belize (BZ)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 24,
                        Title = "Benin (BJ)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 25,
                        Title = "Bermuda (BM)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 26,
                        Title = "Bhutan (BT)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 27,
                        Title = "Bolivia (BO)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 28,
                        Title = "Bosnia & Herzegovina (BA)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 29,
                        Title = "Botswana (BW)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 30,
                        Title = "Bouvet Island (BV)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 31,
                        Title = "Brazil (BR)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 32,
                        Title = "British Indian Ocean Territory (IO)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 33,
                        Title = "Brunei Darussalam (BN)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 34,
                        Title = "Bulgaria (BG)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 35,
                        Title = "Burkina Faso (BF)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 36,
                        Title = "Burundi (BI)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 37,
                        Title = "Cambodia (KH)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 38,
                        Title = "Cameroon (CM)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 39,
                        Title = "Canada (CA)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 40,
                        Title = "Cape Verde (CV)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 41,
                        Title = "Cayman Islands (KY)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 42,
                        Title = "Central African Republic (CF)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 43,
                        Title = "Chad (TD)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 44,
                        Title = "Chile (CL)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 45,
                        Title = "China (CX)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 46,
                        Title = "Christmas Island (CX)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 47,
                        Title = "Cocos (Keeling) Islands (CC)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 48,
                        Title = "Columbia (CO)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 49,
                        Title = "Commission Services (CS)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 50,
                        Title = "Comoros (KM)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 51,
                        Title = "Congo The Democratic Rebulic of the (CD)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 52,
                        Title = "Congo-Brazzaville (CG)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 53,
                        Title = "Cook Islands (CK)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 54,
                        Title = "Costa Rica (CR)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 55,
                        Title = "Cote D`Ivoire (CI)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 56,
                        Title = "Country Not mentioned (NM)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 57,
                        Title = "Croatia (HR)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 58,
                        Title = "Cuba (CU)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 59,
                        Title = "Cyprus (CY)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 60,
                        Title = "Czech Republic (DO)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 61,
                        Title = "Denmark (DK)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 62,
                        Title = "Djibouti (DJ)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 63,
                        Title = "Dominica (DM)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 64,
                        Title = "Dominican Republic (DO)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 65,
                        Title = "Eathiopia (ET)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 66,
                        Title = "Ecuador (EC)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 67,
                        Title = "EFSA (FS)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 68,
                        Title = "El Salvador (SV)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 69,
                        Title = "Equatorial Guinea (GQ)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 70,
                        Title = "Eritrea (ER)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 71,
                        Title = "ESA (EF)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 72,
                        Title = "Estonia (EE)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 73,
                        Title = "Eygypt (EG)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 74,
                        Title = "Falkland Islands (Malvinas) (FK)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 75,
                        Title = "Faroe Islands (FO)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 76,
                        Title = "Fiji (FJ)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 77,
                        Title = "Finland (FI)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 78,
                        Title = "France (FR)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 79,
                        Title = "French Guiana (GF)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 80,
                        Title = "French Polynesia (PF)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 81,
                        Title = "French Southern Territories (TF)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 82,
                        Title = "Gabon (GA)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 83,
                        Title = "Gambia (GM)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 84,
                        Title = "Georgia (GE)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 85,
                        Title = "Germany (DE)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 86,
                        Title = "Ghana GH)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 87,
                        Title = "Gibraltar (GI)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 88,
                        Title = "Greece (GR)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 89,
                        Title = "Greenland (GL)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 90,
                        Title = "Grenada (GD)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 91,
                        Title = "Guadeloupe (GP)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 92,
                        Title = "Guam (GU)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 93,
                        Title = "Guatemala (GT)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 94,
                        Title = "Guernsey (GG)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 95,
                        Title = "Guinea-Bissau (GW)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 96,
                        Title = "Guyana (GY)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 97,
                        Title = "Haiti (HT)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 98,
                        Title = "Heatrd Island & McDonald Islands (HM)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 99,
                        Title = "Holy See (Vatican City State) (VA)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 100,
                        Title = "Honduras (HN)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 101,
                        Title = "Hong Kong (HK)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 102,
                        Title = "Hungary (HU)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 103,
                        Title = "Iceland (IS)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 104,
                        Title = "Ilse of Man (IM)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 105,
                        Title = "India (IN)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 106,
                        Title = "Indonesia (ID)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 107,
                        Title = "Iran Islamic Republic of (IR)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 108,
                        Title = "Iraq (IQ)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 109,
                        Title = "Ireland (IE)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 110,
                        Title = "Israel (IL)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 111,
                        Title = "Italy (IT)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 112,
                        Title = "Jamacia (JM)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 113,
                        Title = "Japan (JP)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 114,
                        Title = "Jersey (JE)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 115,
                        Title = "Jordan (JO)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 116,
                        Title = "Kiribati (KI)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 117,
                        Title = "Korea Democratic People`s Republic of (KP)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 118,
                        Title = "Korea Republic of (KR)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 119,
                        Title = "Kosovo Autonomous Region of (KS)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 120,
                        Title = "Kuwait (KW)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 121,
                        Title = "Kyrgyzstan (KG)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 122,
                        Title = "Lao People`s Democratic Republic (LA)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 123,
                        Title = "Latvia (LV)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 124,
                        Title = "Lebanon (LB)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 125,
                        Title = "Lesotho (LS)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 126,
                        Title = "Liberia (LR)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 127,
                        Title = "Libyan Arab Jamahirya (LY)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 128,
                        Title = "Liechtenstien (LI)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 129,
                        Title = "Lithuania (LT)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 130,
                        Title = "Luxembourg (LU)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 131,
                        Title = "Macao (MO)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 132,
                        Title = "Macedonia The Former Yugoslav Republic of (MK)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 133,
                        Title = "Madagascar (MG)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 134,
                        Title = "Malawi (MW)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 135,
                        Title = "Malaysia (MY)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 136,
                        Title = "Maldives (MV)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 137,
                        Title = "Mali (ML)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 138,
                        Title = "Malta (ML)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 139,
                        Title = "Marshall Islands (MH)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 140,
                        Title = "Martinique (MQ)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 141,
                        Title = "Mauritania (MR)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 142,
                        Title = "Mauritius (MU)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 143,
                        Title = "Mayotte (YT)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 144,
                        Title = "Mexico (MX)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 145,
                        Title = "Micronesia Federated States of (FM)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 146,
                        Title = "Moldova Republic of (MD)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 147,
                        Title = "Monaco (MC)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 148,
                        Title = "Mongolia (MN)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 149,
                        Title = "Montenegro (ME)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 150,
                        Title = "Montserrat (MS)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 151,
                        Title = "Morocco (MA)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 152,
                        Title = "Mozambique (MZ)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 153,
                        Title = "Myanimar (MM)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 154,
                        Title = "Nambia (NA)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 155,
                        Title = "Nauru (NR)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 156,
                        Title = "Nepal (NP)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 157,
                        Title = "Netherlands (NL)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 158,
                        Title = "Netherlands Antilles (AN)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 159,
                        Title = "New Caledonia (NC)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 160,
                        Title = "New Zealand (NZ)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 161,
                        Title = "Nicaragua ((NI)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 162,
                        Title = "Niger (NE)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 163,
                        Title = "Nigeria (NG)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 164,
                        Title = "Niue (NU)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 165,
                        Title = "Norfolk Island (NF)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 166,
                        Title = "Northern Mariana Islands (MP)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 167,
                        Title = "Norway (NO)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 168,
                        Title = "Oman (OM)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 169,
                        Title = "Pakistan (PK)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 170,
                        Title = "Palau (PW)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 171,
                        Title = "Palestinian Territory Occupied (PS)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 172,
                        Title = "Panama (PA)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 173,
                        Title = "Papua New Guinea (PG)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 174,
                        Title = "Paraguay (PY)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 175,
                        Title = "Peru (PE)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 176,
                        Title = "Philippines (PH)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 177,
                        Title = "Pitcairn (PN)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 178,
                        Title = "Poland (PL)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 179,
                        Title = "Portugal (PT)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 180,
                        Title = "Puerto Rico (PR)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 181,
                        Title = "Qatar (QA)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 182,
                        Title = "Reunion (RE)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 183,
                        Title = "Romania (RO)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 184,
                        Title = "Russian Federation (RU)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 185,
                        Title = "Rwanda (RO)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 186,
                        Title = "Saint Barthelemy (BL)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 187,
                        Title = "Saint Helena (SH)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 188,
                        Title = "Saint Kitts & Nevis (KN)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 189,
                        Title = "Saint Lucia (LC)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 190,
                        Title = "Saint Martin (MF)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 191,
                        Title = "Saint Pierre & Miquelon (PM)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 192,
                        Title = "Saint Vincent & the Grenadines (VC)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 193,
                        Title = "Samoa (WS)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 194,
                        Title = "San Marino (SM)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 195,
                        Title = "Sao Tome & Principe (ST)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 196,
                        Title = "Saudi Arabia (SA)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 197,
                        Title = "Senegal (SN)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 198,
                        Title = "Serbia (RS)",
                        CreatedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9",
                        ModifiedBy = "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9"
                    },
                    new CountryDb
                    {
                        Id = 199,
                        Title = "Seychelles (SC)",
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
                        Id = 3,
                        Title = "Fax",
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
    }
}
