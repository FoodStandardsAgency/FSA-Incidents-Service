using System;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class UserRoleDb
    {
        public int Id{ get; set; }
        public int UserId{ get; set; }
        public int RoleId{ get; set; }
        public int LastChangedById{ get; set; }
        public DateTime LastChangedByDateTime { get; set; }
    }
}
