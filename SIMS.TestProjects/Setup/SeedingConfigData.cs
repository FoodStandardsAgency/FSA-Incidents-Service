using AutoMapper;
using AutoMapper.Configuration;
using AutoMapper.EquivalencyExpression;
using FSA.IncidentsManagement.ModelValidators;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb;
using FSA.SIMSManagerDb.MapperProfile;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text.Json;

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
            cfg.AddProfile<SimsDbMappingProfile>();
            cfg.AddProfile<WebMappingProfile>();
            cfg.AddCollectionMappers();
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
                   incidentTypeId: 36,
                   incidentSourceId:8,
                   contactMethodId: 2,
                   statusId: (int)SimsIncidentStatusTypes.Unassigned,
                   priorityId: 2,
                   classificationId: 1,
                   dataSourceId: 2,
                   signalUrl:"https://signalUrl.com",
                   productTypeId: 3,
                   leadOfficer: "",
                   adminLeadId: 1,
                   leadOffice: "",
                   fieldOfficer: "",
                   lAAdvised: false,
                   oimtGroups:null,
                   deathIllnessId: 3,
                   receivedOn: null,
                   signalStatusId: null,
                   notifierId: null,
                   principalFBOId: null,
                sensitiveInfo: false,
                    onlineFormId:null,
                   leadLocalAuthorityId: null,
                   incidentClosed: null),

                new BaseIncident(
                   incidentTitle: "Mislabelled ingredients omit peanuts",
                   incidentTypeId: 72,
                   contactMethodId: 4,
                   incidentSourceId:8,
                   statusId: (int)SimsIncidentStatusTypes.Open,
                   priorityId: 2,
                   classificationId: 1,
                   dataSourceId: 4,
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
                   sensitiveInfo: false,
                   oimtGroups:"OimtGroups, OimitGroups 2",
                    onlineFormId:null,
                   principalFBOId: null,
                   leadLocalAuthorityId: null,
                   incidentClosed: null),

                new BaseIncident(
                   incidentTitle: "Salmonella poisoning cases at local GP",
                   incidentTypeId: 55,
                   contactMethodId: 1,
                   incidentSourceId: 8,
                   statusId: (int)SimsIncidentStatusTypes.Open,
                   priorityId: 1,
                   classificationId: 1,
                   signalUrl:"",
                   dataSourceId: 2,
                   productTypeId: 3,
                   leadOffice: "",
                   adminLeadId: 1,
                   leadOfficer: this.userIds[2],
                    onlineFormId:null,
                   fieldOfficer: "",
                   lAAdvised: false,
                   deathIllnessId: 2,
                   receivedOn: DateTime.Now.ToUniversalTime(),
                   signalStatusId: null,
                   notifierId: null,
                   oimtGroups:"OimtGroups, OimitGroups 2",
                   principalFBOId: null,
                  sensitiveInfo: false,
                   leadLocalAuthorityId: null,
                   incidentClosed: null),

                new BaseIncident(
                   incidentTitle: "Chinese Restaurant takeaway pinpointed as likely source for salmonella poisoning (unverified)",
                   incidentTypeId: 77,
                   contactMethodId: 2,
                   statusId: (int)SimsIncidentStatusTypes.Open,
                   priorityId: 1,
                   incidentSourceId:2,
                   classificationId: 1,
                   dataSourceId: 2,
                   signalUrl:"https://signalUrl.com",
                   onlineFormId:null,
                   productTypeId: 3,
                   leadOffice: "",
                   adminLeadId: 2,
                   leadOfficer: this.userIds[3],
                   fieldOfficer: "",
                   lAAdvised: false,
                   deathIllnessId: 2,
                   oimtGroups:"OimtGroups, OimitGroups And then some",
                   receivedOn: DateTime.Now.ToUniversalTime(),
                   signalStatusId: null,
                    sensitiveInfo: false,
                   notifierId: null,
                   principalFBOId: null,
                   leadLocalAuthorityId: null,
                   incidentClosed: null)
        };

        public IEnumerable<SimsProduct> GetNewProducts() => new List<SimsProduct>
        {
            new SimsProduct
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
                PackSizes = new List<SimsProductPackSize> { new SimsProductPackSize { Size = "12", UnitId = 24} },
                ProductDates = new List<SimsProductDate> { new SimsProductDate { DateTypeId = 1, Date = DateTime.Now } }
            },
            new SimsProduct
            {
                Name = "Sticky biscuits",
                Brand = "McBiscuits",
                Amount = "8",
                AmountUnitTypeId = 8,
                PackDescription = "mmmm sticky biscuits",
                HostId = 17,
                CountryOfOriginId = 47,
                BatchCodes = "sb1, sb2, sb14",
                ProductTypeId =12,
                //DataSourceId = 2,
                AdditionalInfo = "Some more info",
                PackSizes = new List<SimsProductPackSize> { new SimsProductPackSize { Size = "1", UnitId = 23 } },
                ProductDates = new List<SimsProductDate> { new SimsProductDate { DateTypeId = 1, Date = DateTime.Now } }
            },
            new SimsProduct
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
                PackSizes = new List<SimsProductPackSize> { new SimsProductPackSize { Size = "12", UnitId = 21 },
                    new SimsProductPackSize { Size = "8", UnitId = 19 },
                                new SimsProductPackSize { Size = "0.1", UnitId = 22 } },
                ProductDates = new List<SimsProductDate> {
                        new SimsProductDate { DateTypeId = 1, Date = DateTime.Now }
                        ,new SimsProductDate { DateTypeId = 2, Date = DateTime.Now }
                        ,new SimsProductDate { DateTypeId = 3, Date = DateTime.Now }
                }
            },
            new SimsProduct
            {
                Name = "Blue ham",
                Brand = "Ham man",
                Amount = "47",
                AmountUnitTypeId = 9,
                PackDescription = "Long john ham gone",
                HostId = 23,
                ProductTypeId =10,
                CountryOfOriginId = 18,
                BatchCodes = "Code 01, ode02",
                AdditionalInfo = "",
                PackSizes = new List<SimsProductPackSize> { new SimsProductPackSize { Size = "12", UnitId = 11 },
                    new SimsProductPackSize { Size = "8", UnitId = 19 },
                    new SimsProductPackSize { Size = "0.1", UnitId = 20 } },
                ProductDates = new List<SimsProductDate> {
                        new SimsProductDate { DateTypeId = 1, Date = DateTime.Now }
                        ,new SimsProductDate { DateTypeId = 2, Date = DateTime.Now }
                        ,new SimsProductDate { DateTypeId = 3, Date = DateTime.Now }
                }
            }

        };

        public IEnumerable<SimsStakeholder> GetIncidentStakeholder => new List<SimsStakeholder>
        {
           new SimsStakeholder
            {
                DiscriminatorId = 3,
                HostId = 17,
                Name = "Stake holder",
                GovDept = "Dept for food",
                Phone = "012345 789",
                Role = "Dancing instructor",
               AddressId=92
            },
           new SimsStakeholder
            {
                DiscriminatorId = 4,
                HostId = 17,
                Name = "More holder",
                GovDept = "",
                Phone = "012345 789",
                Role = "Admin",
                AddressId=18
            },
           new SimsStakeholder
            {
                DiscriminatorId = 2,
                HostId = 17,
                Name = "Larry cup",
                GovDept = "",
                Phone = "012345 789",
                Email = "Email@1",
                Role = "Admin",
                AddressId=17
            },
                      new SimsStakeholder
            {
                DiscriminatorId = 4,
                HostId = 23,
                Name = "Kathy Soaker",
                GovDept = "",
                Phone = "012345 789",
                Email = "Email@1",
                Role = "Smeel",
                AddressId=17
            }
        };

        public IEnumerable<SimsStakeholder> GetSignalStakeholder => new List<SimsStakeholder>
        {
           new SimsStakeholder
            {
                DiscriminatorId = 3,
                HostId = 23,
                Name = "Signal Stake holder",
                GovDept = "Signalling",
                Phone = "012345 789",
                Role = "Dancing instructor",
               AddressId=92
            },
           new SimsStakeholder
            {
                DiscriminatorId = 1,
                HostId = 23,
                Name = "Jeremy Smith",
                GovDept = "",
                Phone = "012345 789",
                Role = "Admin",
                AddressId=18
            },
           new SimsStakeholder
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
            new SimsStakeholder
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
            new SimsStakeholder
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

        public IEnumerable<SimsOnlineForm> GetOnlineFormData = new[]
        {
            new SimsOnlineForm
            {
                Title = "Basic Complaint",
                NotifierTypeId=3,
                Description = "Description of basic complaint",
                Action = "Action to be placed, or has placed",
                DeathIllness = "Death illness Text",
                DistributionDetails = "Where did this get done didded",
                AdditionalInformation = "Anything else I added",
                IsClosed = false,
                
                ReferenceNo = "R1234",
                LADetails = "Local Authority text field"
            },
            new SimsOnlineForm
            {
                Title = "Next Complaint",
                NotifierTypeId=5,
                Description = @"Columbo is a shrewd but inelegant blue-collar homicide detective whose trademarks include his rumpled beige raincoat, unassuming demeanor, cigar, old Peugeot 403 car, unseen wife (whom he mentions regularly), and catchphrase 'Just one more thing.'

The recurring plot's homicide suspects are uniformly clever, wealthy, and elite, setting up a class conflict as part of each episode.[4] Suspects carefully cover their tracks and are initially dismissive of Columbo's circumstantial speech and apparent ineptitude. They become increasingly unsettled as his pestering behavior teases out incriminating evidence. [4] His relentless approach often leads to self-incrimination or outright confession. ",
                Action = "Action to be placed, or has placed",
                DeathIllness = "Death illness Text",
                DistributionDetails = "Distribution",
                AdditionalInformation = @"Episodes of Columbo are between 70 and 98 minutes long, and have been broadcast in 44 countries. The 1971 episode 'Murder by the Book', directed by Steven Spielberg, was ranked No. 16 on TV Guide's 100 Greatest Episodes of All-Time[5] and in 1999, the magazine ranked Lt. Columbo No. 7 on its 50 Greatest TV Characters of All Time list.[6][7] In 2012, the program was ranked the third-best cop or legal show on Best in TV: The Greatest TV Shows of Our Time.[8] In 2013, TV Guide included it in its list of The 60 Greatest Dramas of All Time[9] and ranked it 33rd on its list of the 60 Best Series.[10] Also in 2013, the Writers Guild of America ranked it 57th on its list of 101 Best Written TV Series.[11]",
                IsClosed = false,
                
                ReferenceNo = "RABCDE",
                LADetails = "Local Authority text field"
            },
            new SimsOnlineForm
            {
                Title = "More Form Data",
                NotifierTypeId=2,
                Description = "Description Text",
                Action = @"The Trivia Encyclopedia lawsuit
                Columbo's first name is notably never mentioned in the series, but 'Frank Columbo' or 'Lt. Frank Columbo' can occasionally be seen on his police ID. This ambiguity surrounding Columbo's first name led to the creator of The Trivia Encyclopedia, Fred L. Worth, to include a false entry that listed 'Phillip Columbo' as Columbo's full name as a copyright trap. When the board game Trivial Pursuit included 'Phillip' as the answer to the question, 'What was Columbo's first name?', Worth launched a 300 million dollar lawsuit against the creators of the game.[46][47] The creators of the game argued that while they did use The Trivia Encyclopedia as one of their sources, facts are not copyrightable and there was nothing improper about using an encyclopedia in the production of a fact-based game. The district court judge agreed and the decision was upheld by the United States Court of Appeals for the Ninth Circuit in September 1987. Worth asked the Supreme Court of the United States to review the case, but the Court declined, denying certiorari in March 1988. ",
                    DeathIllness = "Death illness Text",
                DistributionDetails = "",
                AdditionalInformation = @"Specifies the hosting plan that defines how resources are allocated to your function app. In the default Consumption plan, resources are added dynamically as required by your functions. In this serverless hosting model, you only pay for the time your functions run.",
                IsClosed = false,
                
                ReferenceNo = "R1234-A1234",
                LADetails = "Local Authority text field"
            },
            new SimsOnlineForm
            {
                Title = "More data",
                NotifierTypeId=5,
                Description = @"Specifies the name of the new storage account used by your function app (which does not need to match the globally unique name that you specified for your function). Storage account names must be between 3 and 24 characters in length and may contain numbers and lowercase letters only. This dialog automatically populates the field with a unique name that is dynamically generated. However, feel free to use a different name or even an existing account.",
                Action = "Action to be placed, or has placed",
                DeathIllness = "Death illness Text",
                DistributionDetails = @"At the beginning of every episode, Columbo's genius was hidden by his frumpy, friendly and disarming demeanor, luring the killer into a false sense of security. In some cases, the killer's arrogance and dismissive attitude allow Columbo to manipulate his suspects into self-incrimination. While the details, and eventually the motivation(s), of the murderers' actions are shown to the viewer, Columbo's true thoughts and intentions are almost never revealed until close to the end of the episode (he occasionally begins to whistle the tune 'This Old Man' as the pieces begin to fall into place). Columbo generally maintains a friendly relationship with the murderer until the end. The point at which the detective first begins to suspect the murderer is generally not revealed, although it is often fairly early on. Columbo had a duality of character; the disarming and unkempt detective and the hidden genius sleuth. The genius would sometimes starkly manifest itself through his eyes as it did when Jack Cassidy’s killer escaped from the handcuffs in his magic show. Such moments always bode bad tidings for the killer. In some instances, such as Ruth Gordon's avenging elderly mystery writer in 'Try and Catch Me', Janet Leigh's terminally ill and deluded actress in 'Forgotten Lady', Donald Pleasence's elegant vintner in 'Any Old Port in a Storm', and Johnny Cash's enserfed singer in 'Swan Song', the killer is more sympathetic than the victim.[14] ",
                AdditionalInformation = "",
                IsClosed = false,
                
                ReferenceNo = "RABCDE",
                LADetails = "Local Authority text field"
            },
            new SimsOnlineForm
            {
                Title = "Basic Complaint",
                NotifierTypeId=3,
                Description = @"Murder, She Wrote is an American crime drama television series starring Angela Lansbury as mystery writer and amateur detective Jessica Fletcher.[4][5] The series aired for 12 seasons with 264 episodes from 1984 to 1996 on the CBS network. It was followed by four TV films. Among the most successful and longest-running television shows in history, it averaged more than 30 million viewers per week in its prime (sometimes hitting above 40 million viewers), and was a staple of the CBS Sunday night lineup for a decade.[6] In syndication, the series is still highly successful throughout the world. ",
                Action = @"For her work on Murder, She Wrote, Lansbury was nominated for ten Golden Globes and 12 Emmy Awards, winning four Golden Globe awards. She holds the record for the most Golden Globe nominations and wins for Best Actress in a television drama series and the most Emmy nominations for Outstanding Lead Actress in a Drama Series. The series received three Emmy nominations for Outstanding Drama Series. It was nominated for a Golden Globe in the same category six times and won twice. ",
                DeathIllness = "Death illness Text",
                DistributionDetails = "Details deatisls details",
                AdditionalInformation = @"Series producers Peter S. Fischer, Richard Levinson and William Link thought Lansbury would be perfect for the part of Jessica Fletcher but did not think that she would be interested in a television series. Earlier, she had acted in two film adaptations of Agatha Christie's mystery novels: as Salome Otterbourne in Death on the Nile and as Miss Marple in The Mirror Crack'd (1980). When the latter film did poorly—despite an all star cast including Rock Hudson, Elizabeth Taylor, Kim Novak, and Tony Curtis—the offer for Lansbury to reprise Miss Marple in three more films never materialized.[9] ",
                IsClosed = false,
                
                ReferenceNo = "RJessica-Fletcher",
                LADetails = "Local Authority text field"
            },
            new SimsOnlineForm
            {
                Title = "Second Series Complaint",
                NotifierTypeId=3,
                Description = "Description of basic complaint",
                Action = "Action to be placed, or has placed",
                DeathIllness = "Death illness Text",
                DistributionDetails = "Where did this get done didded",
                AdditionalInformation = "Anything else I added",
                IsClosed = false,
                
                ReferenceNo = "R1234",
                LADetails = "Local Authority text field"
            },
            new SimsOnlineForm
            {
                Title = "Second Next Complaint",
                NotifierTypeId=5,
                Description = @"Columbo is a shrewd but inelegant blue-collar homicide detective whose trademarks include his rumpled beige raincoat, unassuming demeanor, cigar, old Peugeot 403 car, unseen wife (whom he mentions regularly), and catchphrase 'Just one more thing.'

The recurring plot's homicide suspects are uniformly clever, wealthy, and elite, setting up a class conflict as part of each episode.[4] Suspects carefully cover their tracks and are initially dismissive of Columbo's circumstantial speech and apparent ineptitude. They become increasingly unsettled as his pestering behavior teases out incriminating evidence. [4] His relentless approach often leads to self-incrimination or outright confession. ",
                Action = "Action to be placed, or has placed",
                DeathIllness = "Death illness Text",
                DistributionDetails = "Distribution",
                AdditionalInformation = @"Episodes of Columbo are between 70 and 98 minutes long, and have been broadcast in 44 countries. The 1971 episode 'Murder by the Book', directed by Steven Spielberg, was ranked No. 16 on TV Guide's 100 Greatest Episodes of All-Time[5] and in 1999, the magazine ranked Lt. Columbo No. 7 on its 50 Greatest TV Characters of All Time list.[6][7] In 2012, the program was ranked the third-best cop or legal show on Best in TV: The Greatest TV Shows of Our Time.[8] In 2013, TV Guide included it in its list of The 60 Greatest Dramas of All Time[9] and ranked it 33rd on its list of the 60 Best Series.[10] Also in 2013, the Writers Guild of America ranked it 57th on its list of 101 Best Written TV Series.[11]",
                IsClosed = false,
                
                ReferenceNo = "RABCDE",
                LADetails = "Local Authority text field"
            },
            new SimsOnlineForm
            {
                Title = "Lots of data",
                NotifierTypeId=2,
                Description = "Description Text",
                Action = @"The Trivia Encyclopedia lawsuit
                Columbo's first name is notably never mentioned in the series, but 'Frank Columbo' or 'Lt. Frank Columbo' can occasionally be seen on his police ID. This ambiguity surrounding Columbo's first name led to the creator of The Trivia Encyclopedia, Fred L. Worth, to include a false entry that listed 'Phillip Columbo' as Columbo's full name as a copyright trap. When the board game Trivial Pursuit included 'Phillip' as the answer to the question, 'What was Columbo's first name?', Worth launched a 300 million dollar lawsuit against the creators of the game.[46][47] The creators of the game argued that while they did use The Trivia Encyclopedia as one of their sources, facts are not copyrightable and there was nothing improper about using an encyclopedia in the production of a fact-based game. The district court judge agreed and the decision was upheld by the United States Court of Appeals for the Ninth Circuit in September 1987. Worth asked the Supreme Court of the United States to review the case, but the Court declined, denying certiorari in March 1988. ",
                    DeathIllness = "Death illness Text",
                DistributionDetails = "",
                AdditionalInformation = @"Specifies the hosting plan that defines how resources are allocated to your function app. In the default Consumption plan, resources are added dynamically as required by your functions. In this serverless hosting model, you only pay for the time your functions run.",
                IsClosed = false,
                
                ReferenceNo = "R1234-A1234",
                LADetails = "Local Authority text field"
            },
            new SimsOnlineForm
            {
                Title = "Sedond round",
                NotifierTypeId=5,
                Description = @"Specifies the name of the new storage account used by your function app (which does not need to match the globally unique name that you specified for your function). Storage account names must be between 3 and 24 characters in length and may contain numbers and lowercase letters only. This dialog automatically populates the field with a unique name that is dynamically generated. However, feel free to use a different name or even an existing account.",
                Action = "Action to be placed, or has placed",
                DeathIllness = "Death illness Text",
                DistributionDetails = @"At the beginning of every episode, Columbo's genius was hidden by his frumpy, friendly and disarming demeanor, luring the killer into a false sense of security. In some cases, the killer's arrogance and dismissive attitude allow Columbo to manipulate his suspects into self-incrimination. While the details, and eventually the motivation(s), of the murderers' actions are shown to the viewer, Columbo's true thoughts and intentions are almost never revealed until close to the end of the episode (he occasionally begins to whistle the tune 'This Old Man' as the pieces begin to fall into place). Columbo generally maintains a friendly relationship with the murderer until the end. The point at which the detective first begins to suspect the murderer is generally not revealed, although it is often fairly early on. Columbo had a duality of character; the disarming and unkempt detective and the hidden genius sleuth. The genius would sometimes starkly manifest itself through his eyes as it did when Jack Cassidy’s killer escaped from the handcuffs in his magic show. Such moments always bode bad tidings for the killer. In some instances, such as Ruth Gordon's avenging elderly mystery writer in 'Try and Catch Me', Janet Leigh's terminally ill and deluded actress in 'Forgotten Lady', Donald Pleasence's elegant vintner in 'Any Old Port in a Storm', and Johnny Cash's enserfed singer in 'Swan Song', the killer is more sympathetic than the victim.[14] ",
                AdditionalInformation = "",
                IsClosed = false,
                
                ReferenceNo = "RABCDE",
                LADetails = "Local Authority text field"
            },
            new SimsOnlineForm
            {
                Title = "More Complatin",
                NotifierTypeId=3,
                Description = @"Murder, She Wrote is an American crime drama television series starring Angela Lansbury as mystery writer and amateur detective Jessica Fletcher.[4][5] The series aired for 12 seasons with 264 episodes from 1984 to 1996 on the CBS network. It was followed by four TV films. Among the most successful and longest-running television shows in history, it averaged more than 30 million viewers per week in its prime (sometimes hitting above 40 million viewers), and was a staple of the CBS Sunday night lineup for a decade.[6] In syndication, the series is still highly successful throughout the world. ",
                Action = @"For her work on Murder, She Wrote, Lansbury was nominated for ten Golden Globes and 12 Emmy Awards, winning four Golden Globe awards. She holds the record for the most Golden Globe nominations and wins for Best Actress in a television drama series and the most Emmy nominations for Outstanding Lead Actress in a Drama Series. The series received three Emmy nominations for Outstanding Drama Series. It was nominated for a Golden Globe in the same category six times and won twice. ",
                DeathIllness = "Death illness Text",
                DistributionDetails = "Details deatisls details",
                AdditionalInformation = @"Series producers Peter S. Fischer, Richard Levinson and William Link thought Lansbury would be perfect for the part of Jessica Fletcher but did not think that she would be interested in a television series. Earlier, she had acted in two film adaptations of Agatha Christie's mystery novels: as Salome Otterbourne in Death on the Nile and as Miss Marple in The Mirror Crack'd (1980). When the latter film did poorly—despite an all star cast including Rock Hudson, Elizabeth Taylor, Kim Novak, and Tony Curtis—the offer for Lansbury to reprise Miss Marple in three more films never materialized.[9] ",
                IsClosed = false,
                
                ReferenceNo = "RJessica-Fletcher",
                LADetails = "Local Authority text field"
            },
            new SimsOnlineForm
            {
                Title = "Third round of the problems",
                NotifierTypeId=3,
                Description = "Description of basic complaint",
                Action = "Action to be placed, or has placed",
                DeathIllness = "Death illness Text",
                DistributionDetails = "Where did this get done didded",
                AdditionalInformation = "Anything else I added",
                IsClosed = false,
                
                ReferenceNo = "R1234",
                LADetails = "Local Authority text field"
            },
            new SimsOnlineForm
            {
                Title = "This is something from the online wqorld",
                NotifierTypeId=5,
                Description = @"Columbo is a shrewd but inelegant blue-collar homicide detective whose trademarks include his rumpled beige raincoat, unassuming demeanor, cigar, old Peugeot 403 car, unseen wife (whom he mentions regularly), and catchphrase 'Just one more thing.'

The recurring plot's homicide suspects are uniformly clever, wealthy, and elite, setting up a class conflict as part of each episode.[4] Suspects carefully cover their tracks and are initially dismissive of Columbo's circumstantial speech and apparent ineptitude. They become increasingly unsettled as his pestering behavior teases out incriminating evidence. [4] His relentless approach often leads to self-incrimination or outright confession. ",
                Action = "Action to be placed, or has placed",
                DeathIllness = "Death illness Text",
                DistributionDetails = "Distribution",
                AdditionalInformation = @"Episodes of Columbo are between 70 and 98 minutes long, and have been broadcast in 44 countries. The 1971 episode 'Murder by the Book', directed by Steven Spielberg, was ranked No. 16 on TV Guide's 100 Greatest Episodes of All-Time[5] and in 1999, the magazine ranked Lt. Columbo No. 7 on its 50 Greatest TV Characters of All Time list.[6][7] In 2012, the program was ranked the third-best cop or legal show on Best in TV: The Greatest TV Shows of Our Time.[8] In 2013, TV Guide included it in its list of The 60 Greatest Dramas of All Time[9] and ranked it 33rd on its list of the 60 Best Series.[10] Also in 2013, the Writers Guild of America ranked it 57th on its list of 101 Best Written TV Series.[11]",
                IsClosed = false,
                
                ReferenceNo = "RABCDE",
                LADetails = "Local Authority text field"
            },
            new SimsOnlineForm
            {
                Title = "Qyeye up round up data",
                NotifierTypeId=2,
                Description = "Description Text",
                Action = @"The Trivia Encyclopedia lawsuit
                Columbo's first name is notably never mentioned in the series, but 'Frank Columbo' or 'Lt. Frank Columbo' can occasionally be seen on his police ID. This ambiguity surrounding Columbo's first name led to the creator of The Trivia Encyclopedia, Fred L. Worth, to include a false entry that listed 'Phillip Columbo' as Columbo's full name as a copyright trap. When the board game Trivial Pursuit included 'Phillip' as the answer to the question, 'What was Columbo's first name?', Worth launched a 300 million dollar lawsuit against the creators of the game.[46][47] The creators of the game argued that while they did use The Trivia Encyclopedia as one of their sources, facts are not copyrightable and there was nothing improper about using an encyclopedia in the production of a fact-based game. The district court judge agreed and the decision was upheld by the United States Court of Appeals for the Ninth Circuit in September 1987. Worth asked the Supreme Court of the United States to review the case, but the Court declined, denying certiorari in March 1988. ",
                    DeathIllness = "Death illness Text",
                DistributionDetails = "",
                AdditionalInformation = @"Specifies the hosting plan that defines how resources are allocated to your function app. In the default Consumption plan, resources are added dynamically as required by your functions. In this serverless hosting model, you only pay for the time your functions run.",
                IsClosed = false,
                
                ReferenceNo = "R1234-A1234",
                LADetails = "Local Authority text field"
            },
            new SimsOnlineForm
            {
                Title = "Set the more data to stun",
                NotifierTypeId=5,
                Description = @"Specifies the name of the new storage account used by your function app (which does not need to match the globally unique name that you specified for your function). Storage account names must be between 3 and 24 characters in length and may contain numbers and lowercase letters only. This dialog automatically populates the field with a unique name that is dynamically generated. However, feel free to use a different name or even an existing account.",
                Action = "Action to be placed, or has placed",
                DeathIllness = "Death illness Text",
                DistributionDetails = @"At the beginning of every episode, Columbo's genius was hidden by his frumpy, friendly and disarming demeanor, luring the killer into a false sense of security. In some cases, the killer's arrogance and dismissive attitude allow Columbo to manipulate his suspects into self-incrimination. While the details, and eventually the motivation(s), of the murderers' actions are shown to the viewer, Columbo's true thoughts and intentions are almost never revealed until close to the end of the episode (he occasionally begins to whistle the tune 'This Old Man' as the pieces begin to fall into place). Columbo generally maintains a friendly relationship with the murderer until the end. The point at which the detective first begins to suspect the murderer is generally not revealed, although it is often fairly early on. Columbo had a duality of character; the disarming and unkempt detective and the hidden genius sleuth. The genius would sometimes starkly manifest itself through his eyes as it did when Jack Cassidy’s killer escaped from the handcuffs in his magic show. Such moments always bode bad tidings for the killer. In some instances, such as Ruth Gordon's avenging elderly mystery writer in 'Try and Catch Me', Janet Leigh's terminally ill and deluded actress in 'Forgotten Lady', Donald Pleasence's elegant vintner in 'Any Old Port in a Storm', and Johnny Cash's enserfed singer in 'Swan Song', the killer is more sympathetic than the victim.[14] ",
                AdditionalInformation = "",
                IsClosed = false,
                
                ReferenceNo = "RABCDE",
                LADetails = "Local Authority text field"
            },
            new SimsOnlineForm
            {
                Title = "Right said fred",
                NotifierTypeId=3,
                Description = @"Murder, She Wrote is an American crime drama television series starring Angela Lansbury as mystery writer and amateur detective Jessica Fletcher.[4][5] The series aired for 12 seasons with 264 episodes from 1984 to 1996 on the CBS network. It was followed by four TV films. Among the most successful and longest-running television shows in history, it averaged more than 30 million viewers per week in its prime (sometimes hitting above 40 million viewers), and was a staple of the CBS Sunday night lineup for a decade.[6] In syndication, the series is still highly successful throughout the world. ",
                Action = @"For her work on Murder, She Wrote, Lansbury was nominated for ten Golden Globes and 12 Emmy Awards, winning four Golden Globe awards. She holds the record for the most Golden Globe nominations and wins for Best Actress in a television drama series and the most Emmy nominations for Outstanding Lead Actress in a Drama Series. The series received three Emmy nominations for Outstanding Drama Series. It was nominated for a Golden Globe in the same category six times and won twice. ",
                DeathIllness = "Death illness Text",
                DistributionDetails = "Details deatisls details",
                AdditionalInformation = @"Series producers Peter S. Fischer, Richard Levinson and William Link thought Lansbury would be perfect for the part of Jessica Fletcher but did not think that she would be interested in a television series. Earlier, she had acted in two film adaptations of Agatha Christie's mystery novels: as Salome Otterbourne in Death on the Nile and as Miss Marple in The Mirror Crack'd (1980). When the latter film did poorly—despite an all star cast including Rock Hudson, Elizabeth Taylor, Kim Novak, and Tony Curtis—the offer for Lansbury to reprise Miss Marple in three more films never materialized.[9] ",
                IsClosed = false,
                
                ReferenceNo = "RJessica-Fletcher",
                LADetails = "Local Authority text field"
            },
            new SimsOnlineForm
            {
                Title = "Incautious db updates",
                NotifierTypeId=3,
                Description = "Description of basic complaint",
                Action = "Action to be placed, or has placed",
                DeathIllness = "Death illness Text",
                DistributionDetails = "Where did this get done didded",
                AdditionalInformation = "Anything else I added",
                IsClosed = false,
                
                ReferenceNo = "R1234",
                LADetails = "Local Authority text field"
            },
            new SimsOnlineForm
            {
                Title = "This is a problem I dfoundd",
                NotifierTypeId=5,
                Description = @"Columbo is a shrewd but inelegant blue-collar homicide detective whose trademarks include his rumpled beige raincoat, unassuming demeanor, cigar, old Peugeot 403 car, unseen wife (whom he mentions regularly), and catchphrase 'Just one more thing.'

The recurring plot's homicide suspects are uniformly clever, wealthy, and elite, setting up a class conflict as part of each episode.[4] Suspects carefully cover their tracks and are initially dismissive of Columbo's circumstantial speech and apparent ineptitude. They become increasingly unsettled as his pestering behavior teases out incriminating evidence. [4] His relentless approach often leads to self-incrimination or outright confession. ",
                Action = "Action to be placed, or has placed",
                DeathIllness = "Death illness Text",
                DistributionDetails = "Distribution",
                AdditionalInformation = @"Episodes of Columbo are between 70 and 98 minutes long, and have been broadcast in 44 countries. The 1971 episode 'Murder by the Book', directed by Steven Spielberg, was ranked No. 16 on TV Guide's 100 Greatest Episodes of All-Time[5] and in 1999, the magazine ranked Lt. Columbo No. 7 on its 50 Greatest TV Characters of All Time list.[6][7] In 2012, the program was ranked the third-best cop or legal show on Best in TV: The Greatest TV Shows of Our Time.[8] In 2013, TV Guide included it in its list of The 60 Greatest Dramas of All Time[9] and ranked it 33rd on its list of the 60 Best Series.[10] Also in 2013, the Writers Guild of America ranked it 57th on its list of 101 Best Written TV Series.[11]",
                IsClosed = false,
                
                ReferenceNo = "RABCDE",
                LADetails = "Local Authority text field"
            },
            new SimsOnlineForm
            {
                Title = "Why can I not type without a spelling mistake.",
                NotifierTypeId=2,
                Description = "Description Text",
                Action = @"The Trivia Encyclopedia lawsuit
                Columbo's first name is notably never mentioned in the series, but 'Frank Columbo' or 'Lt. Frank Columbo' can occasionally be seen on his police ID. This ambiguity surrounding Columbo's first name led to the creator of The Trivia Encyclopedia, Fred L. Worth, to include a false entry that listed 'Phillip Columbo' as Columbo's full name as a copyright trap. When the board game Trivial Pursuit included 'Phillip' as the answer to the question, 'What was Columbo's first name?', Worth launched a 300 million dollar lawsuit against the creators of the game.[46][47] The creators of the game argued that while they did use The Trivia Encyclopedia as one of their sources, facts are not copyrightable and there was nothing improper about using an encyclopedia in the production of a fact-based game. The district court judge agreed and the decision was upheld by the United States Court of Appeals for the Ninth Circuit in September 1987. Worth asked the Supreme Court of the United States to review the case, but the Court declined, denying certiorari in March 1988. ",
                    DeathIllness = "Death illness Text",
                DistributionDetails = "",
                AdditionalInformation = @"Specifies the hosting plan that defines how resources are allocated to your function app. In the default Consumption plan, resources are added dynamically as required by your functions. In this serverless hosting model, you only pay for the time your functions run.",
                IsClosed = false,
                
                ReferenceNo = "R1234-A1234",
                LADetails = "Local Authority text field"
            },
            new SimsOnlineForm
            {
                Title = "Cellophane",
                NotifierTypeId=5,
                Description = @"Specifies the name of the new storage account used by your function app (which does not need to match the globally unique name that you specified for your function). Storage account names must be between 3 and 24 characters in length and may contain numbers and lowercase letters only. This dialog automatically populates the field with a unique name that is dynamically generated. However, feel free to use a different name or even an existing account.",
                Action = "Action to be placed, or has placed",
                DeathIllness = "Death illness Text",
                DistributionDetails = @"At the beginning of every episode, Columbo's genius was hidden by his frumpy, friendly and disarming demeanor, luring the killer into a false sense of security. In some cases, the killer's arrogance and dismissive attitude allow Columbo to manipulate his suspects into self-incrimination. While the details, and eventually the motivation(s), of the murderers' actions are shown to the viewer, Columbo's true thoughts and intentions are almost never revealed until close to the end of the episode (he occasionally begins to whistle the tune 'This Old Man' as the pieces begin to fall into place). Columbo generally maintains a friendly relationship with the murderer until the end. The point at which the detective first begins to suspect the murderer is generally not revealed, although it is often fairly early on. Columbo had a duality of character; the disarming and unkempt detective and the hidden genius sleuth. The genius would sometimes starkly manifest itself through his eyes as it did when Jack Cassidy’s killer escaped from the handcuffs in his magic show. Such moments always bode bad tidings for the killer. In some instances, such as Ruth Gordon's avenging elderly mystery writer in 'Try and Catch Me', Janet Leigh's terminally ill and deluded actress in 'Forgotten Lady', Donald Pleasence's elegant vintner in 'Any Old Port in a Storm', and Johnny Cash's enserfed singer in 'Swan Song', the killer is more sympathetic than the victim.[14] ",
                AdditionalInformation = "",
                IsClosed = false,
                
                ReferenceNo = "RABCDE",
                LADetails = "Local Authority text field"
            },
            new SimsOnlineForm
            {
                Title = "Broken food item in closet",
                NotifierTypeId=3,
                Description = @"Murder, She Wrote is an American crime drama television series starring Angela Lansbury as mystery writer and amateur detective Jessica Fletcher.[4][5] The series aired for 12 seasons with 264 episodes from 1984 to 1996 on the CBS network. It was followed by four TV films. Among the most successful and longest-running television shows in history, it averaged more than 30 million viewers per week in its prime (sometimes hitting above 40 million viewers), and was a staple of the CBS Sunday night lineup for a decade.[6] In syndication, the series is still highly successful throughout the world. ",
                Action = @"For her work on Murder, She Wrote, Lansbury was nominated for ten Golden Globes and 12 Emmy Awards, winning four Golden Globe awards. She holds the record for the most Golden Globe nominations and wins for Best Actress in a television drama series and the most Emmy nominations for Outstanding Lead Actress in a Drama Series. The series received three Emmy nominations for Outstanding Drama Series. It was nominated for a Golden Globe in the same category six times and won twice. ",
                DeathIllness = "Death illness Text",
                DistributionDetails = "Details deatisls details",
                AdditionalInformation = @"Series producers Peter S. Fischer, Richard Levinson and William Link thought Lansbury would be perfect for the part of Jessica Fletcher but did not think that she would be interested in a television series. Earlier, she had acted in two film adaptations of Agatha Christie's mystery novels: as Salome Otterbourne in Death on the Nile and as Miss Marple in The Mirror Crack'd (1980). When the latter film did poorly—despite an all star cast including Rock Hudson, Elizabeth Taylor, Kim Novak, and Tony Curtis—the offer for Lansbury to reprise Miss Marple in three more films never materialized.[9] ",
                IsClosed = false,
                
                ReferenceNo = "RJessica-Fletcher",
                LADetails = "Local Authority text field"
            }
        };

        public IEnumerable<SimsStakeholder> GetOnlineFormStakeholders => new[]
        {
           new SimsStakeholder
            {
                DiscriminatorId = 3,
                HostId = 1,
                Name = "Sally Stakeholder",
                GovDept = "Onlineing",
                Phone = "012345 789",
                Role = "Dancing instructor",
            },
           new SimsStakeholder
            {
                DiscriminatorId = 1,
                HostId = 2,
                Name = "Jeremy Smith",
                GovDept = "",
                Phone = "012345 789",
                Role = "Admin",
            },
           new SimsStakeholder
            {
                DiscriminatorId = 2,
                HostId = 3,
                Name = "Henry plate",
                GovDept = "",
                Phone = "012345 789",
                Email = "Email@1",
                Role = "Admin",
            },
            new SimsStakeholder
            {
                DiscriminatorId = 1,
                HostId = 4,
                Name = "Mavis Coupe",
                GovDept = "",
                Phone = "012345 789",
                Email = "Email@1",
                Role = "Roling",
            },
            new SimsStakeholder
            {
                DiscriminatorId = 2,
                HostId = 5,
                Name = "Jame flan",
                GovDept = "",
                Phone = "12345",
                Email = "Email@jameflan.com",
                Role = "Communicatios",
            },
      new SimsStakeholder
            {
                DiscriminatorId = 3,
                HostId = 1,
                Name = "Stephen Stakeholder",
                GovDept = "Onlineing",
                Phone = "012345 789",
                Role = "Dancing instructor",
            },
           new SimsStakeholder
            {
                DiscriminatorId = 1,
                HostId = 2,
                Name = "Karent Stakeholder",
                GovDept = "",
                Phone = "012345 789",
                Role = "Admin",
            },
           new SimsStakeholder
            {
                DiscriminatorId = 2,
                HostId = 3,
                Name = "Pickle Stakegolder",
                GovDept = "",
                Phone = "012345 789",
                Email = "Email@1",
                Role = "Admin",
            },
            new SimsStakeholder
            {
                DiscriminatorId = 1,
                HostId = 4,
                Name = "Golden Stakeholder",
                GovDept = "",
                Phone = "012345 789",
                Email = "Email@1",
                Role = "Roling",
            },
            new SimsStakeholder
            {
                DiscriminatorId = 2,
                HostId = 5,
                Name = "Celebration Stakeholder",
                GovDept = "",
                Phone = "12345",
                Email = "Email@jameflan.com",
                Role = "Communicatios",
            },
      new SimsStakeholder
            {
                DiscriminatorId = 3,
                HostId = 1,
                Name = "Trouble the Stakeholder",
                GovDept = "Onlineing",
                Phone = "012345 789",
                Role = "Dancing instructor",
            },
           new SimsStakeholder
            {
                DiscriminatorId = 1,
                HostId = 2,
                Name = "Courdry Stakeholder",
                GovDept = "",
                Phone = "012345 789",
                Role = "Admin",
            },
           new SimsStakeholder
            {
                DiscriminatorId = 2,
                HostId = 3,
                Name = "Restless Stakegolder",
                GovDept = "",
                Phone = "012345 789",
                Email = "Email@1",
                Role = "Admin",
            },
            new SimsStakeholder
            {
                DiscriminatorId = 1,
                HostId = 4,
                Name = "Woebegotten Stakeholder",
                GovDept = "",
                Phone = "012345 789",
                Email = "Email@1",
                Role = "Roling",
            },
            new SimsStakeholder
            {
                DiscriminatorId = 2,
                HostId = 5,
                Name = "Fashion nose Stakeholder",
                GovDept = "",
                Phone = "12345",
                Email = "Email@jameflan.com",
                Role = "Communicatios",
            },
        };

        public IEnumerable<SimsProduct> GetOnlineFormProducts => new[]
        {
            new SimsProduct
            {
                Name = "Bourbon biscuits",
                Brand = "McBiscuits",
                Amount = "5.53",
                AmountUnitTypeId = 1,
                PackDescription = "This is a new packet",
                HostId = 1,
                CountryOfOriginId = 28,
                ProductTypeId =8,
                BatchCodes = "bb1, bb2, bb3",
                AdditionalInfo = "Some more info",
                PackSizes = new List<SimsProductPackSize> { new SimsProductPackSize { Size = "12", UnitId = 24} },
                ProductDates = new List<SimsProductDate> { new SimsProductDate { DateTypeId = 1, Date = DateTime.Now } }
            },
            new SimsProduct
            {
                Name = "Sticky biscuits",
                Brand = "McBiscuits",
                Amount = "8",
                AmountUnitTypeId = 8,
                PackDescription = "mmmm sticky biscuits",
                HostId = 1,
                CountryOfOriginId = 47,
                BatchCodes = "sb1, sb2, sb14",
                ProductTypeId =12,
                //DataSourceId = 2,
                AdditionalInfo = "Some more info",
                PackSizes = new List<SimsProductPackSize> { new SimsProductPackSize { Size = "1", UnitId = 23 } },
                ProductDates = new List<SimsProductDate> { new SimsProductDate { DateTypeId = 1, Date = DateTime.Now } }
            },
            new SimsProduct
            {
                Name = "Chocolate biscuits",
                Brand = "McBiscuits",
                Amount = "120",
                AmountUnitTypeId = 10,
                PackDescription = "yucky",
                HostId = 2,
                ProductTypeId =14,
                CountryOfOriginId = 28,
                BatchCodes = "cbasdasd-1212, cb-2332423324-1231212",
                AdditionalInfo = "eomthing",
                PackSizes = new List<SimsProductPackSize> { new SimsProductPackSize { Size = "12", UnitId = 21 },
                    new SimsProductPackSize { Size = "8", UnitId = 19 },
                                new SimsProductPackSize { Size = "0.1", UnitId = 22 } },
                ProductDates = new List<SimsProductDate> {
                        new SimsProductDate { DateTypeId = 1, Date = DateTime.Now }
                        ,new SimsProductDate { DateTypeId = 2, Date = DateTime.Now }
                        ,new SimsProductDate { DateTypeId = 3, Date = DateTime.Now }
                }
            },
            new SimsProduct
            {
                Name = "Blue ham",
                Brand = "Ham man",
                Amount = "47",
                AmountUnitTypeId = 9,
                PackDescription = "Long john ham gone",
                HostId = 3,
                ProductTypeId =10,
                CountryOfOriginId = 18,
                BatchCodes = "Code 01, ode02",
                AdditionalInfo = "",
                PackSizes = new List<SimsProductPackSize> { new SimsProductPackSize { Size = "12", UnitId = 11 },
                    new SimsProductPackSize { Size = "8", UnitId = 19 },
                    new SimsProductPackSize { Size = "0.1", UnitId = 20 } },
                ProductDates = new List<SimsProductDate> {
                        new SimsProductDate { DateTypeId = 1, Date = DateTime.Now }
                        ,new SimsProductDate { DateTypeId = 2, Date = DateTime.Now }
                        ,new SimsProductDate { DateTypeId = 3, Date = DateTime.Now }
                }
            },
            new SimsProduct
            {
                Name = "Squash",
                Brand = "Mister Squash",
                Amount = "47",
                AmountUnitTypeId = 9,
                PackDescription = "Long john ham gone",
                HostId = 4,
                ProductTypeId =10,
                CountryOfOriginId = 18,
                BatchCodes = "Code 01, ode02",
                AdditionalInfo = "",
                PackSizes = new List<SimsProductPackSize> { new SimsProductPackSize { Size = "12", UnitId = 11 },
                    new SimsProductPackSize { Size = "8", UnitId = 19 },
                    new SimsProductPackSize { Size = "0.1", UnitId = 20 } },
                ProductDates = new List<SimsProductDate> {
                        new SimsProductDate { DateTypeId = 1, Date = DateTime.Now }
                        ,new SimsProductDate { DateTypeId = 2, Date = DateTime.Now }
                        ,new SimsProductDate { DateTypeId = 3, Date = DateTime.Now }
                }
            }
        };
    }
}
