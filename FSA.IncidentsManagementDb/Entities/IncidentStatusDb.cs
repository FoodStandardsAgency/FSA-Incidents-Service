using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class IncidentStatusDb : BaseEntityDb,IIDbLookup
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int SortOrder { get; set; }
    }
}
