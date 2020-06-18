namespace FSA.IncidentsManagementDb.Entities
{
    internal class ProductTypeDb : BaseEntityDb,IIDbLookup
    {
        public int Id{ get; set; }
        public string Title { get; set; }
    }
}
