using AutoMapper;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.SIMSManagerDb.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    public class SignalsLinkedRecords : IDBLinkedRecordsRepository, ISIMSLinks
    {
        //private readonly SimsDbContext ctx;
        //private readonly Mapper mapper;
        private readonly GeneralLinkedRecordsRepository<SignalLinkDb, SignalNoteDb> linksManager;

        public SignalsLinkedRecords(SimsDbContext ctx, IMapper mapper)
        {
            this.linksManager = new GeneralLinkedRecordsRepository<SignalLinkDb, SignalNoteDb>(ctx, mapper);
        }
        public Task<IEnumerable<LinkedRecord>> AddLinks(int from, IEnumerable<int> tos, string reason)
        {
            return this.linksManager.AddLinks(from, tos, reason);
        }

        public Task<LinkedRecord> RemoveLink(int from, int to)
        {
            return this.linksManager.RemoveLink(from, to);
        }
    }
}
