﻿namespace Sims.Application.OnlineForm
{
    internal class ExternalOnlineForm
    {
        public string ReferenceNo { get; set; }
        public string IncidentTitle { get; set; }
        public int NotifierTypeId { get; set; }
        public string NatureOfProblem { get; set; } // Nature of problem
        public string ActionTaken { get; set; }
        public string DistributionDetails { get; set; }
        public string IllnessDetails { get; set; }
        public string LocalAuthorityNotified { get; set; }
        public string AdditionalInformation { get; set; }
    }
}
