using System.Collections.Generic;

namespace FSA.IncidentsManagement.Root.DTOS
{
    public class SimsAddress
    {
        public SimsAddress()
        {
            ContactMethodId = 1;
            this.Contacts = new List<SimsAddressContact>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string TownCity { get; set; }
        public string County { get; set; }
        public int? CountryId { get; set; }
        public string PostCode { get; set; }
        public string TelephoneNumber { get; set; }
        public int ContactMethodId { get; set; }
        public IEnumerable<SimsAddressContact> Contacts { get; set; }
    }
}
