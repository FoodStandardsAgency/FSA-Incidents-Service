namespace FSA.IncidentsManagement.Root.DTOS
{
    public class SimsSignalCloseNoIncident
    {
        public int HostId { get; set; }
        public int TeamId { get; set; }
        public int ReasonId { get; set; }
        public string UserReason { get; set; }
    }
}
