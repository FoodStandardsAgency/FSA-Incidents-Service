using FSA.IncidentsManagement.Root.DTOS;
using System;

namespace FSA.IncidentsManagement.Root.Models
{
    public class SimsNote
    {
        public int HostId { get; set; }
        public int Id { get; set; }
        public string Note { get; set; }
        public SimsNoteTagTypes Tags { get; set; }
        public DateTime Created { get; set; }
        public String CreatedBy { get; set; }
    }
}
