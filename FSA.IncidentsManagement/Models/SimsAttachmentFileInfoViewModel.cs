using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public class SimsAttachmentFileInfoViewModel
    {
        public string FileName { get; set; }
        public string Url { get; set; }
        public IEnumerable<int> Tags { get; set; }
        public string UserId { get; set; }
        public DateTime Created { get; set; }
    }
}
