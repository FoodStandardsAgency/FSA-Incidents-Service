using AutoMapper;
using FSA.IncidentsManagement.Root.Domain;
using FSA.SIMSManagerDb;
using FSA.SIMSManagerDb.Contracts;
using Microsoft.Extensions.Logging;
using Sims.Application.OnlineForm;

namespace Sims.Application
{
    public class SimsManangement : ISIMSApplication
    {
        private readonly ISIMSAttachmentHost attachments;
        private readonly ILoggerFactory logging;
        private ISimsDbHost SimsDbHost;

        public SimsManangement(SimsDbContext ctx, IMapper mapper, ISIMSAttachmentHost attachments, string userId, ILoggerFactory logging)
        {
            // unsure about this tbh....
            this.SimsDbHost = FSA.SIMSManagerDb.Repositories.SimsDbHost.CreateHost(ctx, mapper, userId);
            this.attachments = attachments;
            this.logging = logging;
        }

        public ISIMSIncidents Incidents => new Incidents(this.SimsDbHost, attachments);

        public ISIMSSignals Signals => new Signals(this.SimsDbHost, attachments);

        public ISIMSOnlineForms OnlineForms => new OnlineForms(this.SimsDbHost, new OnlineFormImporter(this.SimsDbHost, logging.CreateLogger<OnlineFormImporter>()), logging.CreateLogger<OnlineForms>());

        public ISIMSLookups Lookups => new Lookups(this.SimsDbHost);

        public ISIMSAddress Addresses => new AddressManagment(this.SimsDbHost);

        public ISIMSUserAuditLogger AuditLog => new UserAuditLogger(this.SimsDbHost);
    }
}
