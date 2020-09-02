using FSA.IncidentsManagement.Root;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Contracts;
using Microsoft.BusinessData.MetadataModel;
using Microsoft.Graph;
using Sims.Application.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sims.Application
{
    internal class IncidentAttachments : ISIMSAttachments
    {
        private ISimsDbHost dbHost;
        private readonly ISimSpAttachments attachments;

        public IncidentAttachments(ISimsDbHost dbHost, ISimSpAttachments attachments)
        {
            this.dbHost = dbHost;
            this.attachments = attachments;
        }

        public async Task<SimsAttachmentFileInfo> AddAttachment(string filePath, string filename, int hostId)
        {
            if (!await this.dbHost.Incidents.IsClosed(hostId))
            {
                var incidentLibrary = AppExtensions.GenerateIncidentId(hostId);
                var item = await attachments.AddAttachment(filePath, filename, incidentLibrary);
                return await dbHost.Incidents.Attachments.Add(item.url, hostId);
            }
            else
                throw new SimsIncidentClosedException("Incident closed, cannot upload attachment");
        }

        public Task<AttachmentLibraryInfo> EnsureLibrary(int hostId)
        {
            var incidentLibrary = AppExtensions.GenerateIncidentId(hostId);
            return attachments.EnsureLibrary(incidentLibrary);
        }

        public Task<IEnumerable<SimsAttachmentFileInfo>> FetchAllAttchmentsLinks(int hostId)
        {
            var incidentLibrary = AppExtensions.GenerateIncidentId(hostId);
            return attachments.FetchAllAttchmentsLinks(incidentLibrary);
        }

        public Task<IEnumerable<SimsAttachmentFileInfo>> GetAllTags(int hostId)
        {
            return dbHost.Incidents.Attachments.Get(hostId);
            
        }
    }
}