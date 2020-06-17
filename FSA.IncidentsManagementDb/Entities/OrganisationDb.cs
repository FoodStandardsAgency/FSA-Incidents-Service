using System;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class OrganisationDb
    {
        public int Id { get; set; }
        public string MainContact { get; set; }
        public string Organisation { get; set; }
        public int OrganisationRoleId { get; set; }
        public OrganisationRoleDb OrganisationRole { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string TownCity { get; set; }
        public string County { get; set; }
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
        public string Organisation { get; set; }
    }
}

