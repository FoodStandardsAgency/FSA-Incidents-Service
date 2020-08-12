﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagementDb.Entities
{
    internal class StakeholderDb : BaseEntityDb
    {
        public int Id { get; set; }
        public int IncidentId { get; set; }
        public IncidentDb Incident { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int StakeholderDiscriminator { get; set; }
    }
}
