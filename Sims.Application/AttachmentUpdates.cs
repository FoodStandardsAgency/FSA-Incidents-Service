using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class AttachmentUpdates : ISIMSAppAttachment
    {
        private readonly ISimsDbHost dbHost;
        private readonly ISIMSAttachmentHost attachments;

        public AttachmentUpdates(ISIMSAttachmentHost attachments, ISimsDbHost dbHost)
        {
            this.attachments = attachments;
            this.dbHost = dbHost;
        }
        public Task<SimsAttachmentFileInfo> Rename(string fileName, string url)
        {
            return attachments.RenameFile(fileName, url);
        }

        public Task UpdateTags(string docUrl, IEnumerable<int> tags)
        {
            return dbHost.Signals.Attachments.Update(docUrl, (DocumentTagTypes)tags.ToList().Sum());
        }
    }
}
