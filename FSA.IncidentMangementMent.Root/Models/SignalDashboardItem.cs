using System;

namespace FSA.IncidentsManagement.Root.Models
{
    public class SignalDashboardItem
    {
        public string Id { get => GeneralExtensions.GenerateSignalsId(CommonId); }
        public int CommonId { get; set; }
        public string Title { get; set; }
        public string Priority { get; set; }
        public string Notifier { get; set; }
        public string LeadOfficer { get; set; }
        public string Status { get; set; }
        public DateTime Updated { get; set; }
    }
}
