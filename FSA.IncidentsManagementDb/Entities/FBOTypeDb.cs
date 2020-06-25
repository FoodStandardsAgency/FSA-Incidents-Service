namespace FSA.IncidentsManagementDb.Entities
{
    internal class FBOTypeDb : BaseEntityDb, IIDbLookup
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}