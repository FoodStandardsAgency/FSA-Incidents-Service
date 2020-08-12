using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class AttachmentFileInfo
    {
       public string FileName { get; set; }
       public string Url { get; set; }
       public int[] Tags { get; set; }
    }
}
