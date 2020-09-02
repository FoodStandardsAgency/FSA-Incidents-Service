using AutoMapper;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities.Core;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<SimsAttachmentFileInfo> Add(string docUrl, int hostId)
        {
            var newItem = this.DbSet.Add(new AttachmentDb
            {
                DocUrl = docUrl,
                HostId = hostId,
                TagFlags = DocumentTagTypes.Unknown
            });

            await ctx.SaveChangesAsync();
            return mapper.Map<AttachmentDb, SimsAttachmentFileInfo>(newItem.Entity);
        }

        public async Task<IEnumerable<SimsAttachmentFileInfo>> Get(int hostId)
        {
            var attachments = await this.DbSet.Where(o => o.HostId == hostId).ToListAsync();
            return attachments.Select(s => mapper.Map<AttachmentDb, SimsAttachmentFileInfo>(s)).ToList();
        }

        public async Task Update(string docUrl, DocumentTagTypes tags)
        {
            //// Ensure we have a an incident
            //// tHE DOCUment is taken on faith alas.
            //var existing = this.ctx.Incidents.Find(id);
            //if (existing == null) throw new IncidentMissingException("Incident does not exist");
            //if (existing.IncidentStatusId == (int)IncidentStatusTypes.Closed) throw new IncidentClosedException("Incident is closed.");
            var existingAttachment = this.DbSet.Find(docUrl);
            if (existingAttachment != null)
            {
                existingAttachment.TagFlags = tags;
                await ctx.SaveChangesAsync();
            }
        }
    }
}
