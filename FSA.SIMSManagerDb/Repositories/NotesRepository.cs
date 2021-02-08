using AutoMapper;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities;
using FSA.SIMSManagerDb.Entities.Lookups;
using FSA.SIMSManagerDbEntities;
using FSA.SIMSManagerDbEntities.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    internal class NotesRepository<NoteDb> : IDbNotesRepository where NoteDb : BaseNoteDb, new()
    {
        private SimsDbContext ctx;
        private DbSet<NoteDb> NoteSet;
        private IMapper mapper;

        public NotesRepository(SimsDbContext ctx, IMapper mapper)
        {
            this.ctx = ctx;
            this.NoteSet = ctx.Set<NoteDb>();
            this.mapper = mapper;
        }
        /// <summary>
        /// Gets all the notes for a given incident.
        /// </summary>
        /// <param name="hostId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<SimsNote>> GetAll(int hostId)
        {
            var allNotes = await this.NoteSet.Where(o => o.HostId == hostId)
                                    .Select(a => this.mapper.Map<NoteDb, SimsNote>(a))
                                    .ToListAsync();
            return allNotes;
        }

        /// <summary>
        /// Add can be done in various situations Tags optional, but 0 must be atleast passed.
        /// </summary>
        /// <param name="hostId"></param>
        /// <param name="note"></param>
        /// <returns></returns>
        public async Task<SimsNote> Add(int hostId, string note, int tags)
        {
            var newComment = new NoteDb { Note = note, HostId = hostId, TagFlags = (NoteTagTypes)tags };
            this.NoteSet.Add(newComment);
            var incident = this.NoteSet.SingleOrDefault(p => p.Id == hostId);
            await ctx.SaveChangesAsync();
            return mapper.Map<NoteDb, SimsNote>(newComment);
        }

        public async Task<SimsNote> Update(int noteId, int tags)
        {
            var note = this.NoteSet.Find(noteId);
            note.TagFlags = (NoteTagTypes)tags;
            await ctx.SaveChangesAsync();
            return mapper.Map<NoteDb, SimsNote>(note);
        }

        /// <summary>
        /// Bulk insert of notes.
        /// </summary>
        /// <param name="hostId"></param>
        /// <param name="notes"></param>
        /// <returns></returns>
        public async Task BulkAdd(int hostId, IEnumerable<(string text, int tags)> notes)
        {
            foreach (var note in notes)
            {
                var newComment = new NoteDb { Note = note.text, TagFlags = (NoteTagTypes)note.tags, HostId = hostId };
                this.NoteSet.Add(newComment);
            }
            await ctx.SaveChangesAsync();
        }


    }
}
