using System;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class IncidentLinkDb : BaseEntityDb
    {
        public int LinkFromIncidentId{ get; set; }
        public int LinkToIncidentId{ get; set; }
    }
}
