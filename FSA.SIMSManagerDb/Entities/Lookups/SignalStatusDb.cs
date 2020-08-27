using FSA.SIMSManagerDb.Entities.Core;
namespace FSA.SIMSManagerDb.Entities.Lookups
{
    internal class SignalStatusDb : BaseEntityDb, IIDbLookup
    {
        public int Id{ get; set; }
        public string Title { get; set; }
        public int? ParentId{ get; set; }
        public SignalStatusDb Parent { get; set; }
        public bool IsOpen { get; set; }
        public bool IsUnassigned { get; set; }
    }
}
