using AutoMapper;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Entities.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    class GeneralAttachmentsRepository<AttachmentDb> : IDbAttachmentsRepository where AttachmentDb : BaseAttachmentDb, new()
    {
        private readonly DbSet<AttachmentDb> DbSet;
        private readonly SimsDbContext ctx;
        private readonly IMapper mapper;

        public GeneralAttachmentsRepository(SimsDbContext ctx, IMapper mapper)
        {
            this.DbSet = ctx.Set<AttachmentDb>();
            this.ctx = ctx;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<(string fileUrl, DocumentTagTypes tags)>> GetAttachmentTags(int hostId)
        {
            var attachments = await this.DbSet.Where(o => o.HostId == hostId).ToListAsync();
            return attachments.Select(s => (s.DocUrl, s.TagFlags)).ToList();
        }

        public async Task UpdateAttachmentTags(int id, string docUrl, DocumentTagTypes tags)
        {
            //// Ensure we have a an incident
            //// tHE DOCUment is taken on faith alas.
            //var existing = this.ctx.Incidents.Find(id);
            //if (existing == null) throw new IncidentMissingException("Incident does not exist");
            //if (existing.IncidentStatusId == (int)IncidentStatusTypes.Closed) throw new IncidentClosedException("Incident is closed.");
            var existingAttachment = this.DbSet.Find(id, docUrl);
            if (existingAttachment != null)
            {
                existingAttachment.TagFlags = tags;
            }
            else
            {
                this.DbSet.Add(new AttachmentDb { HostId = id, DocUrl = docUrl, TagFlags = tags });
            }
            await ctx.SaveChangesAsync();
        }
    }
}
