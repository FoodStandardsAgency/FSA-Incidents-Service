using FSA.IncidentsManagement.Root.DTOS;

namespace FSA.IncidentsManagement.Models
{
    public class SimsNoteCreateModel
    {
        public int HostId { get; set; }
        public string Note { get; set; }
        public int[] Tags {get;set;}
    }
}
