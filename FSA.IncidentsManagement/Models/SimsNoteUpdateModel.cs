using FSA.IncidentsManagement.Root.DTOS;

namespace FSA.IncidentsManagement.Models
{
    public class SimsNoteUpdateModel
    {
        public int NoteId { get; set; }
        public int[] Tags {get;set;}
    }
}
