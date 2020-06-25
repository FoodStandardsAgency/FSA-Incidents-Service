namespace FSA.IncidentsManagementDb.Entities
{
    internal class DateTypeDb : BaseEntityDb, IIDbLookup
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}