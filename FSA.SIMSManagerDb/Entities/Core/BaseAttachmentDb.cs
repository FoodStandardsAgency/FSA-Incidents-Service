using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDbEntities.Helpers;

namespace FSA.SIMSManagerDb.Entities.Core
{
    internal class BaseAttachmentDb: BaseEntityDb
    {
        public int HostId { get; set; }
        public string DocUrl { get; set; }
        public DocumentTagTypes TagFlags { get; set; }
    }
}
