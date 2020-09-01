using AutoMapper;
using FSA.IncidentsManagement.Root.Domain;
using FSA.SIMSManagerDb;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Repositories;
using System;

namespace Sims.Application
{
    public class SimsManangement : ISIMSApplication
    {
        private readonly ISIMSAttachmentHost attachments;
        private ISimsDbHost SimsDbHOst;

        public SimsManangement(SimsDbContext ctx, IMapper mapper, ISIMSAttachmentHost attachments, string userId)
        {
            // unsure about this tbh....
            this.SimsDbHOst = SimsDbHost.CreateHost(ctx, mapper, userId);
            this.attachments = attachments;
        }

        public ISIMSIncidents Incidents => new Incidents(this.SimsDbHOst, attachments);

        public ISIMSSignals Signals => new Signals(this.SimsDbHOst, attachments);

        public ISIMSLookups Lookups => new Lookups(this.SimsDbHOst);

        public ISIMSAddress Addresses => new AddressManagment(this.SimsDbHOst);
    }
}
