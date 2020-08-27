using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    class SignalDashboardView
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
