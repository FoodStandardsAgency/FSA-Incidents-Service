namespace FSA.IncidentsManagementDb.Entities
{
    internal class StatusDb
    {
        public int Id{ get; set; }
        public string Title { get; set; }
        public int? ParentId{ get; set; }
        public StatusDb Parent { get; set; }
        public bool IsIncidentsDefault { get; set; }
        public bool IsOpen { get; set; }
        public bool IsUnassigned { get; set; }
    }
}
