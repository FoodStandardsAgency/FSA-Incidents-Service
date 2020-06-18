namespace FSA.IncidentsManagementDb.Entities
{
    internal class BatchCodeDb : BaseEntityDb
    {
        public int Id { get; set; }
        public int IncidentId { get; set; }
        public string BatchCode { get; set; }
    }
}