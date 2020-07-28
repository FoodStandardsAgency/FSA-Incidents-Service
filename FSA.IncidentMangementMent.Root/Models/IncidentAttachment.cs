using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class IncidentAttachment
    {
        public IncidentAttachment()
        {
            Document = new MemoryStream();
        }

        public string IncidentId { get; set; }
        public Guid Incident { get; set; }
        public string FileName { get; set; }
        public MemoryStream Document { get; set; }
    }
}
