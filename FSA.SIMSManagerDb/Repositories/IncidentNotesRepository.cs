using AutoMapper;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities;
using FSA.SIMSManagerDbEntities.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    class IncidentNotesRepository : IDbNotesRepository
    {
        private readonly SimsDbContext ctx;
        private readonly IMapper mapper;
        private readonly SimsDbHost simsHost;
        private readonly NotesRepository<IncidentNoteDb> incidentNotes;

        public IncidentNotesRepository(SimsDbContext ctx, IMapper mapper, SimsDbHost simsHost)
        {
            this.ctx = ctx;
            this.mapper = mapper;
            this.simsHost = simsHost;
            this.incidentNotes = new NotesRepository<IncidentNoteDb>(ctx, mapper);
        }

        public async Task<SimsNote> Add(int incidentId, string note, int tags =0)
        {
            var addedNote = await this.incidentNotes.Add(incidentId, note,tags);
            // If the incident is *not* closed we upate it.
            var dbItem = await this.ctx.Incidents.FirstOrDefaultAsync(o => o.Id == incidentId && o.IncidentStatusId != (int)IncidentStatusTypes.Closed);
            if (dbItem != null)
                this.ctx.Incidents.Update(dbItem);
            return addedNote;
        }

        public async Task BulkAdd(int incidentId, IEnumerable<(string text, int tags)> notes)
        {
            await this.incidentNotes.BulkAdd(incidentId, notes);
            // If the incident is *not* closed we upate it.
            var dbItem = await this.ctx.Incidents.FirstOrDefaultAsync(o => o.Id == incidentId && o.IncidentStatusId != (int)IncidentStatusTypes.Closed);
            if (dbItem != null)
                this.ctx.Incidents.Update(dbItem);
        }

        
        public async Task<SimsNote> Update(int noteId, int tags)
        {
            SimsNote note =  await this.incidentNotes.Update(noteId, tags);
            var dbItem = await this.ctx.Incidents.FirstOrDefaultAsync(o => o.Id == note.HostId && o.IncidentStatusId != (int)IncidentStatusTypes.Closed);
            if (dbItem != null)
                this.ctx.Incidents.Update(dbItem);
            return note;
        }

        public Task<IEnumerable<SimsNote>> GetAll(int incidentId) => this.incidentNotes.GetAll(incidentId);
    }
}
