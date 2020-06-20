using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class IncidentNote
    {
        public int IncidentId { get; set; }
        public int Id { get; set; }
        public string Note { get; set; }
        public DateTime Created { get; set; }
        public String CreatedBy { get; set; }
    }
}
