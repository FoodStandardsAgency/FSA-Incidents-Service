namespace FSA.SIMSManagerDb.Contracts
{
    public interface ISimsDbHost
    {
        IDbAddressRepository Addresses { get; }
        IDbIncidentsRepository Incidents { get; }
        IDbLookups Lookups { get; }
        IDbSignalsRepository Signals { get; }
        IDbUserAudit Audit { get; }
    }
}