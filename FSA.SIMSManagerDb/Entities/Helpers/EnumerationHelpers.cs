using System;

namespace FSA.SIMSManagerDbEntities.Helpers
{
    /// <summary>
    /// This is a helper to stop having to do unwise lookups
    /// Remember DB IncidentStatus Id values and these MUST BE THE SAME!!
    /// </summary>
    internal enum IncidentStatusTypes
    {
        Unknown = 0,
        Unassigned = 4,
        Open = 1,
        Closed = 2
    }

    internal enum SignalStatusTypes
    {
        Unassigned = 1,
        Open = 2,
        Pending = 3,
        Closed_Incident = 50,
        Closed_No_Incident = 100,
        Closed_Referrel_Offline = 150,
        Unknown = 0
    };

    internal enum PrioritiesStatus
    {
        Unknown = 0,
        TBC = 1,
        High = 2,
        Medium = 3,
        Low = 4
    }

    [Flags]
    internal enum DocumentTagTypes
    {
        Unknown = 0,
        CVED_CED = 1,
        AnalyticalReport = 2,
        Bill_DeliveryDocument = 4,
        FollowUp = 8,
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

    [Flags]
    public enum FboTypes
    {
        Unknown = 0,
        Consignor = 1,
        E_platform_Market = 2,
        E_trader = 4,
        Exporter = 8,
        Farmer = 16,
        Hospitality_service = 32,
        Importer = 64,
        Manufacturer = 128,
        Packer_filler = 256,
        Processor = 512,
        Producer = 1024,
        Retailer = 2048,
        Storage = 4096,
        Supplier = 8192,
        Trader_Broker = 16384,
        Transporter = 32768,
        Wholesaler = 65536,
    }

}
