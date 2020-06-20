﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class IncidentDb : BaseEntityDb
    {
        public int Id { get; set; }
        public string IncidentTitle { get; set; }
        public string IncidentDescription { get; set; }
        public int IncidentTypeId { get; set; }
        public int ContactMethodId { get; set; }
        public ContactMethodDb ContactMethod { get; set; }
        public CategoryDb IncidentType { get; set; }
        public int? SignalStatusId { get; set; }
        public SignalStatusDb SignalStatus { get; set; }

        public int IncidentStatusId { get; set; }
        public IncidentStatusDb IncidentStatus { get; set; }
        public int? NotifierId { get; set; }
        public OrganisationDb Notifier { get; set; }

        public int? PrincipalFBOId { get; set; }
        public OrganisationDb PrincipalFBO { get; set; }
        public int PriorityId { get; set; }
        public PriorityDb Priority { get; set; }
        public int ClassificationId { get; set; }
        public ClassificationDb Classification { get; set; }
        public int DataSourceId { get; set; }
        public DataSourceDb DataSource { get; set; }
        public int ProductTypeId { get; set; }
        public ProductTypeDb ProductType { get; set; }
        
        public string LeadOfficer { get; set; }
        public string LeadOffice { get; set; }
        public string FieldOfficer { get; set; }

        public int? LeadLocalAuthorityId { get; set; }
        public OrganisationDb LeadLocalAuthority { get; set; }
        public bool LAAdvised { get; set; }
        public int DeathIllnessId { get; set; }
        public DeathIllnessDb DeathIllness { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public DateTime IncidentCreated { get; set; }
        public DateTime? IncidentClosed { get; set; }

        public ICollection<IncidentCommentDb> Comments { get; set; }
        
        public ICollection<IncidentLinkDb> FromLinks { get; set; }
        public ICollection<IncidentLinkDb> ToLinks { get; set; }

        
    }
}
