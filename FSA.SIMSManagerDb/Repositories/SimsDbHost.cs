using AutoMapper;
using FSA.IncidentsManagement.Root.Domain;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities;

namespace FSA.SIMSManagerDb.Repositories
{
    public class SimsDbHost
    {
        private SimsDbContext ctx;
        private IMapper mapper;

        public SimsDbHost(SimsDbContext ctx, IMapper mapper, string userId)
        {
            this.ctx = ctx;
            this.mapper = mapper;
            ctx.SetEditor(userId);
            this.Incidents = new IncidentsRepository(ctx, mapper);
            this.Signals = new SignalsRepository(ctx, mapper);

            this.IncidentProducts = new GeneralProductRepository<IncidentProductDb, IncidentProductFboDb, IncidentProductPackSizeDb, IncidentProductDateDb>(ctx,mapper);
            this.SignalProducts = new GeneralProductRepository<SignalProductDb, SignalProductFboDb, SignalProductPackSizeDb, SignalProductDateDb>(ctx, mapper);

            this.IncidentLinks = new IncidentLinkedRecords(ctx, mapper);
            this.SignalLinks = new SignalsLinkedRecords(ctx, mapper);
            
            this.IncidentStakeholders = new GeneralStakeholdersRepository<IncidentStakeholderDb>(ctx, mapper);
            this.SignalStakeholders = new GeneralStakeholdersRepository<SignalStakeholderDb>(ctx, mapper);
            
            this.IncidentAttachments = new GeneralAttachmentsRepository<IncidentAttachmentDb>(ctx, mapper);
            this.SignalAttachments = new GeneralAttachmentsRepository<SignalAttachmentDb>(ctx, mapper);

            this.IncidentNotes = new GeneralNotesRepository<IncidentNoteDb>(ctx, mapper);
            this.SignalNotes = new GeneralNotesRepository<SignalNoteDb>(ctx, mapper);

            this.Addresses = new AddressRepository(ctx, mapper);
            this.Lookups = new LookupHost(ctx, mapper);
        }

        public IncidentsRepository Incidents { get; }
        public ISIMSLinks IncidentLinks { get; }
        public IDbStakeholdersRepository IncidentStakeholders { get; }
        public IDbAttachmentsRepository IncidentAttachments { get; }
        public IDbNotesRepository IncidentNotes { get; }

        public IDbSignalsRepository Signals { get; }
        public ISIMSLinks SignalLinks { get; }
        public IDbStakeholdersRepository SignalStakeholders { get; }
        public IDbAttachmentsRepository SignalAttachments { get; }
        public IDbNotesRepository SignalNotes { get; }

        public IDbProductRepository SignalProducts { get; }
        public IDbProductRepository IncidentProducts { get; }

        public IDbLookups Lookups { get; set; }
        public IDbAddressRepository Addresses { get; }
        public dynamic Products { get; }
    }
}
