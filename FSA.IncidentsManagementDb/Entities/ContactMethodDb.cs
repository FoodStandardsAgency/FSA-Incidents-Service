namespace FSA.IncidentsManagementDb.Entities
{
    internal class ContactMethodDb : BaseEntityDb,IIDbLookup
    {
        public int Id{ get; set; }
        public string Title { get; set; }
    }
}
