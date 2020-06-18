namespace FSA.IncidentsManagementDb.Entities
{
    internal class DataSourceDb : BaseEntityDb, IIDbLookup
    {
        public int Id{ get; set; }
        public string Title { get; set; }
    }
}
