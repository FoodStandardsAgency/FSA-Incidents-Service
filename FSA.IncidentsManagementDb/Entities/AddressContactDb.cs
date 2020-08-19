using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class AddressContactDb : BaseEntityDb
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public AddressDb Address { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool IsMain { get; set; } = false;
    }
}
