using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    [Flags]
    public enum DocumentTagTypes
    {
        CVED_CED = 1,
        AnalyticalReport = 2,
        Bill_DeliveryDocument = 4,
        FollowUp= 8,
        HealthCertifiacte = 16,
        PhytosanitaryCertifcate = 32,
        Picture = 64,
        Publicwarning_PressRelease = 128,
        RecipientsList = 256,
        RiskAssessment = 512,
        Screenshot = 1024,
        Translation = 2048,
        VideoFile = 4096,
        Other = 8192
    }
}
