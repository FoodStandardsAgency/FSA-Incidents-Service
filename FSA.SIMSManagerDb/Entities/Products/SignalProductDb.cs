
using FSA.SIMSManagerDb.Entities.Core;

namespace FSA.SIMSManagerDb.Entities
{
    internal class SignalProductDb : BaseProductDb<SignalProductPackSizeDb, SignalProductDateDb, SignalProductFboDb, SignalProductDb>
    {
        public int SignalId { get; set; }
        public SignalDb Signal { get; set; }
    }
}
