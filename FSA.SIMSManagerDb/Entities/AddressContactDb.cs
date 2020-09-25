using FSA.SIMSManagerDb.Entities.Core;

namespace FSA.SIMSManagerDb.Entities
{
    internal class AddressContactDb : BaseEntityDb
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public AddressDb Address { get; set; }
        public string Name { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool IsMain { get; set; } = false;
    }
}
