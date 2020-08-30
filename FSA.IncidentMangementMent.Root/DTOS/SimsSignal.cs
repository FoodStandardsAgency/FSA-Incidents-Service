using System;

namespace FSA.IncidentsManagement.Root.DTOS
{
    public class SimsSignal
    {
        public int Id { get; set; }
        public int? SPTId { get; set; }
        public string Title { get; set; }
        public string SignalStatus { get; set; }
        public string Priority { get; set; }
        public string LeadOfficer { get; set; }
        public string AlertType { get; set; }
        public string CountryOfOrigin { get; set; }
        public string NotifyingCountry { get; set; }
        public bool IsEu { get; set; }
        public string FoodOrFeed { get; set; }
        public string BaseProduct { get; set; }
        public string Manufacturer { get; set; }

        public string Hazard { get; set; }
        public string HazardGroup { get; set; }
        public string DataSource { get; set; }
        public string SourceType { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime InsertedDate { get; set; }
        public string SourceLink { get; set; }
    }
}
