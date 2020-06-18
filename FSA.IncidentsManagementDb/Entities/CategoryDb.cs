namespace FSA.IncidentsManagementDb.Entities
{
    internal class CategoryDb : BaseEntityDb, IIDbLookup
    {
        public int Id{ get; set; }
        public string Title { get; set; }
    }
}
