using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class SignalAttachments : ISIMSAttachments
    {
        private ISimsDbHost dbHost;

        public SignalAttachments(ISimsDbHost dbHost)
        {
            this.dbHost = dbHost;
        }

        public Task<AttachmentFileInfo> AddAttachment(string filePath, string filename, string hostId)
        {
            throw new System.NotImplementedException();
        }

        public Task<AttachmentLibraryInfo> EnsureLibrary(string stringId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<AttachmentFileInfo>> FetchAllAttchmentsLinks(string hostId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<AttachmentFileInfo>> GetAllTags(int hostId)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateTags(int id, string docUrl, DocumentTagTypes tags)
        {
            throw new System.NotImplementedException();
        }
    }
}