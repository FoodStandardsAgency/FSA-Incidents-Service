using System;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class IncidentLinkDb : BaseEntityDb
    {
        public int FromIncidentId{ get; set; }
        public int ToIncidentId{ get; set; }
    }
}
