﻿namespace FSA.IncidentsManagement.Root.Models
{
    public class PersonaRole    {

        public int Id{ get; set; }
        public string Title { get; set; }
        public bool CanBeAdminLead { get; set; }
        public bool CanBeIncidentLead { get; set; }
        public bool CanBeFieldOfficer { get; set; }
    }
}
