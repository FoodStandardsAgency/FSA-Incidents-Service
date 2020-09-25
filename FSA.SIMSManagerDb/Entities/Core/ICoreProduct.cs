using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb.Entities.Core
{
    interface ICoreProduct< ProductFbo, ProductPackSize, ProductDate>
    {
        int Id { get; }
        //HostDb Host { get; }
        ICollection<ProductFbo> RelatedFBOs { get;  }
        ICollection<ProductPackSize> PackSizes { get;  }
        ICollection<ProductDate> ProductDates { get;  }
    }
}
