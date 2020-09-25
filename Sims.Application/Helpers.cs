using System;
using System.Collections.Generic;
using System.Text;

namespace Sims.Application.Helpers
{
    internal enum SimsIncidentStatusTypes
    {
        Unknown = 0,
        Unassigned = 4,
        Open = 1,
        Closed = 2
    }

    internal enum SimsPrioritiesStatusTypes
    {
        Unknown = 0,
        TBC = 1,
        High = 2,
        Medium = 3,
        Low = 4
    }

    internal enum SimsStakeholderAddressTypes
    {
        Unknown = 0,
        FSA = 1,
        LocalAuthority = 2,
        OtherGov= 3,
        FboFebo= 4
    }
}
