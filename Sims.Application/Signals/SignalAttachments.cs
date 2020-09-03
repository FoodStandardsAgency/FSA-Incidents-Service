using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.SIMSManagerDb.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class SignalAttachments : ISIMSAttachments
    {
        private ISimsDbHost dbHost;
        private readonly ISimsAttachments attachments;

        public SignalAttachments(ISimsDbHost dbHost, ISimsAttachments attachments)
        {
            this.dbHost = dbHost;
            this.attachments = attachments;
        }
        public async Task<SimsAttachmentFileInfo> AddAttachment(string filePath, string filename, int hostId)
        {
            var signalLibrary = AppExtensions.GenerateSignalsId(hostId);
            var item = await attachments.AddAttachment(filePath, filename, signalLibrary);
            return await dbHost.Incidents.Attachments.Add(item.url, hostId);
        }

        public Task<SimsAttachmentLibraryInfo> EnsureLibrary(int hostId)
        {
            var signalLibrary = AppExtensions.GenerateSignalsId(hostId);
            return attachments.EnsureLibrary(signalLibrary);
        }

        public Task<IEnumerable<SimsAttachmentFileInfo>> FetchAllAttchmentsLinks(int hostId)
        {
            var signalLibrary = AppExtensions.GenerateSignalsId(hostId);
            return attachments.FetchAllAttchmentsLinks(signalLibrary);
        }

        public Task<IEnumerable<SimsAttachmentFileInfo>> GetAllTags(int hostId)
        {
            return dbHost.Incidents.Attachments.Get(hostId);
        }
    }
}