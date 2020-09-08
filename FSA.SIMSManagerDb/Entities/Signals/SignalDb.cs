using FSA.IncidentsManagement.Root.Models;
using FSA.SIMSManagerDb.Entities.Core;
using FSA.SIMSManagerDb.Entities.Lookups;
using System;
using System.Collections.Generic;

namespace FSA.SIMSManagerDb.Entities
{
    internal class SignalDb : BaseEntityDb, IDbId, HostFields
    {
        public int Id { get; set; }
        public int? SPTId { get; set; }
        public string Title { get; set; }
        public int SignalStatusId { get; set; }
        public SignalStatusDb SignalStatus { get; set; }
        public string Priority { get; set; }
        public string LeadOfficer { get; set; }
        public string AlertType { get; set; }
        public string CountryOfOrigin { get; set; }
        public string NotifyingCountry { get; set; }
        public bool IsEu { get; set; }
        public string FoodOrFeed { get; set; }
        public string BaseProduct { get; set; }
        public string Manufacturer { get; set; }
        
        public string Hazard { get; set; }
        public string HazardGroup { get; set; }
        public string DataSource { get; set; }
        public string SourceType { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime InsertedDate { get; set; }
        public string SourceLink { get; set; }

        public ICollection<SignalAttachmentDb> Attachments { get; set; }
        public ICollection<SignalNoteDb> Notes { get; set; }
        public ICollection<SignalProductDb> Products { get; set; }
        public ICollection<SignalLinkDb> FromLinks { get; set; }
        public ICollection<SignalLinkDb> ToLinks { get; set; }
        public ICollection<SignalStakeholderDb> Stakeholders { get; set; }
    }
}
