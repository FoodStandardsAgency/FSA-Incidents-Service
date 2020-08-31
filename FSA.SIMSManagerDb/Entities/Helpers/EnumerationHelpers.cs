using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDbEntities.Helpers
{
    /// <summary>
    /// This is a helper to stop having to do unwise lookups
    /// Remember DB IncidentStatus Id values and these MUST BE THE SAME!!
    /// </summary>
    internal enum IncidentStatusTypes
    {
        Unknown = 0,
        Unassigned = 4,
        Open = 1,
        Closed = 2
    }

    internal enum PrioritiesStatus
    {
        Unknown = 0,
        TBC = 1,
        High = 2,
        Medium = 3,
        Low = 4
    }
}
