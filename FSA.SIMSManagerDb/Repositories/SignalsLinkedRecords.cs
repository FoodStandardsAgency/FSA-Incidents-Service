using AutoMapper;
using FSA.IncidentsManagement.Root.Domain;
using FSA.IncidentsManagement.Root.DTOS;
using FSA.SIMSManagerDb.Contracts;
using FSA.SIMSManagerDb.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSA.SIMSManagerDb.Repositories
{
    public class SignalsLinkedRecords : IDbLinkedRecordsRepository
    {
        //private readonly SimsDbContext ctx;
        //private readonly Mapper mapper;
        private readonly GeneralLinkedRecordsRepository<SignalLinkDb, SignalNoteDb> linksManager;

        public SignalsLinkedRecords(SimsDbContext ctx, IMapper mapper)
        {
            this.linksManager = new GeneralLinkedRecordsRepository<SignalLinkDb, SignalNoteDb>(ctx, mapper);
        }
        public Task<IEnumerable<SimsLinkedRecord>> Add(int from, IEnumerable<int> tos, string reason)
        {
            return this.linksManager.Add(from, tos, reason);
        }

        public Task<SimsLinkedRecord> Remove(int from, int to)
        {
            return this.linksManager.Remove(from, to);
        }
    }
}
