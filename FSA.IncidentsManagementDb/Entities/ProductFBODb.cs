using FSA.IncidentsManagement.Root.Models;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class ProductFBODb : BaseEntityDb
    {
        public int ProductId { get; set; }
        public ProductDb Product {get;set;}
        public int AddressId { get; set; }
        public FboTypes FboTypes { get; set; }
        public AddressDb Address { get; set; }
    }
}
