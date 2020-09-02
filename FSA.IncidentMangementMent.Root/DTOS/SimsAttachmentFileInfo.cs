using System;
using System.Collections.Generic;

namespace FSA.IncidentsManagement.Root.DTOS
{
    public class SimsAttachmentFileInfo
    {
        public string FileName { get; set; }
        public string Url { get; set; }
        public List<int> Tags { get; set; } = new List<int>();
        public string UserId { get; set; }
        public DateTime Created { get; set; }
    }
}
