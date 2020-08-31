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
        private ISimsDbHost SimsDbHOst;

        public SimsManangement(SimsDbContext ctx, IMapper mapper, string userId)
        {
            // unsure about this tbh....
            this.SimsDbHOst = SimsDbHost.CreateHost(ctx, mapper, userId);
        }

        public ISIMSIncidents Incidents => new Incidents(this.SimsDbHOst);

        public ISIMSSignals Signals => new Signals(this.SimsDbHOst);

        public ISIMSLookups Lookups => new Lookups(this.SimsDbHOst);

        public ISIMSAddress Addresses => new AddressManagment(this.SimsDbHOst);
    }
}
