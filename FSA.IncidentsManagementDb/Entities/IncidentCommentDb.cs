using System;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class IncidentCommentDb : BaseEntityDb
    {
        public IncidentCommentDb()
        {
        }

        public int Id{ get; set; }
        public int IncidentId { get; set; }
        public IncidentDb Incident { get; set; }
        public int? IncidentProductId { get; set; }
        public string Comment { get; set; }

        public string LastChangedBy { get; set; }
        public DateTime LastChangedDate { get; set; }
    }
}
