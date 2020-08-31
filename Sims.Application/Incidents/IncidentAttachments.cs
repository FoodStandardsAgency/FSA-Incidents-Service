using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using Microsoft.BusinessData.MetadataModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class IncidentAttachments : ISIMSAttachments
    {
        private ISimsDbHost dbHost;

        public IncidentAttachments(ISimsDbHost dbHost)
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

        public async Task<IEnumerable<AttachmentFileInfo>> FetchAllAttchmentsLinks(int hostId)
        {
            //var items = await dbHost.Incidents.Attachments.GetAttachmentTags(hostId);
            //await 
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<AttachmentFileInfo>> GetAllTags(int hostId)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateTags(int id, string docUrl, DocumentTagTypes tags)
        {
            return dbHost.Incidents.Attachments.UpdateAttachmentTags(id, docUrl, tags);
        }
    }
}