using AutoMapper;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities.Core;
using FSA.SIMSManagerDbEntities.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    class AttachmentsRepository<AttachmentDb> : IDbAttachmentsRepository where AttachmentDb : BaseAttachmentDb, new()
    {
        private readonly DbSet<AttachmentDb> DbSet;
        private readonly SimsDbContext ctx;
        private readonly IMapper mapper;

        public AttachmentsRepository(SimsDbContext ctx, IMapper mapper)
        {
            this.DbSet = ctx.Set<AttachmentDb>();
            this.ctx = ctx;
            this.mapper = mapper;
        }

        public async Task<SimsAttachmentFileInfo> Add(int hostId, string docUrl, int tags = 0)
        {
            var newItem = this.DbSet.Add(new AttachmentDb
            {
                DocUrl = docUrl,
                HostId = hostId,
                TagFlags = (DocumentTagTypes)tags
            });

            await ctx.SaveChangesAsync();
            return mapper.Map<AttachmentDb, SimsAttachmentFileInfo>(newItem.Entity);
        }

        public Task BulkAdd(int hostId, Dictionary<string, int> UrlTags)
        {
            var newFileRegistrations = new List<AttachmentDb>();

            foreach (var itm in UrlTags)
            {
                newFileRegistrations.Add(new AttachmentDb
                {
                    DocUrl = itm.Key,
                    HostId = hostId,
                    TagFlags = (DocumentTagTypes)itm.Value
                });
            }
            this.DbSet.AddRange(newFileRegistrations);
            return ctx.SaveChangesAsync();
        }

        public async Task<IEnumerable<SimsAttachmentFileInfo>> Get(int hostId)
        {
            var attachments = await this.DbSet.Where(o => o.HostId == hostId).ToListAsync();
            return attachments.Select(s => mapper.Map<AttachmentDb, SimsAttachmentFileInfo>(s)).ToList();
        }

        public async Task<SimsAttachmentFileInfo> Rename(string existingUrl, string fileName)
        {
            var fileInfo = await this.DbSet.FindAsync(Uri.EscapeUriString(existingUrl));
            var oldFileName = Path.GetFileName(existingUrl);
            var rootUrl = existingUrl.Split(oldFileName)[0];

            var newFileinfo = new AttachmentDb
            {
                HostId = fileInfo.HostId,
                DocUrl = Uri.EscapeUriString($"{rootUrl}{fileName}"),
                TagFlags = fileInfo.TagFlags
            };
            this.DbSet.Remove(fileInfo);
            var newEnt = this.DbSet.Add(newFileinfo);
            await this.ctx.SaveChangesAsync();
            return mapper.Map<SimsAttachmentFileInfo>(newEnt.Entity);
        }

        public async Task<SimsAttachmentFileInfo> Update(string docUrl, int tags)
        {
            //// Ensure we have a an incident
            //// tHE DOCUment is taken on faith alas.
            //var existing = this.ctx.Incidents.Find(id);
            //if (existing == null) throw new IncidentMissingException("Incident does not exist");
            //if (existing.IncidentStatusId == (int)IncidentStatusTypes.Closed) throw new IncidentClosedException("Incident is closed.");
            var existingAttachment = this.DbSet.Find(docUrl);
            if (existingAttachment != null)
            {
                existingAttachment.TagFlags = (DocumentTagTypes)tags;
                await ctx.SaveChangesAsync();
                return mapper.Map<AttachmentDb, SimsAttachmentFileInfo>(existingAttachment);
            }

            return null;
        }


    }
}
