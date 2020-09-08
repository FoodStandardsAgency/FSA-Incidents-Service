using AutoMapper;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.SIMSManagerDb.Repositories;
using SIMS.TestProjects.Setup;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace SIMS.Database
{
    public class SignalsTesting
    {
        private IMapper mapper;
        private string userId;
        private string anotherId;
        private string userId3;
        private string miller;
        private string conn;

        public SignalsTesting()
        {
            var seedInfo = new SeedingConfigData();
            this.mapper = seedInfo.GetDbAutoMapper();
            this.userId = seedInfo.userIds[0];
            this.anotherId = seedInfo.userIds[1];
            this.userId3 = seedInfo.userIds[2];
            this.miller = seedInfo.userIds[3];
            var config = seedInfo.GetConfigData();
            this.conn = ((JsonElement)config["ConnectionStrings:FSADbConn"]).ToString();
        }

        [Fact(DisplayName = "Add Signal with No SPT")]
        public async Task AddSignalNoSPT()
        {
            var Signal = new SimsSignal
            {
                Title = "Cheesecake ALERT! No Cheese too much cake. 1 Man Swooned",
                SignalStatusId = 0,
                Priority = "HIGH",
                LeadOfficer = "",
                CountryOfOrigin = "GB",
                NotifyingCountry = "UK",
                IsEu = false,
                BaseProduct = "Cheese",
                Manufacturer = "Mister cake",
                FoodOrFeed = "food",
                Hazard = "involutnary Swooning",
                HazardGroup = "Panic",
                DataSource = "Food_Poisoning_Bulletin",
                SourceType = "Others",
                PublishedDate = DateTime.Parse("2020-08-19"),
                InsertedDate = DateTime.Parse("2020-08-20"),
                SourceLink = "https://foodpoisoningbulletin.com/2020/maison-terre-goldenseal-root-powder-recalled-one-infant-has-died/"
            };

            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var savedSignal = await simsHost.Signals.Add(Signal);
                //Assert.True(savedSignal.MostUniqueId != Guid.Empty);
            }
        }

        [Fact(DisplayName = "Update")]
        public async Task UpdateSignal()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var signal = await simsHost.Signals.Get(23);
                signal.Title = "Cheesecake ALERT!";
                var savedSignal = await simsHost.Signals.Update(signal);
                //Assert.True(savedSignal.MostUniqueId != Guid.Empty);
            }
        }

        [Fact(DisplayName = "Update Attempt to set SPT")]
        public async Task UpdateSignalSPT()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var signal = await simsHost.Signals.Get(13);
                signal.Title = "Cheesecake ALERT!";
                signal.SPTId = 24;
                await Assert.ThrowsAsync<ArgumentOutOfRangeException>(async () => await simsHost.Signals.Update(signal));
            }
        }

        [Fact(DisplayName = "Update attempt to set publishedDate")]
        public async Task UpdatePublished()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var signal = await simsHost.Signals.Get(13);
                signal.Title = "Cheesecake ALERT!";
                signal.PublishedDate = DateTime.Parse("01/01/2020");
                await Assert.ThrowsAsync<ArgumentOutOfRangeException>(async () => await simsHost.Signals.Update(signal));
            }
        }

        [Fact(DisplayName = "Update attempt to set inserted date")]
        public async Task UpdateInserted()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var signal = await simsHost.Signals.Get(13);
                signal.Title = "Cheesecake ALERT!";
                signal.InsertedDate = DateTime.Parse("01/01/2020");
                await Assert.ThrowsAsync<ArgumentOutOfRangeException>(async () => await simsHost.Signals.Update(signal));
            }
        }

        [Fact(DisplayName = "Get Signla")]
        public async Task Get()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var signal = await simsHost.Signals.Get(42);
                Assert.True(signal != null && signal.Title.Length > 0);
            }
        }

        [Fact(DisplayName="Exists")]
        public async Task Exists()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var signalExists = await simsHost.Signals.Exists(2);
                Assert.True(signalExists);
            }
        }
        [Fact(DisplayName="Does not exist")]
        public async Task DoesNotExist()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var signalExists = await simsHost.Signals.Exists(99999);
                Assert.False(signalExists);
            }
        }

        [Fact]
        public async Task Closed()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                /// Get a thing and definately close it
                var signalClose = await simsHost.Signals.Get(18);
                signalClose.SignalStatusId = (int)SimsSignalStatusTypes.Closed_Incident;
                await simsHost.Signals.Update(signalClose);
                var signalClosed = await simsHost.Signals.IsClosed(18);
                Assert.True(signalClosed);
            }
        }

        [Fact(DisplayName = "Is not closed")]
        public async Task NotClosed()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var signalNotClosed = await simsHost.Signals.Exists(19);
                Assert.True(signalNotClosed);
            }
        }

    }
}
