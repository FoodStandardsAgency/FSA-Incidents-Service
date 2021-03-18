namespace FSA.IncidentsManagement.Root.DTOS
{
    public class SIMSIncidentDisplay : SIMSIncident
    {
        public string IncidentType { get; set; }
        public string SignalStatus {get;set;}
        public string IncidentStatus {get;set;}
        public string Notifier {get;set;}

        public string PrincipalFBO {get;set;}
        public string FBOEmail {get;set;} = "";
        public string FBOPhone {get;set;}
        public string FBOAddressLine1 {get;set;}
        public string FBOAddressLine2 {get;set;}
        public string FBOAddressTown {get;set;}
        public string FBOAddressPostcode {get;set;}
        public string Priority {get;set;}
        public string Classification {get;set;}
        public string DataSource {get;set;}
        public string ProductType {get;set;}
        public string LeadLocalAuthority {get;set;}
        public string DeathIllness {get;set;}
        public string AdminLead {get;set;}
        public string IncidentSource {get;set;}
        //public string FormattedOnlineFormid => this.OnlineFormId.HasValue ? GeneralExtensions.GenerateOnlineId(this.OnlineFormId.Value) : "";
    }
}
