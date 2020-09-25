using System;
using System.Collections.Generic;

namespace FSA.IncidentsManagement.Root.DTOS
{
    public class SimsAttachmentFileInfo
    {
        public string FileName { get; set; }
        public string Url { get; set; }
        public int Tags { get; set; }
        public string UserId { get; set; }
        public DateTime Created { get; set; }

        public override string ToString()
        {
            return $"{FileName} {Tags}";
        }
    }
}
