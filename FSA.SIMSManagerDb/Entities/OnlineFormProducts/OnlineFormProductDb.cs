using FSA.SIMSManagerDb.Entities.Core;
using System.Collections.Generic;

namespace FSA.SIMSManagerDb.Entities
{
    internal class OnlineFormProductDb : BaseProductDb, ICoreProduct<OnlineFormProductFboDb, OnlineFormProductPackSizeDb, OnlineFormProductDateDb>
    {
        public OnlineFormDb Host { get; set; }
        public ICollection<OnlineFormProductFboDb> RelatedFBOs { get; set; }
        public ICollection<OnlineFormProductPackSizeDb> PackSizes { get; set; }
        public ICollection<OnlineFormProductDateDb> ProductDates { get; set; }
    }
}
