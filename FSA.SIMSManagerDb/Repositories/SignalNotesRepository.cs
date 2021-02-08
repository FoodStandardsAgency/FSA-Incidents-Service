using AutoMapper;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    class SignalNotesRepository : IDbNotesRepository
    {
        private readonly SimsDbContext ctx;

        private readonly NotesRepository<SignalNoteDb> SignalNotes;

        public SignalNotesRepository(SimsDbContext ctx, IMapper mapper)
        {
            this.ctx = ctx;
            this.SignalNotes = new NotesRepository<SignalNoteDb>(ctx, mapper);
        }

        public async Task<SimsNote> Add(int SignalId, string note, int tags=0)
        {
            var addedNote = await this.SignalNotes.Add(SignalId, note, tags);
            // If the Signal is *not* closed we upate it.
            var dbItem = await this.ctx.Signals.FirstOrDefaultAsync(o => o.Id == SignalId && o.SignalStatusId < 50);
            if (dbItem != null)
                this.ctx.Signals.Update(dbItem);
            return addedNote;
        }

        public async Task BulkAdd(int signalId, IEnumerable<(string text, int tags)> notes)
        {
            await this.SignalNotes.BulkAdd(signalId, notes);
            // If the Signal is *not* closed we upate it.
            var dbItem = await this.ctx.Signals.FirstOrDefaultAsync(o => o.Id == signalId && o.SignalStatusId < 50);
            if (dbItem != null)
                this.ctx.Signals.Update(dbItem);
        }


        public async Task<SimsNote> Update(int noteId, int tags)
        {
            SimsNote note = await this.SignalNotes.Update(noteId, tags);
            var dbItem = await this.ctx.Signals.FirstOrDefaultAsync(o => o.Id == note.HostId && o.SignalStatusId < 50);
            if (dbItem != null)
                this.ctx.Signals.Update(dbItem);
            return note;
        }

        public Task<IEnumerable<SimsNote>> GetAll(int SignalId) => this.SignalNotes.GetAll(SignalId);
    }
}
