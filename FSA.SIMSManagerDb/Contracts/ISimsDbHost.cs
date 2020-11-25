namespace FSA.SIMSManagerDb.Contracts
{
    public interface ISimsDbHost
    {
        IDbAddressRepository Addresses { get; }
        IDbIncidentsRepository Incidents { get; }
        IDbLookups Lookups { get; }
        IDbSignalsRepository Signals { get; }
        IDbOnlineFormRepository OnlineForms { get; }
        IDbUserAudit Audit { get; }
    }
}