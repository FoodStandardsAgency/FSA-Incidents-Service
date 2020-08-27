using FSA.SIMSManagerDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.SIMSManagerDb
{
    public partial class SimsDbContext
    {
        internal DbSet<IncidentDb> Incidents { get; set; }
        internal DbSet<IncidentLinkDb> IncidentLinks { get; set; }
        internal DbSet<IncidentNoteDb> IncidentNotes { get; set; }
        internal DbSet<IncidentProductDb> IncidentProductDb { get; set; }
        internal DbSet<IncidentStakeholderDb> IncidentStakeholders { get; set; }
    }
}
