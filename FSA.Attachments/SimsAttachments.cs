using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace FSA.Attachments
{
    public class SimsAttachments : ISIMSAttachmentHost
    {
        public SimsAttachments(string clientId, string tenantId, X509Certificate2 cert, string hostUrl, AttachConfig Incidents, AttachConfig Signals )
        {
            this.Incidents = new SPAttachments(clientId, tenantId, cert, hostUrl, Incidents.SiteUrl, Incidents.ContentTypeId);
            this.Signals = new SPAttachments(clientId, tenantId, cert, hostUrl, Signals.SiteUrl, Signals.ContentTypeId);
        }

        public ISimsAttachments Incidents { get; }
        public ISimsAttachments Signals { get; }

        public async Task<SimsAttachmentFileInfo> RenameFile(string filename, string fileUrl)
        {
            var itm = await this.Incidents.RenameAttachment(filename, fileUrl);

            return new SimsAttachmentFileInfo
            {
                 FileName =itm.fileName,
                 Url = itm.url,
                 Tags = 0
            };
        }
    }
}
