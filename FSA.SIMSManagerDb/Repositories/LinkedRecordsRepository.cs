using AutoMapper;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities.Core;
using FSA.SIMSManagerDbEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    internal class LinkedRecordsRepository<LinkDb, NoteDb> : IDbLinkedRecordsRepository
                        where LinkDb : BaseLinkDb, new()
                        where NoteDb : BaseNoteDb, new()
    {
        private readonly SimsDbContext ctx;

        public DbSet<LinkDb> LinkSet { get; }
        public DbSet<NoteDb> NoteSet { get; }

        private readonly IMapper mapper;
        // This class is used for signals/incidents/Whatever comes next
        // Each of them has a slightly different way of displaying the id (Prefix)
        // When we write a note detaiing a change to a linked signal/new incident the correct public version of the id must be displayed.
        // hence why a int->string func is injected as as service...
        private readonly Func<int, string> publicIdGenerator;

        public LinkedRecordsRepository(SimsDbContext ctx, IMapper mapper, Func<int, string> publicIdGenerator)
        {
            this.ctx = ctx;
            this.LinkSet = ctx.Set<LinkDb>();
            this.NoteSet = ctx.Set<NoteDb>();
            this.mapper = mapper;
            this.publicIdGenerator = publicIdGenerator;
        }


        public async Task<SimsLinkedRecord> Remove(int from, int to)
        {
            // LOcal functions fancy.
            // Cos the logic is annoying and I'm not confident in it yet.
            // Why should we update the host object?
            async Task<SimsLinkedRecord> DeleteLink(LinkDb link)
            {
                this.LinkSet.Remove(link);
                //var fromIncident = this.LinkSet.Find(link.FromId);
                //var toincident = this.LinkSet.Find(link.ToId);

                await ctx.SaveChangesAsync();
                return new SimsLinkedRecord { From = from, To = to };
            }

            var linkData = this.LinkSet.Find(from, to);
            if (linkData == null)
            {
                // try the other way instead to-from
                linkData = this.LinkSet.Find(to, from);
            }
            if (linkData != null)
                return await DeleteLink(linkData);
            else return new SimsLinkedRecord { From = 0, To = 0 };
        }

        /// <summary>
        /// Joins two incidents
        /// As long as they have not already been joined.
        /// We check in both directions.
        /// The added links are returedn in flat list.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public async Task<IEnumerable<SimsLinkedRecord>> Add(int from, IEnumerable<int> tos, string reason)
        {

            var allTo = new HashSet<int>(tos);
            // ensure we are not trying to link to the same record
            allTo.Remove(from);

            List<SimsLinkedRecord> results = new List<SimsLinkedRecord>();
            // This is placed at the top of every note.
            var allStringToIds = allTo.Select(a => this.publicIdGenerator(a));
            string reasonFromHeader = $"Linked Records\n{from}\n{String.Join("\n", allStringToIds)}\nReason\n";
            // helper
            var updatesOccured = false;
            var allCreatedFrom = new HashSet<int>();

            foreach (var to in allTo)
            {
                var fromTo = this.LinkSet.AsNoTracking().FirstOrDefault(a => a.FromId == from && a.ToId == to);
                var toFrom = ctx.IncidentLinks.AsNoTracking().FirstOrDefault(a => a.FromId == to && a.ToId == from);
                // There is no match either side.
                if (fromTo == null && toFrom == null)
                {
                    var newLink = new LinkDb { FromId = from, ToId = to };
                    if (!string.IsNullOrEmpty(reason))
                    {
                        var newToComment = new NoteDb { Note = reasonFromHeader + reason, HostId = to, TagFlags = 1024 /*// Link Reason Notes Tag //*/ };
                        this.NoteSet.Add(newToComment);
                    }
                    updatesOccured = true;
                    this.LinkSet.Add(newLink);
                    // Required to populate the note on the TO side.
                    allCreatedFrom.Add(newLink.FromId);
                    results.Add(mapper.Map<LinkDb, SimsLinkedRecord>(newLink));
                }
            }
            // We musht have updated something
            // So ensure the from is updated too with all the linked records
            if (allTo.Count > 0 && updatesOccured)
            {

                var allStringFromIds = allCreatedFrom.Select(a => this.publicIdGenerator(a));
                string reasonToHeader = $"Linked Records\n{from}\n{String.Join("\n", allStringToIds)}\nReason\n";

                // Linked note also incides the record ids.
                var newFromComment = new NoteDb { Note = reasonToHeader + reason, HostId = from, TagFlags = 1024 /*// Link Reason Notes Tag //*/};
                this.NoteSet.Add(newFromComment);
            }
            await ctx.SaveChangesAsync();
            return results;

        }
        /// <summary>
        /// Returns all the links containing that record id
        /// </summary>
        /// <param name="hostId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<SimsLinkedRecord>> GetForHost(int hostId)
        {
            var allLinks = await this.LinkSet.AsNoTracking().Where(o => o.FromId == hostId || o.ToId == hostId).ToListAsync();
            return mapper.Map<IEnumerable<SimsLinkedRecord>>(allLinks);

        }

        public virtual async Task<IEnumerable<int>> GetRelatedCases(int hostId)
        {
            var itm = await this.ctx.SignalIncidentLinks.Where(a => a.SignalId == hostId).Select(a => a.IncidentId).ToListAsync();
            return itm;
        }
    }
}
