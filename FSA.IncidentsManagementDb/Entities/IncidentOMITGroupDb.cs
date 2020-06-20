using System;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class IncidentOMITGroupDb : BaseEntityDb
    {
        public int Id{ get; set; }
        public int OMITGroupId{ get; set; }
        public OMITGroupDb OMITGroup { get; set; }

        
        public int IncidentId{ get; set; }
        public IncidentDb IncidentDb { get; set; }
    }
}
