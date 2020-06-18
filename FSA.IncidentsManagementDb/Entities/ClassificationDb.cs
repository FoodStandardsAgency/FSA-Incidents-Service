namespace FSA.IncidentsManagementDb.Entities
{
    internal class ClassificationDb : BaseEntityDb, IIDbLookup
    {
        public int Id{ get; set; }
        public string Title { get; set; }
    }
}
