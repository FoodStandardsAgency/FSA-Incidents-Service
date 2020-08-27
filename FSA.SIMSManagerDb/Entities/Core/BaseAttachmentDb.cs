using FSA.IncidentsManagement.Root.Models;

namespace FSA.SIMSManagerDb.Entities.Core
{
    internal class BaseAttachmentDb<HostDb> : BaseEntityDb where HostDb : class, IDbId<int>
    {
        public int HostId { get; set; }
        public HostDb Host { get; set; }
        public string DocUrl { get; set; }
        public DocumentTagTypes TagFlags { get; set; }
    }
}
