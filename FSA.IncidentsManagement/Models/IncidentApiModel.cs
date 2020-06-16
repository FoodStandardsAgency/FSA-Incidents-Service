﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSA.IncidentsManagement.Models
{
    public class IncidentApiModel
    {
        public int Id { get; set; }
        public string IncidentTitle { get; set; }
        public string IncidentDescription { get; set; }
        public int IncidentTypeId { get; set; }
        public int ContactMethodId { get; set; }
        public int StatusId { get; set; }
        public int? NotifierId { get; set; }     // organisations
        public int? PrincipalFBOId { get; set; } // Organisations
        public int ClassificationId { get; set; }
        public int DataSourceId { get; set; }
        public int ProductTypeId { get; set; }
        public string LeadOfficerId { get; set; }
        public string AdminLeadId { get; set; }
        public string FieldOfficerId { get; set; }
        public int LeadLocalAuthorityId { get; set; } // organisations
        public bool LAAdvised { get; set; }
        public int DeathIllnessId { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public DateTime IncidentCreated { get; set; }
        public DateTime? IncidentClosed { get; set; }
        public string LastChangedBy { get; set; }
        public DateTime LastChangedDate { get; set; }

    }
}
