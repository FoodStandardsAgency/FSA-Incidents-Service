using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Entities
{
    /// <summary>
    /// This is a helper to stop having to do unwise lookups
    /// Remember DB IncidentStatus Id values and these MUST BE THE SAME!!
    /// </summary>
    public enum IncidentStatus
    {
        Unassigned =0,
        Open = 1,
        Closed=2,
        NoWait=4
    }
}
