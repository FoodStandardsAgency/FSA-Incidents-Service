namespace FSA.IncidentsManagement.Root.DTOS
{
    public class SimsSignalCloseNoIncident
    {
        public int SignalId { get; set; }
        public int TeamId { get; set; }
        public int ReasonId { get; set; }
        public int StatusCloseId { get; set; }
        public string UserReason { get; set; }
    }
}
