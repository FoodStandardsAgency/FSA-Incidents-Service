using System;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class GatewayUserIncidentDb
    {
        public int Id{ get; set; }
        public int UserId{ get; set; }
        public int? LastReturnedIncidentId{ get; set; }
        public Guid RequestId{ get; set; }
    }
}
