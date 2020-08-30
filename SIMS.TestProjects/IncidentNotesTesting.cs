using AutoMapper;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Repositories;
using SIMS.TestProjects.Setup;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace SIMS.Database
{
    public class IncidentNotesTesting
    {
        private IMapper mapper;
        private string conn;
        private string userId;

        public IncidentNotesTesting()
        {

            var seedInfo = new SeedingConfigData();
            this.mapper = seedInfo.GetDbAutoMapper();
            var config = seedInfo.GetConfigData();
            this.conn = ((JsonElement)config["ConnectionStrings:FSADbConn"]).ToString();
            this.userId = seedInfo.userIds[0];
        }

        [Fact(DisplayName = "Incident add note")]
        public async Task AddNote()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                SimsNote newNote = new SimsNote
                {
                    Note = "Incident note added!"
                };

                var simsHost = new SimsDbHost(ctx, this.mapper, this.userId);

                var addedNote = await simsHost.IncidentNotes.AddNote(16, newNote.Note);
                Assert.True(addedNote.HostId == 16 && addedNote.Note == newNote.Note);
            }
        }


        [Fact(DisplayName = "Incident get note")]
        public async Task GetNote()
        {
            using (var ctx = SeedingConfigData.GetDbContext(this.conn))
            {
                var simsHost = new SimsDbHost(ctx, this.mapper, this.userId);
                await simsHost.IncidentNotes.GetNotes(17);
            }
        }

    }

}
