using System;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class UserDb
    {
        public int Id{ get; set; }
        public string FirstNames { get; set; }
        public string MiddleNames { get; set; }
        public string Surnames { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int LastChangedById{ get; set; }
        public DateTime LastChangedByDate { get; set; }
    }
}
