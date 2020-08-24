using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class StakeholderIncidentRoleDb : BaseEntityDb, IIDbLookup
    {
        public int Id { get; set; }

        public string Title { get; set; }
    }
}
