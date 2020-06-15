namespace FSA.IncidentsManagement.Root.Models
{
    public class Status    {
        public int Id{ get; set; }
        public string Title { get; set; }
        public int? ParentId{ get; set; }
        public bool IsIncidentsDefault { get; set; }
        public bool IsOpen { get; set; }
        public bool IsUnassigned { get; set; }
    }
}
