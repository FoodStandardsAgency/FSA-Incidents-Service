using AutoMapper;
using FSA.SIMSManagerDb.Contracts;

namespace FSA.SIMSManagerDb.Repositories
{
    /// <summary>
    /// This is the entry point for the db end of the applicatioN
    /// The db has only a tenous connection to the rest of the application
    /// Treat it more as adjunct of the Sims.Application project
    /// </summary>
    public class SimsDbHost : ISimsDbHost
    {
        private SimsDbContext ctx;
        private IMapper mapper;

        internal  SimsDbHost(SimsDbContext ctx, IMapper mapper)
        {
            this.ctx = ctx;
            this.mapper = mapper;
            this.Incidents = new IncidentsRepository(ctx, mapper);
            this.Signals = new SignalsRepository(ctx, mapper);
            this.Audit = new UserAuditLoggerRepository(ctx);
            this.Addresses = new AddressRepository(ctx, mapper);
            this.Lookups = new LookupHost(ctx, mapper);
        }

        public IDbIncidentsRepository Incidents { get; }
        public IDbSignalsRepository Signals { get; }
        public IDbUserAudit Audit { get; }
        public IDbLookups Lookups { get; set; }
        public IDbAddressRepository Addresses { get; }

        public static ISimsDbHost CreateHost(SimsDbContext ctx, IMapper mapper, string userId)
        {
            ctx.SetEditor(userId);
            return new SimsDbHost(ctx, mapper);
        }
    }
}
