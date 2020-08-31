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

            //this.IncidentProducts = new GeneralProductRepository<IncidentProductDb, IncidentProductFboDb, IncidentProductPackSizeDb, IncidentProductDateDb>(ctx,mapper);
            //this.SignalProducts = new GeneralProductRepository<SignalProductDb, SignalProductFboDb, SignalProductPackSizeDb, SignalProductDateDb>(ctx, mapper);

            //this.IncidentProductFbos = new GeneralProductFboRepository<IncidentProductFboDb>(ctx, mapper);
            //this.SignalProductFbos = new GeneralProductFboRepository<SignalProductFboDb>(ctx, mapper);

            //this.IncidentLinks = new IncidentLinkedRecords(ctx, mapper);
            //this.SignalLinks = new SignalsLinkedRecords(ctx, mapper);

            //this.IncidentStakeholders = new GeneralStakeholdersRepository<IncidentStakeholderDb>(ctx, mapper);
            //this.SignalStakeholders = new GeneralStakeholdersRepository<SignalStakeholderDb>(ctx, mapper);

            //this.IncidentAttachments = new GeneralAttachmentsRepository<IncidentAttachmentDb>(ctx, mapper);
            //this.SignalAttachments = new GeneralAttachmentsRepository<SignalAttachmentDb>(ctx, mapper);

            //this.IncidentNotes = new GeneralNotesRepository<IncidentNoteDb>(ctx, mapper);
            //this.SignalNotes = new GeneralNotesRepository<SignalNoteDb>(ctx, mapper);

            this.Addresses = new AddressRepository(ctx, mapper);
            this.Lookups = new LookupHost(ctx, mapper);
        }

        public IDbIncidentsRepository Incidents { get; }
        public IDbSignalsRepository Signals { get; }

        //public IDbLinkedRecordsRepository IncidentLinks { get; }
        //public IDbStakeholdersRepository IncidentStakeholders { get; }
        //public IDbAttachmentsRepository IncidentAttachments { get; }
        //public IDbNotesRepository IncidentNotes { get; }

        //public IDbLinkedRecordsRepository SignalLinks { get; }
        //public IDbStakeholdersRepository SignalStakeholders { get; }
        //public IDbAttachmentsRepository SignalAttachments { get; }
        //public IDbNotesRepository SignalNotes { get; }

        //public IDbProductRepository IncidentProducts { get; }
        //public IDbProductFboRepository IncidentProductFbos { get; set; }

        //public IDbProductRepository SignalProducts { get; }
        //public IDbProductFboRepository SignalProductFbos { get; set; }

        public IDbLookups Lookups { get; set; }
        public IDbAddressRepository Addresses { get; }

    }
}
