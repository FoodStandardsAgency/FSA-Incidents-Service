using FSA.IncidentsManagement.Root.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class TaggedDocumentDb : BaseEntityDb
    {
        public int IncidentId { get; set; }
        public IncidentDb Incident { get; set; }
        public string DocUrl { get; set; }
        public DocumentTagTypes TagFlags { get; set; }
    }
}
