using System;
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
        public CategoryDb IncidentType { get; set; }
        public int StatusId { get; set; }
        public StatusDb Status { get; set; }
        public int? NotifierId { get; set; }
        public OrganisationDb Notifier { get; set; }

        public int? PrincipalFBOId { get; set; }
        public OrganisationDb PrincipalFBO { get; set; }
        public int ClassificationId { get; set; }
        public ClassificationDb Classification { get; set; }
        public int DataSourceId { get; set; }
        public DataSourceDb DataSource { get; set; }
        public int ProductTypeId { get; set; }
        public ProductTypeDb ProductType { get; set; }
        public int? LeadOfficerId { get; set; }
        public int? AdminLeadId { get; set; }
        public int? FieldOfficerId { get; set; }
        public int? LeadLocalAuthorityId { get; set; }
        public OrganisationDb LeadLocalAuthority { get; set; }
        public bool LAAdvised { get; set; }
        public int DeathIllnessId { get; set; }
        public DeathIllnessDb DeathIllness { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public DateTime IncidentCreated { get; set; }
        public DateTime? IncidentClosed { get; set; }
        public int LastChangedById { get; set; }
        public DateTime LastChangedDate { get; set; }

        public ICollection<IncidentCommentDb> Comments { get; set; }

        public string _reserved_importref { get; set; }
    }
}
