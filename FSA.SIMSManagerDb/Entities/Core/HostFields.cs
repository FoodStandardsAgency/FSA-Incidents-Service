namespace FSA.SIMSManagerDb.Entities.Core
{
    /// <summary>
    /// few fields are shared between Incident, and Signals that are comptable
    /// These ones make some of the Repos easier to reason with
    /// </summary>
    interface HostFields
    {
        string LeadOfficer { get; }
    }
}
