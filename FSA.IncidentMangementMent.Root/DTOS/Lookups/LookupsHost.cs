using FSA.IncidentsManagement.Root.Contracts;
using FSA.IncidentsManagement.Root.DTOS.Lookups;
using System.Collections.Generic;

namespace FSA.IncidentsManagement.Root.Models
{
    /// <summary>
    /// big bag of all the client Lookups
    /// </summary>
    public class LookupsHost
    {
        public IEnumerable<HazardGroup> Categories { get; set; }
        public IEnumerable<Classification> Classifications { get; set; }
        public IEnumerable<Priority> Priorites { get; set; }
        public IEnumerable<IncidentStatusLkUp> IncidentStatus { get; set; }
        public IEnumerable<ContactMethod> ContactMethods { get; set; }
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<DeathIllness> DeathIllnesses { get; set; }
        public IEnumerable<DataSource> DataSources { get; set; }
        public IEnumerable<IncidentSource> IncidentSources { get; set; }
        public IEnumerable<UnitQuantity> Units { get; set; }
        public IEnumerable<SignalStatus> SignalStatus { get; set; }
        public IEnumerable<ProductType> ProductTypes { get; set; }
        public IEnumerable<AttachmentTagLkup> AttachmentTags { get; set; }
        public IEnumerable<FBOType> FBOTypes { get; set; }
        public IEnumerable<NotifierType> NotifierTypes { get; set; }
        public IEnumerable<AdminLead> AdminLeads { get; set; }
        public IEnumerable<ProductDateType> ProductDateTypes { get; set; }
        public IEnumerable<StakeholderType> StakeholderTypes { get; set; }
        public IEnumerable<StakeholderIncidentRole> StakeholderIncidentRoles { get; set; }
        public IEnumerable<CloseSignalReason> CloseSignalReasons { get; set; }
        public IEnumerable<CloseSignalTeam> CloseSignalTeams { get; set; }
        public IEnumerable<NoteTag> NoteTagTypes { get; set; }
    }
}
