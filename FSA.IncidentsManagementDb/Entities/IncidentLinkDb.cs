using System;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class IncidentLinkDb : BaseEntityDb
    {
        public int FromIncidentId{ get; set; }
        public IncidentDb FromIncident { get; set; }
        public int ToIncidentId{ get; set; }
        public IncidentDb ToIncident { get; set; }
    }
}
