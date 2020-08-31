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
        private readonly GeneralNotesRepository<IncidentNoteDb> incidentNotes;

        public IncidentNotesRepository(SimsDbContext ctx, IMapper mapper, SimsDbHost simsHost)
        {
            this.ctx = ctx;
            this.mapper = mapper;
            this.simsHost = simsHost;
            this.incidentNotes = new GeneralNotesRepository<IncidentNoteDb>(ctx, mapper);
        }

        public async Task<SimsNote> AddNote(int incidentId, string note)
        {
            var addedNote = await this.incidentNotes.AddNote(incidentId, note);
            // If the incident is *not* closed we upate it.
            var dbItem = await this.ctx.Incidents.FirstOrDefaultAsync(o => o.Id == incidentId && o.IncidentStatusId != (int)IncidentStatusTypes.Closed);
            if (dbItem != null)
                this.ctx.Incidents.Update(dbItem);
            return addedNote;
        }

        public Task<IEnumerable<SimsNote>> GetNotes(int incidentId) => this.incidentNotes.GetNotes(incidentId);
    }
}
