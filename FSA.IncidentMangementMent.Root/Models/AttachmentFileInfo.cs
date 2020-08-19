using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class AttachmentFileInfo
    {

        public string FileName { get; set; }
        public string Url { get; set; }
        public List<int> Tags { get; set; } = new List<int>();
    }
}
