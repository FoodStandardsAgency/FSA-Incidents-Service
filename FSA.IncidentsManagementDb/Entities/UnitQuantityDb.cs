namespace FSA.IncidentsManagementDb.Entities
{
    internal class UnitQuantityDb : BaseEntityDb, IIDbLookup
    {
        public int Id{ get; set; }
        public string Title { get; set; }
    }
}