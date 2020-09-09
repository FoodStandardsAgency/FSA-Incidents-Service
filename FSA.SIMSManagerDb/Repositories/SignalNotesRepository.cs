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
    class SignalNotesRepository : IDbNotesRepository
    {
        private readonly SimsDbContext ctx;
        private readonly IMapper mapper;
        
        private readonly NotesRepository<SignalNoteDb> SignalNotes;

        public SignalNotesRepository(SimsDbContext ctx, IMapper mapper)
        {
            this.ctx = ctx;
            this.mapper = mapper;
            
            this.SignalNotes = new NotesRepository<SignalNoteDb>(ctx, mapper);
        }

        public async Task<SimsNote> Add(int SignalId, string note)
        {
            var addedNote = await this.SignalNotes.Add(SignalId, note);
            // If the Signal is *not* closed we upate it.
            var dbItem = await this.ctx.Signals.FirstOrDefaultAsync(o => o.Id == SignalId &&
                                    (o.SignalStatusId != (int)SignalStatusTypes.Closed_Incident
                                    || o.SignalStatusId != (int)SignalStatusTypes.Closed_No_Incident));
            if (dbItem != null)
                this.ctx.Signals.Update(dbItem);
            return addedNote;
        }

        public Task<IEnumerable<SimsNote>> GetAll(int SignalId) => this.SignalNotes.GetAll(SignalId);
    }
}
