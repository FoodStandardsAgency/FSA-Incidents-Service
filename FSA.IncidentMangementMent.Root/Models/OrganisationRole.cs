namespace FSA.IncidentsManagement.Root.Models
{
    public class OrganisationRole    {
        public int Id{ get; set; }
        public string Title { get; set; }
        public bool CanBeNotifier { get; set; }
        public bool CanBeFBO { get; set; }
        public bool CanBeLocalAuthority { get; set; }
    }
}
