namespace FSA.IncidentsManagementDb.Entities
{
    internal class CountryDb : BaseEntityDb, IIDbLookup
    {
        public int Id{ get; set; }
        public string Title { get; set; }
    }
}
