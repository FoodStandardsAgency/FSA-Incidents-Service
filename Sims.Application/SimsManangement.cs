﻿using AutoMapper;
using FSA.IncidentsManagement.Root.Domain;
using FSA.SIMSManagerDb;
using FSA.SIMSManagerDb.Contracts;

namespace Sims.Application
{
    public class SimsManangement : ISIMSApplication
    {
        private readonly ISIMSAttachmentHost attachments;
        private ISimsDbHost SimsDbHost;

        public SimsManangement(SimsDbContext ctx, IMapper mapper, ISIMSAttachmentHost attachments, string userId)
        {
            // unsure about this tbh....
            this.SimsDbHost = FSA.SIMSManagerDb.Repositories.SimsDbHost.CreateHost(ctx, mapper, userId);
            this.attachments = attachments;
        }

        public ISIMSIncidents Incidents => new Incidents(this.SimsDbHost, attachments);

        public ISIMSSignals Signals => new Signals(this.SimsDbHost, attachments);

        public ISIMSLookups Lookups => new Lookups(this.SimsDbHost);

        public ISIMSAddress Addresses => new AddressManagment(this.SimsDbHost);

        public ISIMSUserAuditLogger AuditLog => new UserAuditLogger(this.SimsDbHost);
       // public ISIMSAppAttachment AttachmentUpdates => new AttachmentUpdates(attachments, SimsDbHost);
    }
}