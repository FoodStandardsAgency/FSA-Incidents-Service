using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class NotifierDb :BaseEntityDb
    {
        public int Id { get; set; }
        public int NotifierTypeId { get; set; }
        public NotifierTypeDb NotifierType { get; set; }
        public int OrganisationId { get; set; }
        public AddressDb Organisation { get; set; }
    }
}
