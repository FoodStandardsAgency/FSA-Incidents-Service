using AutoMapper;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Repositories;
using SIMS.TestProjects.Setup;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace SIMS.Database
{
    public class SignalNotesTesting
    {
        private IMapper mapper;
        private string conn;
        private string userId;

        public SignalNotesTesting()
        {

            var seedInfo = new SeedingConfigData();
            this.mapper = seedInfo.GetDbAutoMapper();
            var config = seedInfo.GetConfigData();
            this.conn = ((JsonElement)config["ConnectionStrings:FSADbConn"]).ToString();
            this.userId = seedInfo.userIds[0];
        }

        [Fact(DisplayName = "Signal add note")]
        public async Task AddNote()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                SimsNote newNote = new SimsNote
                {
                    Note = "Signal note added!"
                };

                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var addedNote = await simsHost.Signals.Notes.Add(1, newNote.Note,(1+2+4+32));
                Assert.True(addedNote.HostId == 1 && addedNote.Note == newNote.Note && 39 == (int)addedNote.Tags);
            }
        }


        [Fact(DisplayName = "Signal get note")]
        public async Task GetNote()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = SimsDbHost.CreateHost(ctx, this.mapper, this.userId);
                var notes = await simsHost.Signals.Notes.GetAll(1);
                Assert.True(notes.ToList().Count > 0);

            }
        }

    }

}
