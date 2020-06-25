namespace FSA.IncidentsManagementDb.Entities
{
    internal class NotifierTypeDb : BaseEntityDb, IIDbLookup
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}