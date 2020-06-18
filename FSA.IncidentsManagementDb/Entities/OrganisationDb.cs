using System;
using System.Globalization;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class OrganisationDb : BaseEntityDb, IIDbLookup
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string MainContact { get; set; }
        public int OrganisationRoleId { get; set; }
        public OrganisationRoleDb OrganisationRole { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string TownCity { get; set; }
        public string County { get; set; }
        public int? CountryId { get; set; }
        public CountryDb Country { get; set; }
        public string PostCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FaxAddress { get; set; }
        public int ContactMethodId { get; set; }
        public ContactMethodDb ContactMethod { get; set; }
        public int LastChangedById { get; set; }
        public DateTime LastChangedDate { get; set; }
    }

    internal class OrganisationLookupDb
    {
        public int Id {get;set;}
        public string Title { get; set; }
    }
}

