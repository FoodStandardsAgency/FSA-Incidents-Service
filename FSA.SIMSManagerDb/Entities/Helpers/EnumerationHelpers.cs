using System;
using System.Collections.Generic;
using System.Text;

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
        Closed_Incident = 4,
        Closed_No_Incident = 5,
        Unknown=0
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
