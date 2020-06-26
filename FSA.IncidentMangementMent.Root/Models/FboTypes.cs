using System;
using System.Collections.Generic;
using System.Text;

namespace FSA.IncidentsManagement.Root.Models
{
    [Flags]
    public enum FboTypes
    {
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
