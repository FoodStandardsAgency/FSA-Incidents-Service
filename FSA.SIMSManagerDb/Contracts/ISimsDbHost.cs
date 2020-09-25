namespace FSA.SIMSManagerDb.Contracts
{
    public interface ISimsDbHost
    {
        IDbAddressRepository Addresses { get; }
        IDbIncidentsRepository Incidents { get; }
        IDbLookups Lookups { get; set; }
        IDbSignalsRepository Signals { get; }
    }
}