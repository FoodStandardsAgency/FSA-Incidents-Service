using FSA.SIMSManagerDb.Entities.Core;
using FSA.SIMSManagerDb.Entities.Core.Product;

namespace FSA.SIMSManagerDb.Entities
{
    internal class IncidentProductPackSizeDb : CoreProductPackSizeDb
    {
        public IncidentProductDb Product { get; set; }
    }
}
 