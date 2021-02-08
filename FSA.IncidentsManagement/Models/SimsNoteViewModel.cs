using System;

namespace FSA.IncidentsManagement.Models
{
    public class SimsNoteViewModel
    {
        public int HostId { get; set; }
        public int Id { get; set; }
        public string Note { get; set; }
        public int[] Tags { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
    }
}
