using FSA.SIMSManagerDb.Entities.Core.Product;
using System.Collections.Generic;

namespace FSA.SIMSManagerDb.Entities
{
    class SignalProductDb : CoreProductDb, ICoreProduct<SignalProductFboDb, SignalProductPackSizeDb, SignalProductDateDb>
    {
        public SignalDb Host { get; set; }
        public ICollection<SignalProductFboDb> RelatedFBOs { get; set; }
        public ICollection<SignalProductPackSizeDb> PackSizes { get; set; }
        public ICollection<SignalProductDateDb> ProductDates { get; set; }
    }
}
