using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.DTOS
{
    public enum SimsIncidentStatusTypes
    {
        Unknown = 0,
        Unassigned = 4,
        Open = 1,
        Closed = 2
    }

    public enum SimsPrioritiesStatus
    {
        Unknown = 0,
        TBC = 1,
        High = 2,
        Medium = 3,
        Low = 4
    }
}
