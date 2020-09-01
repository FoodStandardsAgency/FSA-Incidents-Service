namespace FSA.IncidentsManagement.Root.Domain
{
    public interface ISIMSAttachmentHost
    {
        public ISimSpAttachments Incidents { get; }
        public ISimSpAttachments Signals { get; }
    }
}
