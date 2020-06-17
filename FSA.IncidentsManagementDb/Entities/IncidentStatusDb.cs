using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class IncidentStatusDb : BaseEntityDb
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
