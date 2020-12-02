namespace FSA.IncidentsManagement.Root.DTOS
{
    public class SimsOnlineForm
    {
        public string Id => GeneralExtensions.GenerateOnlineId(this.CommonId);
        public int CommonId { get; set; }
        public string ReferenceNo { get; set; }
        public string Title { get; set; }
        public int NotifierTypeId { get; set; }
        public string Description { get; set; } // Nature of problem
        public string Action { get; set; }
        public string DistributionDetails { get; set; }
        public string DeathIllness { get; set; }
        public string LADetails { get; set; }
        public string AdditionalInformation { get; set; }
        public int? IncidentId { get; set; }
        public bool IsClosed { get; set; }
    }
}
