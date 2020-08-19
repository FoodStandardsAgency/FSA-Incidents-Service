using System;
using System.Globalization;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class AddressDb : BaseEntityDb, IIDbLookup
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string MainContact { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string TownCity { get; set; }
        public string County { get; set; }
        public int? CountryId { get; set; }
        public CountryDb Country { get; set; }
        public string PostCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int ContactMethodId { get; set; }
        public ContactMethodDb ContactMethod { get; set; }
        public long Uprn { get; set; }
    }
    // not actual a stored object(table) so no need to inherit from baseEntitry
    internal class AddressLookupDb : IIDbLookup
    {
        public int Id {get;set;}
        public string Title { get; set; }
    }
}

