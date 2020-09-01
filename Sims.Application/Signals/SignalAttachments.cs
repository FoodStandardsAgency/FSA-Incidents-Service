using FSA.IncidentsManagement.Root;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class SignalAttachments : ISIMSAttachments
    {
        private ISimsDbHost dbHost;
        private readonly ISimSpAttachments attachments;

        public SignalAttachments(ISimsDbHost dbHost, ISimSpAttachments attachments)
        {
            this.dbHost = dbHost;
            this.attachments = attachments;
        }
        public async Task<AttachmentFileInfo> AddAttachment(string filePath, string filename, int hostId)
        {
            var signalLibrary = AppExtensions.GenerateSignalsId(hostId);
            var item = await attachments.AddAttachment(filePath, filename, signalLibrary);
            return new AttachmentFileInfo
            {
                FileName = item.filename,
                Tags = new List<int>(),
                Url = item.url
            };
        }

        public Task<AttachmentLibraryInfo> EnsureLibrary(int hostId)
        {
            var signalLibrary = AppExtensions.GenerateSignalsId(hostId);
            return attachments.EnsureLibrary(signalLibrary);
        }

        public Task<IEnumerable<AttachmentFileInfo>> FetchAllAttchmentsLinks(int hostId)
        {
            var signalLibrary = AppExtensions.GenerateSignalsId(hostId);
            return attachments.FetchAllAttchmentsLinks(signalLibrary);
        }

        public async Task<IEnumerable<AttachmentFileInfo>> GetAllTags(int hostId)
        {
            var tagInfo = await dbHost.Incidents.Attachments.GetAttachmentTags(hostId);
            return tagInfo.Select(o => new AttachmentFileInfo
            {
                FileName = o.fileUrl,
                Tags = AppExtensions.SelectedFlags<DocumentTagTypes>(o.tags).Select(o => (int)o).ToList(),
                Url = o.fileUrl
            });
        }

        public Task UpdateTags(int id, string docUrl, DocumentTagTypes tags)
        {
            return dbHost.Incidents.Attachments.UpdateAttachmentTags(id, docUrl, tags);
        }
    }
}