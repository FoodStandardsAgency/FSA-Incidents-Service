using FSA.SIMSManagerDb.Entities.Core;

namespace FSA.SIMSManagerDb.Entities.Lookups
{
    internal class DateTypeDb : BaseEntityDb, IIDbLookup
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}