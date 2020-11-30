using FSA.SIMSManagerDb.Entities.Core;
using FSA.SIMSManagerDb.Entities.Lookups;
using System.Collections.Generic;

namespace FSA.SIMSManagerDb.Entities
{
    internal class OnlineFormDb : BaseEntityDb
    {
        public int Id { get; set; }
        public string ReferenceNo { get; set; }
        public string Title { get; set; }
        public int NotifierTypeId { get; set; }
        public NotifierTypeDb NotifierType { get; set; }
        public string Description{ get; set; } // Nature of problem
        public string Action { get; set; } 
        public string DistributionDetails{ get; set; }
        public string DeathIllness { get; set; }
        public string LADetails { get; set; }
        public string AdditionalInformation { get; set; }
        public int IncidentTypeId { get; set; }
        public bool IsClosed { get; set; }
        public int? IncidentId { get; set; }
        public HazardGroupDb IncidentType { get; set; }
        public ICollection<OnlineFormStakeholderDb> Stakeholders { get; set; }
        public ICollection<OnlineFormNoteDb> Notes { get; set; }
        public ICollection<OnlineFormProductDb> Products { get; set; }
    }
}

