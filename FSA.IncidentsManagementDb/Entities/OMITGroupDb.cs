namespace FSA.IncidentsManagementDb.Entities
{
    internal class OMITGroupDb: BaseEntityDb, IIDbLookup
    {
        public int Id{ get; set; }
        public string Title { get; set; }
    }
}
