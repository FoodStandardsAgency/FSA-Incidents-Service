using AutoMapper;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDbEntities;
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
        /// Insert comment can be done in various situations
        /// </summary>
        /// <param name="hostId"></param>
        /// <param name="note"></param>
        /// <returns></returns>
        public async Task<SimsNote> Add(int hostId, string note)
        {
            var newComment = new NoteDb { Note = note, HostId = hostId };
            this.NoteSet.Add(newComment);

            var incident = this.NoteSet.SingleOrDefault(p => p.Id == hostId);
            //if (incident.IncidentClosed == null)
            //    ctx.Incidents.Update(incident);

            await ctx.SaveChangesAsync();
            return mapper.Map<NoteDb, SimsNote>(newComment);
        }

    }
}
