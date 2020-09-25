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

        public ISPAttachmentManagement Incidents { get; }
        public ISPAttachmentManagement Signals { get; }

 
    }
}
