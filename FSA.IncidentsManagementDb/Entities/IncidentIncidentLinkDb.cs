using System;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class IncidentIncidentLinkDb
    {
        public int LinkFromIncidentId{ get; set; }
        public int LinkToIncidentId{ get; set; }
        public int LastChangedById{ get; set; }
        public DateTime LastChangedDate { get; set; }
    }
}
