using System.ComponentModel.DataAnnotations;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class GatewayErrorCodeDb
    {
        public int ReturnCode { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
    }
}
