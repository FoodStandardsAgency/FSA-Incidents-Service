namespace FSA.IncidentsManagement.Root.DTOS
{
    public class SimsSignalCloseNoIncident
    {
        public int SignalId { get; set; }
        // We can have multiple teams, so we use a flags type
        public int[] TeamIds { get; set; } 
        public int? ReasonId { get; set; }
        public int StatusCloseId { get; set; }
        public string UserReason { get; set; }
    }
}
