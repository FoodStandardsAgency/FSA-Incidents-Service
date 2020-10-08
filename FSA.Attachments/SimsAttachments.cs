using FSA.IncidentsManagement.Root.Domain;
using System.Security.Cryptography.X509Certificates;

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
