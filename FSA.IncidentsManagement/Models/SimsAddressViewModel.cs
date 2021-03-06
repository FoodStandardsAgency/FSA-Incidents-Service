﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public class SimsAddressViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string MainContact { get; set; }
        //public int? OrganisationRoleId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string TownCity { get; set; }
        public string County { get; set; }
        public int? CountryId { get; set; }
        public string PostCode { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int ContactMethodId { get; set; }

        public override string ToString()
        {
            return $"{Title} {PostCode} {MainContact}";
        }
    }
}
