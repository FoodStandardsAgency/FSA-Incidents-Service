using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.SIMSManagerDb.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class SignalAttachments : ISIMSAttachments
    {
        private ISimsDbHost dbHost;
        private readonly ISPAttachmentManagement attachments;

        public SignalAttachments(ISimsDbHost dbHost, ISPAttachmentManagement attachments)
        {
            this.dbHost = dbHost;
            this.attachments = attachments;
        }
        public async Task<SimsAttachmentFileInfo> AddAttachment(string filePath, string filename, int hostId)
        {
            var signalLibrary = AppExtensions.GenerateSignalsId(hostId);
            var item = await attachments.AddAttachment(filePath, filename, signalLibrary);
            return await dbHost.Incidents.Attachments.Add(hostId, item.url);
        }

        public Task<SimsAttachmentLibraryInfo> EnsureLibrary(int hostId)
        {
            var signalLibrary = AppExtensions.GenerateSignalsId(hostId);
            return attachments.EnsureLibrary(signalLibrary);
        }

        public async Task<IEnumerable<SimsAttachmentFileInfo>> FetchAllAttchmentsLinks(int hostId)
        {
            var signalLibrary = AppExtensions.GenerateSignalsId(hostId);
            var fileDat = await attachments.FetchAllAttchmentsLinks(signalLibrary);
            var dbData = await dbHost.Signals.Attachments.Get(hostId);

            var allData = from file in fileDat
                          join db in dbData
                          on file.Url equals db.Url
                          select new SimsAttachmentFileInfo
                          {
                              FileName = file.FileName,
                              Url = file.Url,
                              Tags = db.Tags,
                              Created = db.Created,
                              UserId = db.UserId
                          };

            return allData.ToList();
        }

        public Task<IEnumerable<SimsAttachmentFileInfo>> GetAllTags(int hostId)
        {
            return dbHost.Signals.Attachments.Get(hostId);
        }

        public Task<SimsAttachmentFileInfo> RegisterAttachment(string fileUrl, int hostId)
        {
            return dbHost.Signals.Attachments.Add(hostId, fileUrl);
        }

        public Task<SimsAttachmentFileInfo> Update(string filePath, SimsDocumentTagTypes docTagTypes)
        {
            return dbHost.Signals.Attachments.Update(filePath, (int)docTagTypes);
        }

        public async Task<SimsAttachmentFileInfo> Rename(string existingUrl, string fileName)
        {
            await attachments.RenameAttachment(fileName, existingUrl);
            return await dbHost.Signals.Attachments.Rename(existingUrl, fileName);
        }
    }
}