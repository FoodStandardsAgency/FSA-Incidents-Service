using System;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class GatewayRequestDetailDb
    {
        public Guid RequestId{ get; set; }
        public int? UserId{ get; set; }
        public string TargetProcedure { get; set; }
        public string JsonParameters { get; set; }
        public string RequestingAppAccount { get; set; }
        public DateTime? RequestedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public int? ResultCode { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
