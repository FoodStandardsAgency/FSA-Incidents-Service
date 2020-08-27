using FSA.SIMSManagerDb.Entities.Core;
namespace FSA.SIMSManagerDb.Entities.Helpers
{
    internal class PriorityDb : BaseEntityDb, IIDbLookup
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
