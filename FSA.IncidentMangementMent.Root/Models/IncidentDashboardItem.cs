using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    public class IncidentDashboardItem
    {
        public string Id { get => GeneralExtensions.GenerateIncidentId(CommonId); }
        public int CommonId { get; set; }
        public string Priority { get; set; }
        public string Title { get; set; }
        public string Notifier { get; set; }
        public string LeadOfficer { get; set; }
        public string Status { get; set; }
        public DateTime Updated { get; set; }
        public IEnumerable<int> Links { get; set; }

        public override string ToString()
        {
            return $"{Id} {Title} {Priority} {Status} {LeadOfficer}";
        }
    }
}
