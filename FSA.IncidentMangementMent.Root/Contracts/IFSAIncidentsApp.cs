﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Contracts
{
    public interface IFSAIncidentsData
    {
        IIncidentsManagement Incidents {get;}
        IProductsManagement Products { get;  }
        IIAddressManagement Addresses { get; }
    }
}
