using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Entities.Core;
using FSA.SIMSManagerDbEntities.Helpers;

namespace FSA.SIMSManagerDb.Entities.Core
{
    internal abstract class BaseProductFboDb<HostDb> : BaseEntityDb
    {
        public int ProductId { get; set; }
        public HostDb Product { get; set; }
        public int AddressId { get; set; }
        public FboTypes FboTypes { get; set; }
        public AddressDb Address { get; set; }
    }
}
