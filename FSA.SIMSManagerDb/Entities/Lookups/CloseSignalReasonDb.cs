using FSA.SIMSManagerDb.Entities.Core;

namespace FSA.SIMSManagerDb.Entities.Lookups
{
    class CloseSignalReasonDb : BaseEntityDb, IIDbLookup
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
