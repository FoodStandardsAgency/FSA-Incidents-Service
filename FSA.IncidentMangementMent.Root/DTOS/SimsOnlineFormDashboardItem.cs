using System;
using System.Collections.Generic;

namespace FSA.IncidentsManagement.Root.DTOS
{
    public class SimsOnlineFormDashboardItem
    {
        public string Id { get => GeneralExtensions.GenerateOnlineId(CommonId); }
        public int CommonId { get; set; }
        public string ReferenceNo { get; set; }
        public string Title { get; set; }
        public bool IsClosed { get; set; }
        public string Notifier { get; set; }
        public string Description { get; set; }
        public DateTime DateReceived { get; set; }
        public DateTime Updated { get; set; }

        public override string ToString()
        {
            return $"{Id} {Title} {IsClosed}";
        }
    }
}
