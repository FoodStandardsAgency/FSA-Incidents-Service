namespace FSA.IncidentsManagementDb.Entities
{
    internal class DeathIllnessDb : BaseEntityDb, IIDbLookup
    {
        public int Id{ get; set; }
        public string Title { get; set; }
    }
}
