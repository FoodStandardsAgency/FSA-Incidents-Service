using FSA.IncidentsManagement.Root.Models;
using System.Collections.Generic;

namespace FSA.IncidentsManagement.Root.DTOS
{
    public class SimsExternalLookups
    {
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<ProductType> ProductTypes { get; set; }
        public IEnumerable<FBOType> FBOTypes { get; set; }
        public IEnumerable<UnitQuantity> Units { get; set; }
        public IEnumerable<NotifierType> NotifierTypes { get; set; }
    }
}
