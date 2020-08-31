using AutoMapper;
using AutoMapper.Configuration;
using FSA.IncidentsManagement.Root.Models;
using FSA.IncidentsManagementDb.Entities.Helpers;
using FSA.IncidentsManagementDb.Repositories;
using FSA.SIMSManagerDb;
using FSA.SIMSManagerDb.MapperProfile;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SIMS.TestProjects.Setup
{
    /// <summary>
    /// Gets data required for each test (eg mapping and config and user info etc)
    /// </summary>
    class SeedingConfigData
    {
        internal IDictionary<string, object> GetConfigData()
        {
            var x = new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                ReadCommentHandling = JsonCommentHandling.Skip
            };
            return System.Text.Json.JsonSerializer.Deserialize<ExpandoObject>(File.OpenText("./Setup/appsettings.json").ReadToEnd(), x);
        }

        internal static SimsDbContext GetDbContext(string conn) => new SimsDbContext(new DbContextOptionsBuilder().UseSqlServer(conn).Options);

        internal IMapper GetDbAutoMapper()
        {
            var cfg = new MapperConfigurationExpression();
            cfg.AddProfile<SIMSMappingProfile>();
            var mapperConfig = new MapperConfiguration(cfg);
            return new Mapper(mapperConfig);
        }

        internal string[] userIds => new string[]
        {
            "2f65582c-5970-4848-9020-d65b6df2dc04", //me
            "9a8dda39-78ec-496d-8625-f8b24d83aa57",
            "51b75a03-4bb1-4e03-bd91-469fe7a1e6e9", // FSA.Test
            "8cc321a9-fea4-4689-a127-c5e141e2810c" // miller
        };

        public IEnumerable<BaseIncident> GetNewIncidents() => new List<BaseIncident>
        {
                 new BaseIncident(
                   incidentTitle: "New Incident",
                   incidentTypeId: 1,
                   contactMethodId: 2,
                   statusId: (int)IncidentStatusTypes.Unassigned,
                   priorityId: 2,
                   classificationId: 1,
                   dataSourceId: 1,
                   signalUrl:"https://signalUrl.com",
                   productTypeId: 3,
                   leadOfficer: "",
                   adminLeadId: 1,
                   leadOffice: "",
                   fieldOfficer: "",
                   lAAdvised: false,
                   deathIllnessId: 3,
                   receivedOn: null,
                   signalStatusId: null,
                   notifierId: null,
                   principalFBOId: null,
                   leadLocalAuthorityId: null,
                   incidentClosed: null),

                new BaseIncident(
                   incidentTitle: "Mislabelled ingredients omit peanuts",
                   incidentTypeId: 1,
                   contactMethodId: 4,
                   statusId: (int)IncidentStatusTypes.Open,
                   priorityId: 2,
                   classificationId: 1,
                   dataSourceId: 1,
                   signalUrl:"https://signalUrl.com",
                   productTypeId: 3,
                   leadOfficer: this.userIds[1],
                   adminLeadId: 1,
                   leadOffice: "",
                   fieldOfficer: "",
                   lAAdvised: false,
                   deathIllnessId: 3,
                   receivedOn: DateTime.Now.ToUniversalTime(),
                   signalStatusId: null,
                   notifierId: null,
                   principalFBOId: null,
                   leadLocalAuthorityId: null,
                   incidentClosed: null),

                new BaseIncident(
                   incidentTitle: "Salmonella poisoning cases at local GP",
                   incidentTypeId: 1,
                   contactMethodId: 1,
                   statusId: (int)IncidentStatusTypes.Open,
                   priorityId: 1,
                   classificationId: 1,
                   signalUrl:"",
                   dataSourceId: 1,
                   productTypeId: 3,
                   leadOffice: "",
                   adminLeadId: 1,
                   leadOfficer: this.userIds[2],
                   fieldOfficer: "",
                   lAAdvised: false,
                   deathIllnessId: 2,
                   receivedOn: DateTime.Now.ToUniversalTime(),
                   signalStatusId: null,
                   notifierId: null,
                   principalFBOId: null,
                   leadLocalAuthorityId: null,
                   incidentClosed: null),

                new BaseIncident(
                   incidentTitle: "Chinese Restaurant takeaway pinpointed as likely source for salmonella poisoning (unverified)",
                   incidentTypeId: 1,
                   contactMethodId: 2,
                   statusId: (int)IncidentStatusTypes.Open,
                   priorityId: 1,
                   classificationId: 1,
                   dataSourceId: 1,
                   signalUrl:"https://signalUrl.com",
                   productTypeId: 3,
                   leadOffice: "",
                   adminLeadId: 2,
                   leadOfficer: this.userIds[3],
                   fieldOfficer: "",
                   lAAdvised: false,
                   deathIllnessId: 2,
                   receivedOn: DateTime.Now.ToUniversalTime(),
                   signalStatusId: null,
                   notifierId: null,
                   principalFBOId: null,
                   leadLocalAuthorityId: null,
                   incidentClosed: null)
        };

        public IEnumerable<Product> GetNewProducts() => new List<Product>
        {
            new Product
            {
                Name = "Bourbon biscuits",
                Brand = "McBiscuits",
                Amount = "5.53",
                AmountUnitTypeId = 1,
                PackDescription = "This is a new packet",
                HostId = 17,
                CountryOfOriginId = 28,
                ProductTypeId =8,
                BatchCodes = "bb1, bb2, bb3",
                AdditionalInfo = "Some more info",
                PackSizes = new List<ProductPackSize> { new ProductPackSize { Size = "12", UnitId = 9 } },
                ProductDates = new List<ProductDate> { new ProductDate { DateTypeId = 1, Date = DateTime.Now } }
            },
            new Product
            {
                Name = "Sticky biscuits",
                Brand = "McBiscuits",
                Amount = "8",
                AmountUnitTypeId = 4,
                PackDescription = "mmmm sticky biscuits",
                HostId = 17,
                CountryOfOriginId = 47,
                BatchCodes = "sb1, sb2, sb14",
                ProductTypeId =12,
                //DataSourceId = 2,
                AdditionalInfo = "Some more info",
                PackSizes = new List<ProductPackSize> { new ProductPackSize { Size = "1", UnitId = 14 } },
                ProductDates = new List<ProductDate> { new ProductDate { DateTypeId = 1, Date = DateTime.Now } }
            },
            new Product
            {
                Name = "Chocolate biscuits",
                Brand = "McBiscuits",
                Amount = "120",
                AmountUnitTypeId = 10,
                PackDescription = "yucky",
                HostId = 17,
                ProductTypeId =14,
                CountryOfOriginId = 28,
                BatchCodes = "cbasdasd-1212, cb-2332423324-1231212",
                AdditionalInfo = "eomthing",
                PackSizes = new List<ProductPackSize> { new ProductPackSize { Size = "12", UnitId = 7 },new ProductPackSize { Size = "8", UnitId = 19 },new ProductPackSize { Size = "0.1", UnitId = 5 } },
                ProductDates = new List<ProductDate> {
                        new ProductDate { DateTypeId = 1, Date = DateTime.Now }
                        ,new ProductDate { DateTypeId = 2, Date = DateTime.Now }
                        ,new ProductDate { DateTypeId = 3, Date = DateTime.Now }
                }
            },
                        new Product
            {
                Name = "Blue ham",
                Brand = "Ham man",
                Amount = "47",
                AmountUnitTypeId = 2,
                PackDescription = "Long john ham gone",
                HostId = 23,
                ProductTypeId =10,
                CountryOfOriginId = 18,
                BatchCodes = "Code 01, ode02",
                AdditionalInfo = "",
                PackSizes = new List<ProductPackSize> { new ProductPackSize { Size = "12", UnitId = 7 },new ProductPackSize { Size = "8", UnitId = 19 },new ProductPackSize { Size = "0.1", UnitId = 5 } },
                ProductDates = new List<ProductDate> {
                        new ProductDate { DateTypeId = 1, Date = DateTime.Now }
                        ,new ProductDate { DateTypeId = 2, Date = DateTime.Now }
                        ,new ProductDate { DateTypeId = 3, Date = DateTime.Now }
                }
            }

        };

        public IEnumerable<Stakeholder> GetIncidentStakeholder => new List<Stakeholder>
        {
           new Stakeholder
            {
                DiscriminatorId = 3,
                HostId = 17,
                Name = "Stake holder",
                GovDept = "Dept for food",
                Phone = "012345 789",
                Role = "Dancing instructor",
               AddressId=92
            },
           new Stakeholder
            {
                DiscriminatorId = 4,
                HostId = 17,
                Name = "More holder",
                GovDept = "",
                Phone = "012345 789",
                Role = "Admin",
                AddressId=18
            },
           new Stakeholder
            {
                DiscriminatorId = 2,
                HostId = 17,
                Name = "Larry cup",
                GovDept = "",
                Phone = "012345 789",
                Email = "Email@1",
                Role = "Admin",
                AddressId=17
            }
        };

        public IEnumerable<Stakeholder> GetSignalStakeholder => new List<Stakeholder>
        {
           new Stakeholder
            {
                DiscriminatorId = 3,
                HostId = 23,
                Name = "Signal Stake holder",
                GovDept = "Signalling",
                Phone = "012345 789",
                Role = "Dancing instructor",
               AddressId=92
            },
           new Stakeholder
            {
                DiscriminatorId = 1,
                HostId = 23,
                Name = "Jeremy Smith",
                GovDept = "",
                Phone = "012345 789",
                Role = "Admin",
                AddressId=18
            },
           new Stakeholder
            {
                DiscriminatorId = 2,
                HostId = 2,
                Name = "Henry plate",
                GovDept = "",
                Phone = "012345 789",
                Email = "Email@1",
                Role = "Admin",
                AddressId=17
            },
            new Stakeholder
            {
                DiscriminatorId = 1,
                HostId = 1,
                Name = "Mavis Coupe",
                GovDept = "",
                Phone = "012345 789",
                Email = "Email@1",
                Role = "Roling",
                AddressId=17
            },
            new Stakeholder
            {
                DiscriminatorId = 2,
                HostId = 1,
                Name = "Jame flan",
                GovDept = "",
                Phone = "12345",
                Email = "Email@jameflan.com",
                Role = "Communicatios",
                AddressId=56
            }
        };


    }
}
