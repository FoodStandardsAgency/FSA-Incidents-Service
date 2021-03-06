﻿using FSA.SIMSManagerDb.Entities.Core;
using FSA.SIMSManagerDb.Entities.Lookups;
using FSA.SIMSManagerDb.Entities.Signals;
using System;
using System.Collections.Generic;

namespace FSA.SIMSManagerDb.Entities
{
    internal class IncidentDb : BaseEntityDb, IDbId, HostFields
    {
        public IncidentDb()
        {
            this.FromLinks = new List<IncidentLinkDb>();
            this.ToLinks = new List<IncidentLinkDb>();
        }

        public int Id { get; set; }
        public Guid MostUniqueId { get; set; }
        public string IncidentTitle { get; set; }

        public int IncidentSourceId { get; set; }
        public IncidentSourceDb IncidentSource { get; set; }
        public int IncidentTypeId { get; set; }
        public HazardGroupDb IncidentType { get; set; }
        public int ContactMethodId { get; set; }
        public ContactMethodDb ContactMethod { get; set; }
        public int? SignalStatusId { get; set; }
        public SignalStatusDb SignalStatus { get; set; }

        public string SignalUrl { get; set; }

        public int IncidentStatusId { get; set; }
        public IncidentStatusDb IncidentStatus { get; set; }
        public int? NotifierId { get; set; }
        public AddressDb Notifier { get; set; }

        public int? PrincipalFBOId { get; set; }
        public AddressDb PrincipalFBO { get; set; }
        public int PriorityId { get; set; }
        public PriorityDb Priority { get; set; }
        public int ClassificationId { get; set; }
        public ClassificationDb Classification { get; set; }
        public int DataSourceId { get; set; }
        public DataSourceDb DataSource { get; set; }
        public int ProductTypeId { get; set; }
        public ProductTypeDb ProductType { get; set; }

        public int? AdminLeadId { get; set; }
        public AdminLeadDb AdminLead { get; set; }

        public string OIMTGroups { get; set; }

        public string LeadOfficer { get; set; }
        public string LeadOffice { get; set; }
        public string FieldOfficer { get; set; }

        public int? LeadLocalAuthorityId { get; set; }
        public AddressDb LeadLocalAuthority { get; set; }
        public bool LAAdvised { get; set; }
        public int? DeathIllnessId { get; set; }
        public DeathIllnessDb DeathIllness { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public DateTime IncidentCreated { get; set; }
        public DateTime? IncidentClosed { get; set; }
        public bool SensitiveInfo { get; set; }
        public int? OnlineFormId { get; set; }

        public ICollection<IncidentAttachmentDb> Attachments { get; set; }
        public ICollection<IncidentNoteDb> Notes { get; set; }
        public ICollection<IncidentProductDb> Products { get; set; }
        public ICollection<IncidentLinkDb> FromLinks { get; set; }
        public ICollection<IncidentLinkDb> ToLinks { get; set; }
        public ICollection<IncidentStakeholderDb> Stakeholders { get; set; }

        public ICollection<SignalIncidentLinkDb> IncidentSignalLinks { get; set; }
    }
}
