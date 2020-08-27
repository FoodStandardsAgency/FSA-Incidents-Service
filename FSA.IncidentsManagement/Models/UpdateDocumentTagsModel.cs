using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public class UpdateDocumentTagsModel
    {
        public int Id { get; set; }
        public string DocUrl { get; set; }
        public int[] Tags { get; set; }
    }
}
