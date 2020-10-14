using System;
using System.Collections.Generic;

namespace FSA.IncidentsManagement.Root.Models
{
    public class SignalDashboardItem
    {
        public string Id { get => GeneralExtensions.GenerateSignalsId(CommonId); }
        public int CommonId { get; set; }
        public string Title { get; set; }
        public string Priority { get; set; }
        public string LeadOfficer { get; set; }
        public string DataSource { get; set; }
        public string Hazard { get; set; }
        public string BaseProduct { get; set; }
        public string Status { get; set; }
        public DateTime DateReceived { get; set; }
        public DateTime Updated { get; set; }
        public IEnumerable<int> Links { get; set; }

        public override string ToString()
        {
            return $"{Id} {Title} {Priority} {Status} {LeadOfficer}";
        }
    }
}
