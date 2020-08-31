
using FSA.IncidentsManagement.Root.Models;

namespace FSA.IncidentsManagement.Root.DTOS
{
    public class SimsProductFboAddress : SimsAddress
    {

        public FboTypes FboTypes { get; set; }
        public int ProductId{get;set;}
    }
}
