using FSA.SIMSManagerDb.Entities.Core;

namespace FSA.SIMSManagerDb.Entities
{
    internal class SignalStakeholderDb : BaseStakeholderDb
    {
        public SignalDb Signal { get; set; }
    }
}
